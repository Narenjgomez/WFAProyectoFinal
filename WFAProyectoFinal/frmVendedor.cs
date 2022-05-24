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
    public partial class frmVendedor : MetroFramework.Forms.MetroForm
    {
        NpgsqlConnection conn = new NpgsqlConnection("server = localhost; Port = 5432; User Id=postgres; Password =medinagego16; Database = VentaAlquiler ");
        public frmVendedor()
        {
            InitializeComponent();

            txtcodigo.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtCorreo.Enabled = false;
            txtTelefono.Enabled = false;
            txtCargo.Enabled = false;
        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {
            DataSet datos = new DataSet();
            string query = "select *from vendedor;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conn);
            add.Fill(datos);
            mgvempleados.DataSource = datos.Tables[0];
            conn.Close();
        }

        private void mgvempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = mgvempleados.CurrentRow;
            txtcodigo.Text = Convert.ToString(fila.Cells[0].Value);
            txtNombre.Text = Convert.ToString(fila.Cells[1].Value);
            txtApellido.Text = Convert.ToString(fila.Cells[2].Value);//Cuando seleccionamos la fila dentro del datagridview se muestran en el txt en el orden que los puse 
            txtCorreo.Text = Convert.ToString(fila.Cells[3].Value);
            txtTelefono.Text = Convert.ToString(fila.Cells[4].Value);
            txtCargo.Text = Convert.ToString(fila.Cells[5].Value);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
