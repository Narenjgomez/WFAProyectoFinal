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
    public partial class frmIncidencias : MetroFramework.Forms.MetroForm
    {
        string ruta = @"C:\Users\Jose Medina\Desktop\FCECEP\POO\Visual Estudio\Trabajo Final\WFAProyectoFinal\IMGS\";

        NpgsqlConnection conn = new NpgsqlConnection("server = localhost; Port = 5432; User Id=postgres; Password =medinagego16; Database = VentaAlquiler ");
        public frmIncidencias()
        {
            InitializeComponent();

            PctIncidencias.BackgroundImage = Image.FromFile(ruta + "frmIncidencias.png");
            PctIncidencias.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void Incidencias_Load(object sender, EventArgs e)
        {
            DataSet datos = new DataSet();
            string query = "select *from incidencias;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conn);
            add.Fill(datos);
            dgvIncidecias.DataSource = datos.Tables[0];
            conn.Close();

        }
    }
}
