
namespace WFAProyectoFinal
{
    partial class frmEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.mgvempleados = new MetroFramework.Controls.MetroGrid();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pctEmpleados = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mgvempleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(520, 225);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(42, 42);
            this.btnsalir.TabIndex = 90;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(483, 152);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(151, 20);
            this.txtCargo.TabIndex = 105;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(483, 105);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(151, 20);
            this.txtCorreo.TabIndex = 104;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(483, 66);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(151, 20);
            this.txtTelefono.TabIndex = 103;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(432, 156);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 102;
            this.lblCargo.Text = "Cargo";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(428, 109);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 101;
            this.lblCorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(428, 70);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 100;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(202, 154);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(151, 20);
            this.txtApellido.TabIndex = 99;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(202, 105);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 20);
            this.txtNombre.TabIndex = 98;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(202, 66);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(151, 20);
            this.txtcodigo.TabIndex = 97;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(106, 156);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(49, 13);
            this.lblApellido.TabIndex = 96;
            this.lblApellido.Text = "Apellidos";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(106, 111);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 95;
            this.lblNombres.Text = "Nombres";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(115, 70);
            this.lblCod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 94;
            this.lblCod.Text = "Codigo";
            // 
            // mgvempleados
            // 
            this.mgvempleados.AllowUserToAddRows = false;
            this.mgvempleados.AllowUserToDeleteRows = false;
            this.mgvempleados.AllowUserToOrderColumns = true;
            this.mgvempleados.AllowUserToResizeRows = false;
            this.mgvempleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvempleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvempleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvempleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvempleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgvempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvempleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgvempleados.EnableHeadersVisualStyles = false;
            this.mgvempleados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvempleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvempleados.Location = new System.Drawing.Point(43, 312);
            this.mgvempleados.Name = "mgvempleados";
            this.mgvempleados.ReadOnly = true;
            this.mgvempleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvempleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgvempleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvempleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvempleados.Size = new System.Drawing.Size(784, 163);
            this.mgvempleados.TabIndex = 106;
            this.mgvempleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgvempleados_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(322, 225);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(42, 42);
            this.btnEliminar.TabIndex = 91;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(233, 225);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(42, 42);
            this.btnModificar.TabIndex = 92;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(421, 225);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(42, 42);
            this.btnActualizar.TabIndex = 93;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pctEmpleados
            // 
            this.pctEmpleados.Location = new System.Drawing.Point(754, 53);
            this.pctEmpleados.Name = "pctEmpleados";
            this.pctEmpleados.Size = new System.Drawing.Size(139, 152);
            this.pctEmpleados.TabIndex = 107;
            this.pctEmpleados.TabStop = false;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 503);
            this.Controls.Add(this.pctEmpleados);
            this.Controls.Add(this.mgvempleados);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnsalir);
            this.Name = "frmEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgvempleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblCod;
        private MetroFramework.Controls.MetroGrid mgvempleados;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.PictureBox pctEmpleados;
    }
}