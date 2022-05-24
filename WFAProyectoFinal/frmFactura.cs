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
using CrystalDecisions;

namespace WFAProyectoFinal
{
    public partial class frmFactura : MetroFramework.Forms.MetroForm
    {
        public string ruta = @"C:\Users\Jose Medina\Desktop\FCECEP\POO\Visual Estudio\Trabajo Final\WFAProyectoFinal\IMGS\";
        NpgsqlConnection conn = new NpgsqlConnection("server = localhost; Port = 5432; User Id=postgres; Password =medinagego16; Database = VentaAlquiler ");
        public frmFactura()
        {
         
            InitializeComponent();

            //panel1.BackgroundImage = Image.FromFile(ruta + "MAZDA.jpg");
            //panel1.BackgroundImageLayout = ImageLayout.Stretch;

            mtltConfirmar.Text = "Confirmar";
            mtllTotal.Text = "Total";
           // panel1.BackColor = Color.AliceBlue;
            //label
            lblDatos.Text = "Datos";

            //
            txtFecha.Enabled = false;
            txtid.Enabled = false;
            mgvTotal.Visible = false;
            dtpFecha.Enabled = false;

            pnlTotal.BackgroundImage = Image.FromFile(ruta + "frmFacturacion.png");
            pnlTotal.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            string Fecha = "d/MM/yyyy";
            DateTime fecha = dtpFecha.Value;
            txtFecha.Text = fecha.ToString(Fecha);

            conn.Open();
            DataSet datos = new DataSet();
            pnlTotal.Visible = true;
          
            string query = "select * from factura;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conn);
            add.Fill(datos);
            mgvFactura.DataSource = datos.Tables[0];
            conn.Close();
        }

      

        private void mtllTotal_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                NpgsqlCommand conector = new NpgsqlCommand("select sum(preciofinal) from factura", conn);
                conector.ExecuteNonQuery();
                mgvTotal.Visible = true;
                pnlTotal.Visible = false;
                MessageBox.Show("Este es el total a pagar");
                select();
            }
            catch (NpgsqlException M)
            {
                MessageBox.Show("Error" + M.Message);
                throw;
            }

            conn.Close();
        }
        public void select()
        {
         
            DataSet datos = new DataSet();
            string query = "select sum(preciofinal) from factura";
            pnlTotal.Visible = true;
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conn);
            add.Fill(datos);
            mgvTotal.DataSource = datos.Tables[0];
            conn.Close();

        }


        public void selectE()
        {
       
            DataSet datos = new DataSet();
            string query = "select *from factura";           
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conn);
            add.Fill(datos);
            mgvFactura.DataSource = datos.Tables[0];
            conn.Close();

        }

        private void mtltConfirmar_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {

            }
            else
            {
                string identificacion = txtid.Text;
                conn.Open();
                double total = 0;

                foreach (DataGridViewRow suma in mgvFactura.Rows)
                {
                    total += Convert.ToDouble(suma.Cells["preciofinal"].Value);
                }


                DataSet datos = new DataSet();
                MessageBox.Show("Felicidades usted ha realizado su compra\n"
                         + "Muchas gracias por comprar en nuestra empresa");




                try
                {
                    // NpgsqlCommand conector = new NpgsqlCommand("delete from factura where iva= '"+ "0.19"+ "'", conn);
                    //  conector.ExecuteNonQuery();
                    // selectE();



                    NpgsqlCommand conector = new NpgsqlCommand("insert into Detalle_factura values (default,'" + identificacion + "','" + total + "','" + txtFecha.Text + "');", conn);
                    conector.ExecuteNonQuery();

                    MessageBox.Show("Factura agregada a consultas");
                    frmDetalleFactura Ir = new frmDetalleFactura();
                    Ir.Show();
                    this.Close();
                }
                catch (NpgsqlException M)
                {
                    MessageBox.Show("Error" + M.Message);
                    throw;
                }

                conn.Close();
            }
           
        }

        private void mgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = mgvFactura.CurrentRow;
            txtid.Text = Convert.ToString(fila.Cells[1].Value);
            
        }
    }
}
 


