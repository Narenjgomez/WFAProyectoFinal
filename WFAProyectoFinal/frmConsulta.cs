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
    public partial class frmConsulta : MetroFramework.Forms.MetroForm
    {
        string ruta = @"C:\Users\Jose Medina\Desktop\FCECEP\POO\Visual Estudio\Trabajo Final\WFAProyectoFinal\IMGS\";
        NpgsqlConnection conn = new NpgsqlConnection("server = localhost; Port = 5432; User Id=postgres; Password =medinagego16; Database = VentaAlquiler ");//Realizamos la conexion a la base de datos en postgresql
                                        //Ponemos el nombre del server, colocamos la id, la contraseña que pusimos al principio cuando instalamos postgres y por ultimo el nombre de la base de datos
        public frmConsulta()
        {
            InitializeComponent();

            frmLogin L = new frmLogin();
            txtId.Text = L.txtId.Text;

            //label
            lblId.Text = "Identificacion";
            lblNombres.Text = "Nombres";
            lblApellido.Text = "Apellido";//Colocamos el nombre a los label
            lblCorreo.Text = "Correo";
            lblEdad.Text = "Edad";
            lblBuscador.Text = "Buscador";
            lblTelefono.Text = "Telefono";


            //button
        

            //textbox
            txtId.Enabled = false;//el  txtid lo ponemos como falso para que no se pueda modificar 


            btnModificar.BackgroundImage = Image.FromFile(@"C:\Users\Jose Medina\Desktop\FCECEP\POO\Visual Estudio\Trabajo Final\WFAProyectoFinal\IMGS\Modificar.png");
            btnsalir.BackgroundImage = Image.FromFile(@"C:\Users\Jose Medina\Desktop\FCECEP\POO\Visual Estudio\Trabajo Final\WFAProyectoFinal\IMGS\Salir.png");
            btnEliminar.BackgroundImage = Image.FromFile(@"C:\Users\Jose Medina\Desktop\FCECEP\POO\Visual Estudio\Trabajo Final\WFAProyectoFinal\IMGS\Eliminar.png");
            btnActualizar.BackgroundImage = Image.FromFile(@"C:\Users\Jose Medina\Desktop\FCECEP\POO\Visual Estudio\Trabajo Final\WFAProyectoFinal\IMGS\Actualizar.png");

            pctUsuarios.BackgroundImage = Image.FromFile(ruta + "frmUsuarios.png");
            pctUsuarios.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void mgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            DataGridViewRow fila = mgvUsuarios.CurrentRow;
            txtId.Text = Convert.ToString(fila.Cells[0].Value);
            txtNombre.Text = Convert.ToString(fila.Cells[1].Value);
            txtApellido.Text = Convert.ToString(fila.Cells[2].Value);//Cuando seleccionamos la fila dentro del datagridview se muestran en el txt en el orden que los puse 
            txtTelefono.Text = Convert.ToString(fila.Cells[3].Value);
            txtCorreo.Text = Convert.ToString(fila.Cells[4].Value);
            txtEdad.Text = Convert.ToString(fila.Cells[5].Value);

        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            select();//Llama el  metodo select, el cual carga la tabla que se encuentra en la base datos

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conn.Open();
          

            string identificacion = txtId.Text;
            string Nombres = txtNombre.Text;
            string apellidos = txtApellido.Text;//Le asigno variables a los txt para que queden almacenados
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            int edad = int.Parse(txtEdad.Text);

            Conexion C = new Conexion();//Creo una instancia y despues llamo al metodo consulta que se encuentra en la clase conexion 
            C.Consulta(identificacion, Nombres, apellidos, telefono, correo, edad);//llamado al metodo el cual contiene paremetros y se los asigno desde este formulario
            select();//llama al meotod select que se encuentra en este formulario para que la tabla se actaulice una vez modificado los registros
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string identificacion = txtId.Text;
         
            Conexion C = new Conexion();//Creo una instancia y despues llamo al metodo consulta que se encuentra en la clase conexion 
            C.Elimiminar(identificacion);
            select();
        }
       
        public void select()
        {
           
            DataSet datos = new DataSet();
            string query = "select *from usuarios;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);//Sirve para cuando queremos ejectura una sentencia de sql a la base de datos
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conn);//Sirve para guardara y recuperar la informacion, en este caso me ayuda a mostrar la informacion en el datagridview
            add.Fill(datos);
            mgvUsuarios.DataSource = datos.Tables[0];
            conn.Close();


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            select();
        }

        private void txtBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            string identificacion = txtBuscador.Text;
            if (e.KeyCode == Keys.Enter)
            {
                DataSet datos = new DataSet();
                string query = "select Buscar ('" + identificacion + "')";//Procedimiento almacenado que se encuentra en el motor de base de datosm, permite buscar el correo mediante la ide que ingresemos 
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conn);
                add.Fill(datos);
                mgvUsuarios.DataSource = datos.Tables[0];
                conn.Close();

            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


    
    
   
    