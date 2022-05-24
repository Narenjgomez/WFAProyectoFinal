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
    public partial class progessbar : MetroFramework.Forms.MetroForm
    {
        private OpenFileDialog fd = new OpenFileDialog();
        public progessbar()
        {
            InitializeComponent();

            tmrProgessBar.Interval = 100;
            lblProgess.Text = "0" + "%";
            tmrProgessBar.Enabled = false;
        }

        private void tmrProgessBar_Tick(object sender, EventArgs e)
        {
            prgB1.Value++;
            lblProgess.Text = prgB1.Value + ("%");
            if (prgB1.Value == prgB1.Maximum)
            {
                tmrProgessBar.Enabled = false;
                MessageBox.Show("Has ingresado de forma correcta");
                frmPrincipal P = new frmPrincipal();
                P.ItmVentayAlquiler.Enabled = true;
                P.Show();
            }
        }
        public void CargarImagen1(PictureBox pictureBox)
        {

            pictureBox.WaitOnLoad = true;
            fd.Filter = "Imagenes |*.jpg;*.jpeg;*png;*";
            fd.ShowDialog();
            if (fd.FileName != string.Empty)
            {
                pictureBox.ImageLocation = fd.FileName;
            }
        }

       

        private void pctImagen_Click(object sender, EventArgs e)
        {
            CargarImagen1(pctImagen);
        }
    }
}
