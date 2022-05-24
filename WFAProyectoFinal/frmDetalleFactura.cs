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
   
    public partial class frmDetalleFactura : MetroFramework.Forms.MetroForm
    {
        public string ruta = @"C:\Users\Jose Medina\Desktop\FCECEP\POO\Visual Estudio\Trabajo Final\WFAProyectoFinal\IMGS\";
        NpgsqlConnection conn = new NpgsqlConnection("server = localhost; Port = 5432; User Id=postgres; Password =medinagego16; Database = VentaAlquiler ");//Realiza la conexion a la base de datos
        public frmDetalleFactura()
        {
            InitializeComponent();

            pctDFactura.BackgroundImage = Image.FromFile(ruta + "Detalle.png");
           pctDFactura.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void frmDetalleFactura_Load(object sender, EventArgs e)
        {
            conn.Open();
            DataSet datos = new DataSet();
            string query = "select *from Detalle_factura;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);//Cuando carga el formulario nos muestra en el datagridviwe los datos que se encuentran en detalle_factura
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conn);
           add.Fill(datos);
            mgvFactura.DataSource = datos.Tables[0];
            conn.Close();
        }

        private void mtltComprar_Click(object sender, EventArgs e)
        {
            DataSet datos = new DataSet();
            conn.Open();
            CrystalReport crystal = new CrystalReport();

            Crystal imprimir = new Crystal();
            imprimir.crystalReportViewer1.ReportSource = crystal;
            imprimir.Show();

            string query = "select * from factura;";
            NpgsqlCommand conectorr = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conn);
            add.Fill(datos);
            crystal.SetDataSource(datos.Tables[0]);
            crystal.Refresh();

            conn.Close();
        }
    }
}
