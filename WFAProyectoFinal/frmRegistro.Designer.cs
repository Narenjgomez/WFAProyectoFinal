
namespace WFAProyectoFinal
{
    partial class frmRegistro
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.cboEdad = new MetroFramework.Controls.MetroComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(451, 105);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 33);
            this.btnsalir.TabIndex = 42;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(333, 105);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(75, 33);
            this.btnRegistro.TabIndex = 40;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // cboEdad
            // 
            this.cboEdad.FormattingEnabled = true;
            this.cboEdad.ItemHeight = 23;
            this.cboEdad.Location = new System.Drawing.Point(539, 279);
            this.cboEdad.Name = "cboEdad";
            this.cboEdad.Size = new System.Drawing.Size(107, 29);
            this.cboEdad.TabIndex = 49;
            this.cboEdad.UseSelectable = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(124, 195);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(70, 13);
            this.lblId.TabIndex = 56;
            this.lblId.Text = "Identificacion";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(124, 236);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 57;
            this.lblNombres.Text = "Nombres";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(124, 279);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(49, 13);
            this.lblApellido.TabIndex = 58;
            this.lblApellido.Text = "Apellidos";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(258, 193);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(151, 20);
            this.txtId.TabIndex = 59;
            this.txtId.Enter += new System.EventHandler(this.txtId_Enter);
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            this.txtId.Leave += new System.EventHandler(this.txtId_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(258, 232);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 20);
            this.txtNombre.TabIndex = 60;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(258, 279);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(151, 20);
            this.txtApellido.TabIndex = 61;
            this.txtApellido.Enter += new System.EventHandler(this.txtApellido_Enter);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(539, 191);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(151, 20);
            this.txtTelefono.TabIndex = 62;
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(539, 234);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(151, 20);
            this.txtCorreo.TabIndex = 63;
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(439, 193);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 64;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(439, 238);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 65;
            this.lblCorreo.Text = "Correo";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(439, 281);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 66;
            this.lblEdad.Text = "Edad";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 448);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cboEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblNombres);
            this.Name = "frmRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnRegistro;
        private MetroFramework.Controls.MetroComboBox cboEdad;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblEdad;
        public System.Windows.Forms.TextBox txtId;
    }
}