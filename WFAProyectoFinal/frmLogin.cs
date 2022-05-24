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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        string ruta = @"C:\Users\Jose Medina\Desktop\FCECEP\POO\Visual Estudio\Trabajo Final\WFAProyectoFinal\IMGS\";
        ToolTip ttp = new ToolTip();
        public string id;
        public bool hola;
        NpgsqlConnection conn = new NpgsqlConnection("server = localhost; Port = 5432; User Id=postgres; Password =medinagego16; Database = VentaAlquiler ");//Con esto realizamos la conexion a nuestra base de datos
        Conexion C = new Conexion();
        public frmLogin()
        {

            InitializeComponent();

            //label
            lblId.Text = "Identificacion";
            lblCorreo.Text = "Correo";    //Seleccionamos el nombre de los label para poder identificarlos
            lblProgess.Text = "0" + "%";


            id = txtId.Text;
            tmrProgessbar.Enabled = false;

            //button
            btnSalir.Text = "Salir";
            Bitmap login = new Bitmap(Application.StartupPath + @"\IMGS\login_opt.png");//Seleccionamos el nombre del boton y le colocamos la imagen que queramos 
            btnLogin.Image = login;

            //Tooltiptext botones
            ttp.SetToolTip(btnLogin, "Click para loguearse");
            ttp.SetToolTip(btnSalir, "Click para salir");


            pctCarga.BackgroundImage = Image.FromFile(ruta + "rMazda6.png");
            pctCarga.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            string id = txtId.Text;
            string correo = txtCorreo.Text;

            //C.Login(id,correo);

            NpgsqlCommand cm = new NpgsqlCommand("select *from usuarios where identificacion = '" + id + "' and correo = '" + correo + "'", conn);
            conn.Open();//Nos permite abrir la conexion a la base de datos postgresql
            NpgsqlDataReader dr = cm.ExecuteReader();//Permite leer la sentencia que nosotros queramos

           // NpgsqlCommand em = new NpgsqlCommand("select *from empleados where codempleado = '" + id + "' and correo = '" + correo + "'", conn);
            //conn.Open();//Nos permite abrir la conexion a la base de datos postgresql
            //NpgsqlDataReader ep = em.ExecuteReader();//Permite leer la sentencia que nosotros queramos

            if (dr.Read())
            {
                progessbar L = new progessbar();
                MessageBox.Show("Datos ingresados de forma correcta");//Dentro del boton ponemos una condicional donde nos diga si los valores que estan dentro del id y correo se encuentran en la tabla 
                frmPrincipal P = new frmPrincipal();
                tmrProgessbar.Enabled = true;
                conn.Close();//Cierra la conexion que tenes en la base de datos

            }
           
            else
            {
                MessageBox.Show("Error identificacion/correo incorrectos");
                conn.Close();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal P = new frmPrincipal();
            this.Close();//Cierra el formulario
            P.ShowDialog();

        }

        private void tmrProgessbar_Tick(object sender, EventArgs e)
        {
            tmrProgessbar.Enabled = true;
            prgB1.Value++;
            lblProgess.Text = prgB1.Value + ("%");
            if (prgB1.Value == prgB1.Maximum)
            {
                frmPrincipal P = new frmPrincipal();//Timepicker que hace que la barra de progreso comience a moverse hasta llegar al numero maximo que es 100
                tmrProgessbar.Enabled = false;
                P.lblId.Text = txtId.Text;
                MessageBox.Show("Has ingresado de forma correcta");
                P.ItmVentayAlquiler.Enabled = true;
                P.ItmConsultas.Enabled = true;
                this.Hide();
                P.Show();

            }
            if (prgB1.Value > 0 && prgB1.Value < 30)
            {
                pctCarga.BackgroundImage = Image.FromFile(ruta + "rMazda6.png");
                pctCarga.BackgroundImageLayout = ImageLayout.Stretch;

            }
            else if (prgB1.Value > 30 && prgB1.Value < 60)
            {
                pctCarga.BackgroundImage = Image.FromFile(ruta + "Camaro.png");
                pctCarga.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (prgB1.Value > 60 && prgB1.Value < 80)
            {
                pctCarga.BackgroundImage = Image.FromFile(ruta + "Patrol.png");
                pctCarga.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (prgB1.Value > 80 && prgB1.Value < 100)
            {
                pctCarga.BackgroundImage = Image.FromFile(ruta + "Onix.png");
                pctCarga.BackgroundImageLayout = ImageLayout.Stretch;

            }
        }

    }
}

