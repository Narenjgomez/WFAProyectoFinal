using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MetroFramework.Forms;
using MetroFramework;
using Npgsql;
using NpgsqlTypes;

namespace WFAProyectoFinal
    
{
    public partial class frmPrincipal : MetroFramework.Forms.MetroForm
    {
        public string ruta = @"C:\Users\Jose Medina\Desktop\FCECEP\POO\Visual Estudio\Trabajo Final\WFAProyectoFinal\IMGS\";


        NpgsqlConnection conn = new NpgsqlConnection("server = localhost; User Id=postgres; Password =medinagego16; Database = VentaAlquiler ");//Realizamos la conexion a la base de datos en postgresql
                                                    //Ponemos el nombre del server, colocamos la id, la contraseña que pusimos al principio cuando instalamos postgres y por ultimo el nombre de la base de datos
        public bool Login;
        public frmPrincipal()
        {
            //FONDO
            this.BackgroundImage = Image.FromFile(ruta + "fondocar.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.WindowState = FormWindowState.Maximized;//Cuando abramos la pestaña automaticamente va abir maximizada
            IsMdiContainer = true;//No indica que este formulario es padre 
            InitializeComponent();
            frmLogin Log = new frmLogin();
           
            mgrpTitulo.Text = "";
            //label
            lblIdentificacion.Text = "Identificacion: ";
            lblId.ForeColor = Color.Red;
            lblId.Font = new Font("Verdana", 10, FontStyle.Bold);  //Ponemos nombre a los label y con el font le podemops cambiar el tipo de letra y con el forecolor podemos cambiar el color         
            
            lblId.Text = "xxxxxxxxxx";

            lblFecha.Font = new Font("Verdana", 8, FontStyle.Bold);
            lblHora.Font = new Font("Verdana", 8, FontStyle.Bold);
            lblId.Font = new Font("Verdana", 8, FontStyle.Bold);


            //Button


            //Item

            ItmVentayAlquiler.Text = "Venta y Alquiler";
            ItmVenta.Text = "Venta";
            ItmAlquiler.Text = "Alquiler";
            ItmNavegar.Text = "Navegar";
            ItmLogin.Text = "Login";//Ponemos el nombre a los item que se encuentra en la parte superior del menu
            ItmLoginU.Text = "Login";
            ItmRegister.Text = "Register";
            ItmConsultas.Text = "Consulta";
            ItmUsuarios.Text = "Usuarios";
            ItmFactura.Text = "Factura";
            itmIncidencias.Text = "Incidencias";
            ItmCompra.Text = "Compra";
            itmEmpleados.Text = "Empleados";

           // ItmConsultas.Enabled = false;
            //ItmVenta.Enabled = false;
            //ItmAlquiler.Enabled = false;

            dtpFecha.Visible = false;

       
            if (lblId.Text == Log.txtId.Text)
            {
                MessageBox.Show("Numero de identificacion " + lblId.Text);//Condicional para que el labe tome el valor del txt de login y el item quede encendido 
                ItmVentayAlquiler.Enabled = true;
                
            }
            else
            {
                ItmVentayAlquiler.Enabled = false;
            }


            ItmRegister.Image = Image.FromFile(ruta + "Registro.png");
            ItmCompra.Image = Image.FromFile(ruta + "compras.png");
            ItmUsuarios.Image = Image.FromFile(ruta + "Usuario.png");
            ItmFactura.Image = Image.FromFile(ruta + "Factura.png");
            ItmNavegar.Image = Image.FromFile(ruta + "Navegar.png");
            itmIncidencias.Image = Image.FromFile(ruta + "Incidencias.png");
            itmEmpleados.Image = Image.FromFile(ruta + "Empleados.png");
            ItmLogin.Image = Image.FromFile(ruta + "Login.png");
            ItmLoginU.Image = Image.FromFile(ruta + "Login.png");
            ItmConsultas.Image = Image.FromFile(ruta + "Navegar.png");


        }

        private void ItmVenta_Click(object sender, EventArgs e)
        {
            DialogResult op;
            op = MetroMessageBox.Show(this, "Seguro que deseas realizar una venta",
             "Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);//No saca un mensaje en donde nos sale dos boten de ok y cancell  

            if (op == DialogResult.OK)
            {
               // conn.Open ();             
                frmVenta venta = new frmVenta();//Condicional donde abre el formulario venta cuando le damos al boton OK
                venta.Show();

            }
            else
            {
                MessageBox.Show("Elija otra opcion");
            }

        }

        private void ItmAlquiler_Click(object sender, EventArgs e)
        {
            frmAlquiler alquiler = new frmAlquiler();
            alquiler.MdiParent = this;//Abre el formulario en hijo
            alquiler.Show();
        }

        private void ItmRegister_Click(object sender, EventArgs e)
        {
            frmRegistro R = new frmRegistro();
            R.MdiParent = this;//Abre el formulario en hijo
            R.Show();
        }

        private void ItmLoginU_Click(object sender, EventArgs e)
        {
            frmLogin L = new frmLogin();
            L.Show();//Abre el formulario pero no como hijo
            this.Hide();
            Login = false;          
        }

        private void ItmVentayAlquiler_Click(object sender, EventArgs e)
        {
            frmLogin L = new frmLogin();

            if(L.hola == true)
            {
                ItmVentayAlquiler.Enabled = true;
               
            }
        }

        private void ItmFactura_Click(object sender, EventArgs e)
        {
            frmConsulta C = new frmConsulta();
            C.MdiParent = this;
            C.Show();
        }

        private void ItmFactura_Click_1(object sender, EventArgs e)
        {
            frmFactura F = new frmFactura();
            F.MdiParent = this;//Abre el formulario en hijo
            F.Show();
        }

        private void ItmNavegar_Click(object sender, EventArgs e)
        {
            frmNavegar N = new frmNavegar();
            N.MdiParent = this;//Abre el formulario en hijo
            N.Show();
        }

        private void itmIncidencias_Click(object sender, EventArgs e)
        {
            frmIncidencias I = new frmIncidencias();
            I.MdiParent = this;//Abre el formulario en hijo
            I.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string Fecha = "dddd MMMM yyyy  ";
            DateTime fecha = dtpFecha.Value;
            lblFecha.Text = fecha.ToString(Fecha);


            string Hora = "h:mm:ss ";
            DateTime hora = dtpFecha.Value;
            lblHora.Text = hora.ToString(Hora);
        }

        private void ItmCompra_Click(object sender, EventArgs e)
        {
            frmVehiculo V = new frmVehiculo();
            V.MdiParent = this;
            V.Show();

        }

        private void itmEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados E = new frmEmpleados();
            E.MdiParent = this;
            E.Show();
        }
    }
    
}
