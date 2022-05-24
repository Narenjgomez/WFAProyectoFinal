
namespace WFAProyectoFinal
{
    partial class progessbar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.prgB1 = new MetroFramework.Controls.MetroProgressBar();
            this.tmrProgessBar = new System.Windows.Forms.Timer(this.components);
            this.lblProgess = new MetroFramework.Controls.MetroLabel();
            this.pctImagen = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // prgB1
            // 
            this.prgB1.Location = new System.Drawing.Point(199, 319);
            this.prgB1.Name = "prgB1";
            this.prgB1.Size = new System.Drawing.Size(343, 23);
            this.prgB1.TabIndex = 0;
            // 
            // tmrProgessBar
            // 
            this.tmrProgessBar.Tick += new System.EventHandler(this.tmrProgessBar_Tick);
            // 
            // lblProgess
            // 
            this.lblProgess.AutoSize = true;
            this.lblProgess.Location = new System.Drawing.Point(323, 286);
            this.lblProgess.Name = "lblProgess";
            this.lblProgess.Size = new System.Drawing.Size(81, 19);
            this.lblProgess.TabIndex = 1;
            this.lblProgess.Text = "metroLabel1";
            // 
            // pctImagen
            // 
            this.pctImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pctImagen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pctImagen.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pctImagen.IconColor = System.Drawing.SystemColors.ControlText;
            this.pctImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pctImagen.IconSize = 150;
            this.pctImagen.Location = new System.Drawing.Point(295, 87);
            this.pctImagen.Name = "pctImagen";
            this.pctImagen.Size = new System.Drawing.Size(150, 169);
            this.pctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImagen.TabIndex = 2;
            this.pctImagen.TabStop = false;
            this.pctImagen.Click += new System.EventHandler(this.pctImagen_Click);
            // 
            // progessbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctImagen);
            this.Controls.Add(this.lblProgess);
            this.Controls.Add(this.prgB1);
            this.Name = "progessbar";
            this.Text = "progessbar";
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar prgB1;
        private System.Windows.Forms.Timer tmrProgessBar;
        private MetroFramework.Controls.MetroLabel lblProgess;
        private FontAwesome.Sharp.IconPictureBox pctImagen;
    }
}