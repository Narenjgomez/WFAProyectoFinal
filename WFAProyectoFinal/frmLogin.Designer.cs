
namespace WFAProyectoFinal
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblProgess = new MetroFramework.Controls.MetroLabel();
            this.prgB1 = new MetroFramework.Controls.MetroProgressBar();
            this.tmrProgessbar = new System.Windows.Forms.Timer(this.components);
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.pctCarga = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(160, 417);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(53, 42);
            this.btnLogin.TabIndex = 60;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(290, 417);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 42);
            this.btnSalir.TabIndex = 61;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblProgess
            // 
            this.lblProgess.AutoSize = true;
            this.lblProgess.Location = new System.Drawing.Point(211, 504);
            this.lblProgess.Name = "lblProgess";
            this.lblProgess.Size = new System.Drawing.Size(81, 19);
            this.lblProgess.TabIndex = 63;
            this.lblProgess.Text = "metroLabel1";
            // 
            // prgB1
            // 
            this.prgB1.Location = new System.Drawing.Point(87, 537);
            this.prgB1.Name = "prgB1";
            this.prgB1.Size = new System.Drawing.Size(343, 23);
            this.prgB1.TabIndex = 62;
            // 
            // tmrProgessbar
            // 
            this.tmrProgessbar.Enabled = true;
            this.tmrProgessbar.Tick += new System.EventHandler(this.tmrProgessbar_Tick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(197, 291);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(151, 20);
            this.txtId.TabIndex = 64;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(197, 344);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(151, 20);
            this.txtCorreo.TabIndex = 65;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(105, 295);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(70, 13);
            this.lblId.TabIndex = 66;
            this.lblId.Text = "Identificacion";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(105, 348);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 67;
            this.lblCorreo.Text = "Correo";
            // 
            // pctCarga
            // 
            this.pctCarga.Location = new System.Drawing.Point(188, 63);
            this.pctCarga.Name = "pctCarga";
            this.pctCarga.Size = new System.Drawing.Size(170, 189);
            this.pctCarga.TabIndex = 68;
            this.pctCarga.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 632);
            this.Controls.Add(this.pctCarga);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblProgess);
            this.Controls.Add(this.prgB1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pctCarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSalir;
        private MetroFramework.Controls.MetroLabel lblProgess;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCorreo;
        public System.Windows.Forms.TextBox txtId;
        public MetroFramework.Controls.MetroProgressBar prgB1;
        public System.Windows.Forms.Timer tmrProgessbar;
        private System.Windows.Forms.PictureBox pctCarga;
    }
}