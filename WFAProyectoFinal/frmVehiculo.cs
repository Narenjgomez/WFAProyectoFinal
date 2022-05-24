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
    public partial class frmVehiculo : MetroFramework.Forms.MetroForm
    {
        NpgsqlConnection conn = new NpgsqlConnection("server = localhost; Port = 5432; User Id=postgres; Password =medinagego16; Database = VentaAlquiler ");
        public frmVehiculo()
        {
            InitializeComponent();
            pnlCliente.Visible = false;

            txtId.Enabled = false;
            txtColor.Enabled = false;
            txtKilometros.Enabled = false;
            txtPlaca.Enabled = false;
            txtPrecioA.Enabled = false;
            txtPrecioC.Enabled = false;
            txtModelo.Enabled = false;

            btnAlquilar.Text = "Alquilar";
            btnCliente.Text = "Cliente";
            btnCompra.Text = "Compra";
            btnSalir.Text = "Salir";
            btnVendedor.Text = "Vendedor";
         

               
        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            DataSet datos = new DataSet();
            string query = "select * from Vehiculo;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conn);
            add.Fill(datos);
            mgvVehiculos.DataSource = datos.Tables[0];
            conn.Close();
        }

        private void mgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = mgvVehiculos.CurrentRow;
            txtPlaca.Text = Convert.ToString(fila.Cells[0].Value);
            txtColor.Text = Convert.ToString(fila.Cells[1].Value);
            txtKilometros.Text = Convert.ToString(fila.Cells[2].Value);//Cuando seleccionamos la fila dentro del datagridview se muestran en el txt en el orden que los puse 
            txtModelo.Text = Convert.ToString(fila.Cells[3].Value);
            txtPrecioC.Text = Convert.ToString(fila.Cells[4].Value);
            txtPrecioA.Text = Convert.ToString(fila.Cells[5].Value);
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Porfavor presione el boton clientes y seleccione un identificacion");
            }
            else
            {
                conn.Open();
                string placa = txtPlaca.Text;
                string identificacion = txtId.Text;
                int precio = int.Parse(txtPrecioC.Text);
                float iva = 0.19f;

                double preciofinal;
                preciofinal = precio * iva;
                preciofinal = precio + preciofinal;

                try
                {
                    NpgsqlCommand conector = new NpgsqlCommand("insert into factura values (default,'" + identificacion + "','" + placa + "','" + "0.19" + "','" + preciofinal + "','" + "Comprado" + "');", conn);
                    conector.ExecuteNonQuery();

                    MessageBox.Show("Datos ingresados a la factura");
                }
                catch (NpgsqlException M)
                {
                    MessageBox.Show("Error" + M.Message);
                    throw;
                }

                conn.Close();
            }
            
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

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string placa = txtPlaca.Text;
            string identificacion = txtId.Text;
            string precio = txtPrecioA.Text;
            
         try
            {
                NpgsqlCommand conector = new NpgsqlCommand("insert into factura values (default,'" + identificacion + "','" + placa + "','" + "0.00" + "','" + precio + "','" + "Alquilado" + "');", conn);
                conector.ExecuteNonQuery();

                MessageBox.Show("Datos ingresados a la factura");
            }
            catch (NpgsqlException M)
            {
                MessageBox.Show("Error" + M.Message);
                throw;
            }

            conn.Close();
        }

        private void mgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaC = mgvClientes.CurrentRow;
            txtId.Text = Convert.ToString(filaC.Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlCliente.Visible = false;
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            frmVendedor V = new frmVendedor();
            V.Show();

        }
    }
    }

