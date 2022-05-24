
namespace WFAProyectoFinal
{
    partial class frmVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mdgvVenta = new MetroFramework.Controls.MetroGrid();
            this.grpGriev = new System.Windows.Forms.GroupBox();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.mgvClientes = new MetroFramework.Controls.MetroGrid();
            this.mtxtPrecio = new System.Windows.Forms.TextBox();
            this.MlblPrecio = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.MLblPlaca = new System.Windows.Forms.Label();
            this.mTltAgregar = new MetroFramework.Controls.MetroTile();
            this.lblIdV = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.mtxtPlaca = new System.Windows.Forms.TextBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvVenta)).BeginInit();
            this.grpGriev.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // mdgvVenta
            // 
            this.mdgvVenta.AllowUserToAddRows = false;
            this.mdgvVenta.AllowUserToDeleteRows = false;
            this.mdgvVenta.AllowUserToOrderColumns = true;
            this.mdgvVenta.AllowUserToResizeRows = false;
            this.mdgvVenta.BackgroundColor = System.Drawing.Color.White;
            this.mdgvVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mdgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.mdgvVenta.EnableHeadersVisualStyles = false;
            this.mdgvVenta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvVenta.GridColor = System.Drawing.Color.Black;
            this.mdgvVenta.Location = new System.Drawing.Point(61, 49);
            this.mdgvVenta.Name = "mdgvVenta";
            this.mdgvVenta.ReadOnly = true;
            this.mdgvVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mdgvVenta.RowHeadersWidth = 62;
            this.mdgvVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvVenta.Size = new System.Drawing.Size(546, 143);
            this.mdgvVenta.TabIndex = 1;
            this.mdgvVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mdgvVenta_CellContentClick);
            // 
            // grpGriev
            // 
            this.grpGriev.Controls.Add(this.mdgvVenta);
            this.grpGriev.Location = new System.Drawing.Point(83, 246);
            this.grpGriev.Name = "grpGriev";
            this.grpGriev.Size = new System.Drawing.Size(667, 214);
            this.grpGriev.TabIndex = 2;
            this.grpGriev.TabStop = false;
            this.grpGriev.Text = "Datos ingresados";
            // 
            // pnlCliente
            // 
            this.pnlCliente.BackColor = System.Drawing.Color.Transparent;
            this.pnlCliente.Controls.Add(this.button1);
            this.pnlCliente.Controls.Add(this.mgvClientes);
            this.pnlCliente.Location = new System.Drawing.Point(57, 272);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(755, 188);
            this.pnlCliente.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mgvClientes
            // 
            this.mgvClientes.AllowUserToAddRows = false;
            this.mgvClientes.AllowUserToDeleteRows = false;
            this.mgvClientes.AllowUserToOrderColumns = true;
            this.mgvClientes.AllowUserToResizeRows = false;
            this.mgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.mgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvClientes.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgvClientes.EnableHeadersVisualStyles = false;
            this.mgvClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvClientes.GridColor = System.Drawing.Color.Black;
            this.mgvClientes.Location = new System.Drawing.Point(53, 32);
            this.mgvClientes.Name = "mgvClientes";
            this.mgvClientes.ReadOnly = true;
            this.mgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgvClientes.RowHeadersWidth = 62;
            this.mgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvClientes.Size = new System.Drawing.Size(653, 134);
            this.mgvClientes.TabIndex = 2;
            this.mgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgvClientes_CellContentClick);
            // 
            // mtxtPrecio
            // 
            this.mtxtPrecio.Location = new System.Drawing.Point(458, 85);
            this.mtxtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtPrecio.Name = "mtxtPrecio";
            this.mtxtPrecio.Size = new System.Drawing.Size(68, 20);
            this.mtxtPrecio.TabIndex = 42;
            // 
            // MlblPrecio
            // 
            this.MlblPrecio.AutoSize = true;
            this.MlblPrecio.Location = new System.Drawing.Point(408, 86);
            this.MlblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MlblPrecio.Name = "MlblPrecio";
            this.MlblPrecio.Size = new System.Drawing.Size(37, 13);
            this.MlblPrecio.TabIndex = 37;
            this.MlblPrecio.Text = "Precio";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(254, 131);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(68, 20);
            this.txtId.TabIndex = 45;
            // 
            // MLblPlaca
            // 
            this.MLblPlaca.AutoSize = true;
            this.MLblPlaca.Location = new System.Drawing.Point(190, 88);
            this.MLblPlaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MLblPlaca.Name = "MLblPlaca";
            this.MLblPlaca.Size = new System.Drawing.Size(34, 13);
            this.MLblPlaca.TabIndex = 35;
            this.MLblPlaca.Text = "Placa";
            // 
            // mTltAgregar
            // 
            this.mTltAgregar.ActiveControl = null;
            this.mTltAgregar.Location = new System.Drawing.Point(347, 190);
            this.mTltAgregar.Name = "mTltAgregar";
            this.mTltAgregar.Size = new System.Drawing.Size(81, 39);
            this.mTltAgregar.TabIndex = 0;
            this.mTltAgregar.Text = "metroTile1";
            this.mTltAgregar.UseSelectable = true;
            this.mTltAgregar.Click += new System.EventHandler(this.mTltAgregar_Click);
            // 
            // lblIdV
            // 
            this.lblIdV.AutoSize = true;
            this.lblIdV.Location = new System.Drawing.Point(224, 134);
            this.lblIdV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdV.Name = "lblIdV";
            this.lblIdV.Size = new System.Drawing.Size(16, 13);
            this.lblIdV.TabIndex = 46;
            this.lblIdV.Text = "Id";
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(652, 87);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCliente.TabIndex = 16;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // mtxtPlaca
            // 
            this.mtxtPlaca.Location = new System.Drawing.Point(254, 86);
            this.mtxtPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtPlaca.Name = "mtxtPlaca";
            this.mtxtPlaca.Size = new System.Drawing.Size(68, 20);
            this.mtxtPlaca.TabIndex = 40;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(384, 134);
            this.lblIdentificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(70, 13);
            this.lblIdentificacion.TabIndex = 48;
            this.lblIdentificacion.Text = "Identificacion";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(458, 131);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(68, 20);
            this.txtIdentificacion.TabIndex = 47;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(652, 131);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 49;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 596);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.mtxtPlaca);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.lblIdV);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.mTltAgregar);
            this.Controls.Add(this.grpGriev);
            this.Controls.Add(this.MLblPlaca);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.mtxtPrecio);
            this.Controls.Add(this.MlblPrecio);
            this.Name = "frmVenta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mdgvVenta)).EndInit();
            this.grpGriev.ResumeLayout(false);
            this.pnlCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid mdgvVenta;
        private System.Windows.Forms.GroupBox grpGriev;
        private System.Windows.Forms.Panel pnlCliente;
        private MetroFramework.Controls.MetroGrid mgvClientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mtxtPrecio;
        private System.Windows.Forms.Label MlblPrecio;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label MLblPlaca;
        private MetroFramework.Controls.MetroTile mTltAgregar;
        private System.Windows.Forms.Label lblIdV;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TextBox mtxtPlaca;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Button btnSalir;
    }
}