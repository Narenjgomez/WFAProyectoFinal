
namespace WFAProyectoFinal
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mgrpTitulo = new MetroFramework.Controls.MetroPanel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblIdentificacion = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ItmLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmLoginU = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmVentayAlquiler = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmAlquiler = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmNavegar = new System.Windows.Forms.ToolStripMenuItem();
            this.itmIncidencias = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.itmEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.mgrpTitulo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mgrpTitulo
            // 
            this.mgrpTitulo.BackColor = System.Drawing.Color.White;
            this.mgrpTitulo.Controls.Add(this.lblHora);
            this.mgrpTitulo.Controls.Add(this.lblFecha);
            this.mgrpTitulo.Controls.Add(this.lblIdentificacion);
            this.mgrpTitulo.Controls.Add(this.lblId);
            this.mgrpTitulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mgrpTitulo.HorizontalScrollbarBarColor = true;
            this.mgrpTitulo.HorizontalScrollbarHighlightOnWheel = false;
            this.mgrpTitulo.HorizontalScrollbarSize = 10;
            this.mgrpTitulo.Location = new System.Drawing.Point(20, 426);
            this.mgrpTitulo.Name = "mgrpTitulo";
            this.mgrpTitulo.Size = new System.Drawing.Size(776, 60);
            this.mgrpTitulo.TabIndex = 3;
            this.mgrpTitulo.VerticalScrollbarBarColor = true;
            this.mgrpTitulo.VerticalScrollbarHighlightOnWheel = false;
            this.mgrpTitulo.VerticalScrollbarSize = 10;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(685, 29);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(35, 13);
            this.lblHora.TabIndex = 10;
            this.lblHora.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(294, 29);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "label2";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(28, 23);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(88, 19);
            this.lblIdentificacion.TabIndex = 9;
            this.lblIdentificacion.Text = "Identificacion:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(125, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(81, 19);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "metroLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItmLogin,
            this.ItmVentayAlquiler,
            this.ItmConsultas});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ItmLogin
            // 
            this.ItmLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItmRegister,
            this.ItmLoginU});
            this.ItmLogin.Name = "ItmLogin";
            this.ItmLogin.Size = new System.Drawing.Size(125, 20);
            this.ItmLogin.Text = "toolStripMenuItem1";
            // 
            // ItmRegister
            // 
            this.ItmRegister.Name = "ItmRegister";
            this.ItmRegister.Size = new System.Drawing.Size(180, 22);
            this.ItmRegister.Text = "toolStripMenuItem1";
            this.ItmRegister.Click += new System.EventHandler(this.ItmRegister_Click);
            // 
            // ItmLoginU
            // 
            this.ItmLoginU.Name = "ItmLoginU";
            this.ItmLoginU.Size = new System.Drawing.Size(180, 22);
            this.ItmLoginU.Text = "Login";
            this.ItmLoginU.Click += new System.EventHandler(this.ItmLoginU_Click);
            // 
            // ItmVentayAlquiler
            // 
            this.ItmVentayAlquiler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItmVenta,
            this.ItmAlquiler,
            this.ItmCompra});
            this.ItmVentayAlquiler.Name = "ItmVentayAlquiler";
            this.ItmVentayAlquiler.Size = new System.Drawing.Size(125, 20);
            this.ItmVentayAlquiler.Text = "toolStripMenuItem1";
            this.ItmVentayAlquiler.Click += new System.EventHandler(this.ItmVentayAlquiler_Click);
            // 
            // ItmVenta
            // 
            this.ItmVenta.Name = "ItmVenta";
            this.ItmVenta.Size = new System.Drawing.Size(180, 22);
            this.ItmVenta.Text = "toolStripMenuItem1";
            this.ItmVenta.Click += new System.EventHandler(this.ItmVenta_Click);
            // 
            // ItmAlquiler
            // 
            this.ItmAlquiler.Name = "ItmAlquiler";
            this.ItmAlquiler.Size = new System.Drawing.Size(180, 22);
            this.ItmAlquiler.Text = "toolStripMenuItem2";
            this.ItmAlquiler.Click += new System.EventHandler(this.ItmAlquiler_Click);
            // 
            // ItmCompra
            // 
            this.ItmCompra.Name = "ItmCompra";
            this.ItmCompra.Size = new System.Drawing.Size(180, 22);
            this.ItmCompra.Text = "toolStripMenuItem1";
            this.ItmCompra.Click += new System.EventHandler(this.ItmCompra_Click);
            // 
            // ItmConsultas
            // 
            this.ItmConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItmUsuarios,
            this.ItmFactura,
            this.ItmNavegar,
            this.itmIncidencias,
            this.itmEmpleados});
            this.ItmConsultas.Name = "ItmConsultas";
            this.ItmConsultas.Size = new System.Drawing.Size(125, 20);
            this.ItmConsultas.Text = "toolStripMenuItem1";
            // 
            // ItmUsuarios
            // 
            this.ItmUsuarios.Name = "ItmUsuarios";
            this.ItmUsuarios.Size = new System.Drawing.Size(180, 22);
            this.ItmUsuarios.Text = "toolStripMenuItem2";
            this.ItmUsuarios.Click += new System.EventHandler(this.ItmFactura_Click);
            // 
            // ItmFactura
            // 
            this.ItmFactura.Name = "ItmFactura";
            this.ItmFactura.Size = new System.Drawing.Size(180, 22);
            this.ItmFactura.Text = "toolStripMenuItem1";
            this.ItmFactura.Click += new System.EventHandler(this.ItmFactura_Click_1);
            // 
            // ItmNavegar
            // 
            this.ItmNavegar.Name = "ItmNavegar";
            this.ItmNavegar.Size = new System.Drawing.Size(180, 22);
            this.ItmNavegar.Text = "toolStripMenuItem1";
            this.ItmNavegar.Click += new System.EventHandler(this.ItmNavegar_Click);
            // 
            // itmIncidencias
            // 
            this.itmIncidencias.Name = "itmIncidencias";
            this.itmIncidencias.Size = new System.Drawing.Size(180, 22);
            this.itmIncidencias.Text = "toolStripMenuItem1";
            this.itmIncidencias.Click += new System.EventHandler(this.itmIncidencias_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(593, 19);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // itmEmpleados
            // 
            this.itmEmpleados.Name = "itmEmpleados";
            this.itmEmpleados.Size = new System.Drawing.Size(180, 22);
            this.itmEmpleados.Text = "toolStripMenuItem1";
            this.itmEmpleados.Click += new System.EventHandler(this.itmEmpleados_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(816, 506);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.mgrpTitulo);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Venta y Alquiler";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mgrpTitulo.ResumeLayout(false);
            this.mgrpTitulo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel mgrpTitulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ItmLogin;
        private System.Windows.Forms.ToolStripMenuItem ItmRegister;
        private System.Windows.Forms.ToolStripMenuItem ItmLoginU;
        private System.Windows.Forms.ToolStripMenuItem ItmVenta;
        private System.Windows.Forms.ToolStripMenuItem ItmAlquiler;
        public System.Windows.Forms.ToolStripMenuItem ItmVentayAlquiler;
        public MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroLabel lblIdentificacion;
        private System.Windows.Forms.ToolStripMenuItem ItmUsuarios;
        private System.Windows.Forms.ToolStripMenuItem ItmFactura;
        private System.Windows.Forms.ToolStripMenuItem ItmNavegar;
        private System.Windows.Forms.ToolStripMenuItem itmIncidencias;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ToolStripMenuItem ItmCompra;
        public System.Windows.Forms.ToolStripMenuItem ItmConsultas;
        private System.Windows.Forms.ToolStripMenuItem itmEmpleados;
    }
}

