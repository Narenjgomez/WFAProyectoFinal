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
using CrystalDecisions;


namespace WFAProyectoFinal
    
{
    public partial class Crystal : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("server = localhost; Port = 5432; User Id=postgres; Password =medinagego16; Database = VentaAlquiler ");
        public Crystal()
        {

          
            InitializeComponent();



            //string query = "select * from factura;";
            //NpgsqlCommand conectorr = new NpgsqlCommand(query, conn);
            //NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conn);
            //add.Fill(datos);
            //crystal.SetDataSource(datos.Tables[0]);
            //crystal.Refresh();
          




        }
    }
}
