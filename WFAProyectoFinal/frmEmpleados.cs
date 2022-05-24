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
    public partial class frmEmpleados : MetroFramework.Forms.MetroForm
    {
        string ruta = @"C:\Users\Jose Medina\Desktop\FCECEP\POO\Visual Estudio\Trabajo Final\WFAProyectoFinal\IMGS\";
        NpgsqlConnection conn = new NpgsqlConnection("server = localhost; Port = 5432; User Id=postgres; Password =medinagego16; Database = VentaAlquiler ");
        public frmEmpleados()
        {
            InitializeComponent();


            txtcodigo.Enabled = false;


            btnModificar.BackgroundImage = Image.FromFile(@"C:\Users\Jose Medina\Desktop\FCECEP\POO\Visual Estudio\Trabajo Final\WFAProyectoFinal\IMGS\Modificar.png");
            btnsalir.BackgroundImage = Image.FromFile(@"C:\Users\Jose Medina\Desktop\FCECEP\POO\Visual Estudio\Trabajo Final\WFAProyectoFinal\IMGS\Salir.png");
            btnEliminar.BackgroundImage = Image.FromFile(@"C:\Users\Jose Medina\Desktop\FCECEP\POO\Visual Estudio\Trabajo Final\WFAProyectoFinal\IMGS\Eliminar.png");
            btnActualizar.BackgroundImage = Image.FromFile(@"C:\Users\Jose Medina\Desktop\FCECEP\POO\Visual Estudio\Trabajo Final\WFAProyectoFinal\IMGS\Actualizar.png");

            pctEmpleados.BackgroundImage = Image.FromFile(ruta + "frmEmpleados.png");
            pctEmpleados.BackgroundImageLayout = ImageLayout.Stretch;
           
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            DataSet datos = new DataSet();
            string query = "select *from empleados;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conn);
            add.Fill(datos);
            mgvempleados.DataSource = datos.Tables[0];
            conn.Close();
        }

       
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string codigo= txtcodigo.Text;
            string Nombres = txtNombre.Text;
            string apellidos = txtApellido.Text;//Le asigno variables a los txt para que queden almacenados
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            string cargo = txtCargo.Text;

            Conexion C = new Conexion();//Creo una instancia y despues llamo al metodo consulta que se encuentra en la clase conexion 
            C.ConsultaEm(codigo,Nombres,apellidos,telefono,correo,cargo);//llamado al metodo el cual contiene paremetros y se los asigno desde este formulario
            select();//llama al meotod select que se encuentra en este formulario para que la tabla se actaulice una vez modificado los registros
        }

      
        private void mgvempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = mgvempleados.CurrentRow;
            txtcodigo.Text = Convert.ToString(fila.Cells[0].Value);
            txtNombre.Text = Convert.ToString(fila.Cells[1].Value);
            txtApellido.Text = Convert.ToString(fila.Cells[2].Value);//Cuando seleccionamos la fila dentro del datagridview se muestran en el txt en el orden que los puse 
            txtTelefono.Text = Convert.ToString(fila.Cells[3].Value);
            txtCorreo.Text = Convert.ToString(fila.Cells[5].Value);
            txtCargo.Text = Convert.ToString(fila.Cells[6].Value);
        }
        public void select()
        {

            DataSet datos = new DataSet();
            string query = "select *from empleados;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);//Me permite ver los datos que se encuentran en la base de datos en el datagridview
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conn);
            add.Fill(datos);
            mgvempleados.DataSource = datos.Tables[0];
            conn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtcodigo.Text;
           

            Conexion C = new Conexion();//Creo una instancia y despues llamo al metodo consulta que se encuentra en la clase conexion 
            C.EliminarEm(codigo);//llamado al metodo el cual contiene paremetros y se los asigno desde este formulario
            select();//llama al meotodd select que se encuentra en este formulario para que la tabla se actaulice una vez modificado los registros
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            select();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
