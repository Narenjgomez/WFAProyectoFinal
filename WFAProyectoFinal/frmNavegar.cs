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
    public partial class frmNavegar : MetroFramework.Forms.MetroForm
    {
        ToolTip ttp = new ToolTip();
        DataSet datos = new DataSet();
        NpgsqlConnection conn = new NpgsqlConnection("server = localhost; Port = 5432; User Id=postgres; Password =medinagego16; Database = VentaAlquiler ");
        NpgsqlDataAdapter da = new NpgsqlDataAdapter();
        public frmNavegar()
        {
            InitializeComponent();
            txtId.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;//Todos lo txt estan desabilitados para que no se puedan moficiar y simplemente se pueda ver 
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            txtEdad.Enabled = false;


            //Imagenes por medio de Bitmap
            Bitmap primero = new Bitmap(Application.StartupPath + @"\IMGS\Primero_opt.png");//Seleccionamos el nombre del boton y le colocamos la imagen que queramos 
            btnPrimero.Image = primero;

            Bitmap Anterior = new Bitmap(Application.StartupPath + @"\IMGS\anterior_opt.png");//Seleccionamos el nombre del boton y le colocamos la imagen que queramos 
            btnAnterior.Image = Anterior;

            Bitmap Siguiente = new Bitmap(Application.StartupPath + @"\IMGS\Siguiente_opt.png");//Seleccionamos el nombre del boton y le colocamos la imagen que queramos 
            btnSiguiente.Image = Siguiente;

            Bitmap Ultimo = new Bitmap(Application.StartupPath + @"\IMGS\Ultimo_opt.png");//Seleccionamos el nombre del boton y le colocamos la imagen que queramos 
            btnUltimo.Image = Ultimo;


           btnSalir.BackgroundImage = Image.FromFile(@"C:\Users\Jose Medina\Desktop\FCECEP\POO\Visual Estudio\Trabajo Final\WFAProyectoFinal\IMGS\Salir.png");

            ttp.SetToolTip(btnPrimero, "Click para primer registro");
            ttp.SetToolTip(btnAnterior, "Click paara anterior registro");//Tooltiptext muestra un mensaje cuando se pone encima el cursor de mouse indicando que hace ese boton 
            ttp.SetToolTip(btnSiguiente, "Click para siguiente registro");
            ttp.SetToolTip(btnUltimo, "Click para ultimo registro");
            ttp.SetToolTip(btnSalir, "Click para salir");
        }
        BindingSource tbl = new BindingSource();

        private void frmNavegar_Load(object sender, EventArgs e)
        {
            string query = "select * from usuarios;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conn);
            add.Fill(datos);
            mg.DataSource = datos.Tables[0];
            tbl.DataSource = datos.Tables[0];
            txtId.DataBindings.Add(new Binding("Text", tbl, "identificacion"));
            txtNombre.DataBindings.Add(new Binding("Text", tbl, "nombres"));
            txtApellido.DataBindings.Add(new Binding("Text", tbl, "apellidos"));//Me permite mover por lo registros mediante un boton en donde cada txt se le asigna su valor correspondiente a como este en la base de datos
            txtTelefono.DataBindings.Add(new Binding("Text", tbl, "telefono"));
            txtCorreo.DataBindings.Add(new Binding("Text", tbl, "correo"));
            txtEdad.DataBindings.Add(new Binding("Text", tbl, "edad"));
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            tbl.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)//Cada evento me permite moverme por los diferentes registros 
        {
            tbl.MovePrevious();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            tbl.MoveNext();
        }

       
        private void btnUltimo_Click_1(object sender, EventArgs e)
        {
            tbl.MoveLast();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
