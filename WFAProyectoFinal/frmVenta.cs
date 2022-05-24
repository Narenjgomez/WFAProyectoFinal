using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace WFAProyectoFinal
{
    public partial class frmVenta : MetroFramework.Forms.MetroForm
    {
        public string id;
      
        NpgsqlConnection conn = new NpgsqlConnection("server = localhost; Port = 5432; User Id=postgres; Password =medinagego16; Database = VentaAlquiler ");
       

        public frmVenta()
        {

            InitializeComponent();

            frmLogin L = Owner as frmLogin;

            mtxtPlaca.Enabled = false;
            txtIdentificacion.Enabled = false;
            mtxtPrecio.Enabled = false;
            txtId.Enabled = false;
         

            //title
            mTltAgregar.Text = "Agregar para la compra";

     
            //Lable
            MLblPlaca.Text = "Placa";
            MlblPrecio.Text = "Precio";

            pnlCliente.Visible = false;
            
         

        

            id = txtId.Text;
      
          
        }

        private void mdgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = mdgvVenta.CurrentRow;
            txtId.Text = Convert.ToString(fila.Cells[0].Value);       
            mtxtPrecio.Text = Convert.ToString(fila.Cells[1].Value);
            mtxtPlaca.Text = Convert.ToString(fila.Cells[2].Value);


        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            DataSet datos = new DataSet();
            conn.Open();
            string query = "select * from venta;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conn);
            add.Fill(datos);
            mdgvVenta.DataSource = datos.Tables[0];
            conn.Close();
            // consultar();
            

            //mdgvVenta.DataSource = LLenar();
        }

        private void mTltAgregar_Click(object sender, EventArgs e)
        {
            conn.Open();                        
            string placa = mtxtPlaca.Text;
            string identificacion = txtId.Text;
            int precio = int.Parse(mtxtPrecio.Text);
            float iva = 0.19f;

            double preciofinal;
            preciofinal = precio * iva;
            preciofinal = precio + preciofinal;

            try
            {
                NpgsqlCommand conector = new NpgsqlCommand("insert into factura values (default,'" + identificacion + "','" + placa + "','" + "0.19" + "','" + preciofinal + "');", conn);
                conector.ExecuteNonQuery();

                MessageBox.Show("Factura agregada a consultas");
            }
            catch (NpgsqlException M)
            {
                MessageBox.Show("Error" + M.Message);
                throw;
            }

            conn.Close();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            DataSet datos = new DataSet();
            pnlCliente.Visible = true;
            conn.Open();
            string query = "select * from usuarios;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conn);
            add.Fill(datos);
            mgvClientes.DataSource = datos.Tables[0];
            conn.Close();
        }

        private void mgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaC = mgvClientes.CurrentRow;
            txtIdentificacion.Text = Convert.ToString(filaC.Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlCliente.Visible = false;
        }
        //public DataTable LLenar()
        //{


        //    conn.Open();

        //    string query = "select * from venta";
        //    NpgsqlCommand conector = new NpgsqlCommand(query, conn);
        //    NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conn);
        //    DataTable tabla = new DataTable();
        //    add.Fill(tabla);
        //    conn.Close();
        //    return tabla;
        //}



    }


}
