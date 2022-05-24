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
    public partial class frmRegistro : MetroFramework.Forms.MetroForm
    {
        public string ruta = @"C:\Users\giral\Desktop\4 SEMESTRE CECEP\LENGUAJE INFORMATICO\2 CORTE\PROYECTO FINAL JOSE MEDINA\WFAProyectoFinal\IMGS\";
        ToolTip ttp = new ToolTip();
        DataSet datos = new DataSet();
        NpgsqlConnection conn = new NpgsqlConnection("server = localhost; Port = 5432; User Id=postgres; Password =medinagego16; Database = VentaAlquiler ");
        public frmRegistro()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            //FONDO
            //this.BackgroundImage = Image.FromFile(ruta + "MAZDA.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            InitializeComponent();

            lblId.ForeColor = Color.Black;//CAMBIO DE COLOR EN CODIGO DEL LABEL
            txtId.ForeColor = Color.DarkGray;//CAMBIO DE COLOR DE UN TXT 

            lblId.Text = "Identificacion";
            lblNombres.Text = "Nombres";
            lblApellido.Text = "Apellidos";
            lblTelefono.Text = "Telefono";
            lblCorreo.Text = "Correo";
            lblEdad.Text = "Edad";

            txtId.Text = "Digite su Id";
            txtId.ForeColor = Color.DarkGray;

            txtNombre.Text = "Nombres";
            txtNombre.ForeColor = Color.DarkGray;//Se le da el nombre a los label,txt y su respectivo colo mediante el forecolor

            txtApellido.Text = "Apellido";
            txtApellido.ForeColor = Color.DarkGray;

            txtCorreo.Text = "Correo";
            txtCorreo.ForeColor = Color.DarkGray;

            txtTelefono.Text = "Telefono";
            txtTelefono.ForeColor = Color.DarkGray;


            //CommboBox
            cboEdad.Items.Add("Seleccionar");
            for (int i = 1; i < 100; i++)
            {

                cboEdad.Items.Add(i);//Combobox donde me muestra la edad por medio de un ciclo del 1 al 100

            }

            cboEdad.SelectedIndex = 0;//Selecciona en que pocision quiere que muestre el combobox cuando se abra el formulario

            //botones

            btnRegistro.Text = "Registrar";//Se le da el nombre al formulario
            btnsalir.Text = "Salir";

            //tooltiptex botones
            ttp.SetToolTip(btnRegistro, "Click para Registrarse");
            ttp.SetToolTip(btnsalir, "Click para salir");
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "Digite su Id")
            {
                MessageBox.Show("Por favor rellene el dato Identificacion" );//Si la condicion se cumple no me dejara registrarme hasta que la persona coloque su identificacion y correo
            }
            else if (txtCorreo.Text == "Correo")
            {
                MessageBox.Show("Por favor rellene el dato de correo");

            }
            else
            {


                    string Identificacion = txtId.Text;
                    string Nombres = txtNombre.Text;
                    string apellidos = txtApellido.Text;//A cada txt le pongo una variable para poder llamarlo en el metodo que esta en la clase conexion
                    string telefono = txtTelefono.Text;
                    string correo = txtCorreo.Text;
                    int edad = int.Parse(cboEdad.Text);

                    Conexion C = new Conexion();
                    C.Registro(Identificacion, Nombres, apellidos, telefono, correo, edad);//Metodo que se encuentra ubicado en conexion donde le ingreso los parametros para que me guarde los datos en la tabla

              
            }

        }
        public void keyprees(KeyPressEventArgs e)
        {

            //Condicion que solo nos permite ingresar datos de tipo texto
            //if (char.IsLetter(e.KeyChar))
            //{
            //    e.Handled = false;
            //}

            ////Condicion que no permite dar salto de linea cunado presiona enter
            //else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            //{
            //    e.Handled = false;
            //}

            ////Condicion que nos permite utilizar la tecla backspace
            //else if (char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}

            ////Condicion que nos permite utilizar la tecla espacio
            //else if (char.IsSeparator(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}

        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }


        private void txtId_Enter(object sender, EventArgs e)
        {
            //PlaceHolder para poder visualizar en el txt una mensaje que se desaparece cundo le doy click para escribir

            if (txtId.Text.Equals("Digite su Id"))
            {
                txtId.Text = "";
                txtId.ForeColor = Color.Black;
                lblId.ForeColor = Color.Green;//para poner la fuente roja_oscura
                lblId.Font = new Font(lblId.Font, FontStyle.Bold);//para poner la fuente en negrilla
            }
     

           
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Text.Equals (""))
            {
                txtId.Text = "Digite su Id";
                txtId.ForeColor = Color.DarkGray;
                lblId.ForeColor = Color.DarkRed;//para poner la fuente roja_oscura
                lblId.Font = new Font(lblId.Font, FontStyle.Bold);//para poner la fuente en negrilla
            }
           

         
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("Nombres"))
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
                lblNombres.ForeColor = Color.Green;
                lblNombres.Font = new Font(lblTelefono.Font, FontStyle.Bold);
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                txtNombre.Text = "Nombres";
                txtNombre.ForeColor = Color.DarkGray;
                lblNombres.ForeColor = Color.DarkRed;//para poner la fuente roja_oscura
                lblNombres.Font = new Font(lblId.Font, FontStyle.Bold);//para poner la fuente en negrilla
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Equals("Telefono"))
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
                lblTelefono.ForeColor = Color.Green;
                lblTelefono.Font = new Font(lblTelefono.Font, FontStyle.Bold);
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Equals(""))
            {
                txtTelefono.Text = "Telefono";
                txtTelefono.ForeColor = Color.DarkGray;
                lblTelefono.ForeColor = Color.DarkRed;//para poner la fuente roja_oscura
                lblTelefono.Font = new Font(lblId.Font, FontStyle.Bold);//para poner la fuente en negrilla
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text.Equals("Apellido"))
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
                lblApellido.ForeColor = Color.Green;
                lblApellido.Font = new Font(lblTelefono.Font, FontStyle.Bold);
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text.Equals(""))
            {
                txtApellido.Text = "Apellido";
                txtApellido.ForeColor = Color.DarkGray;
                lblApellido.ForeColor = Color.DarkRed;//para poner la fuente roja_oscura
                lblApellido.Font = new Font(lblId.Font, FontStyle.Bold);//para poner la fuente en negrilla
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Equals("Correo"))
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
                lblCorreo.ForeColor = Color.Green;
                lblCorreo.Font = new Font(lblTelefono.Font, FontStyle.Bold);
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Equals(""))
            {
                txtCorreo.Text = "Correo";
                txtCorreo.ForeColor = Color.DarkGray;
                lblCorreo.ForeColor = Color.DarkRed;//para poner la fuente roja_oscura
                lblCorreo.Font = new Font(lblId.Font, FontStyle.Bold);//para poner la fuente en negrilla
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condicion que solo nos permite ingresar datos de tipo texto
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //Condicion que no permite dar salto de linea cunado presiona enter
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = false;
            }
            //Condicion que nos permite utilizar la tecla espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }



        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
