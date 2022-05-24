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
    public class Conexion
    {
        public NpgsqlConnection conn = new NpgsqlConnection("server = localhost; Port = 5432; User Id=postgres; Password =medinagego16; Database = VentaAlquiler ");

        public void Registro(string id, string nombre, string apellido, string telefono, string correo, int edad)
        {
            conn.Open();
            try
            {


                //string Nombres = txtNombre.Text;
                NpgsqlCommand conector = new NpgsqlCommand("insert into usuarios values ('" + id + "','" + nombre + "','" + apellido + "'," +
                    "'" + telefono + "','" + correo + "','" + edad + "');", conn);
                conector.ExecuteNonQuery();
                MessageBox.Show("Registro realizado de forma correcta recuerde que su numero de identificacion es: " + id + " y su correo: " + correo);
                conn.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Error es " + error.Message);
                throw;
            }

        }

        public void Consulta(string id, string nombre, string apellido, string telefono, string correo, int edad)
        {

            conn.Open();




            string query = "update usuarios SET identificacion = '" + id + "', nombres ='" + nombre + "', apellidos = '" + apellido + "',telefono = '" + telefono + "',correo= '" + correo + "', edad = '" + edad + "' where identificacion='" + id + "';";
            try
            {
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                conector.ExecuteNonQuery();

                MessageBox.Show("Los datos han sido modificados de forma exitosa!!");


            }
            catch (NpgsqlException M)
            {
                MessageBox.Show("Error" + M.Message);
                throw;
            }

            conn.Close();


        }

        public void Elimiminar(string id)
        {
            try
            {
                conn.Open();
                NpgsqlCommand conector = new NpgsqlCommand("delete from usuarios where identificacion = '" + id + "'", conn);
                conector.ExecuteNonQuery();
                NpgsqlCommand eliminar = new NpgsqlCommand("delete from factura where identificacion = '" + id + "'", conn);
                eliminar.ExecuteNonQuery();

                MessageBox.Show("Los datos han sido eliminados de forma exitosa!!");


            }
            catch (NpgsqlException M)
            {
                MessageBox.Show("Error" + M.Message);
                throw;
            }

            conn.Close();


        }
        public void EliminarEm(string codigo)
        {
            try
            {
                conn.Open();
                NpgsqlCommand conector = new NpgsqlCommand("delete from empleados where codempleado = '" + codigo + "'", conn);
                conector.ExecuteNonQuery();


                MessageBox.Show("Los datos han sido eliminados de forma exitosa!!");


            }
            catch (NpgsqlException M)
            {
                MessageBox.Show("Error" + M.Message);
                throw;
            }

            conn.Close();
        }

        public void ConsultaEm(string codigo, string nombre, string apellido, string telefono, string correo, string cargo)
        {

            conn.Open();




            string query = "update empleados SET codempleado = '" + codigo + "', nombre ='" + nombre + "', apellido = '" + apellido + "',telefono = '" + telefono + "',correo= '" + correo + "', cargo = '" + cargo + "' where codempleado='" + codigo + "';";
            try
            {
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                conector.ExecuteNonQuery();

                MessageBox.Show("Los datos han sido modificados de forma exitosa!!");


            }
            catch (NpgsqlException M)
            {
                MessageBox.Show("Error" + M.Message);
                throw;
            }

            conn.Close();


        }
    }
}
   
   

