using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAProyectoFinal
{
    public partial class frmAlquiler : MetroFramework.Forms.MetroForm
    {
        public frmAlquiler()
        {
            InitializeComponent();
            mTltAgregar.Text = "Agregar";

            mdgvAlquiler.ColumnCount = 5;
            mdgvAlquiler.Columns[0].Name = "Placa";
            mdgvAlquiler.Columns[1].Name = "Color";
            mdgvAlquiler.Columns[2].Name = "Kilometros";
            mdgvAlquiler.Columns[3].Name = "Modelo";
            mdgvAlquiler.Columns[4].Name = "Precio";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mtxtPlaca_Enter(object sender, EventArgs e)
        {

        }

        private void mtxtPlaca_Leave(object sender, EventArgs e)
        {

        }
    }
}
