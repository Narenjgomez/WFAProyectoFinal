
namespace WFAProyectoFinal
{
    partial class frmVehiculo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mgvVehiculos = new MetroFramework.Controls.MetroGrid();
            this.btnCompra = new System.Windows.Forms.Button();
            this.lblEdad = new System.Windows.Forms.Label();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtKilometros = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblKilometros = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPrecioC = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtPrecioA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mgvClientes = new MetroFramework.Controls.MetroGrid();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.btnVendedor = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mgvVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgvClientes)).BeginInit();
            this.pnlCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // mgvVehiculos
            // 
            this.mgvVehiculos.AllowUserToAddRows = false;
            this.mgvVehiculos.AllowUserToDeleteRows = false;
            this.mgvVehiculos.AllowUserToOrderColumns = true;
            this.mgvVehiculos.AllowUserToResizeRows = false;
            this.mgvVehiculos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvVehiculos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvVehiculos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.mgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvVehiculos.DefaultCellStyle = dataGridViewCellStyle8;
            this.mgvVehiculos.EnableHeadersVisualStyles = false;
            this.mgvVehiculos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvVehiculos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvVehiculos.Location = new System.Drawing.Point(85, 292);
            this.mgvVehiculos.Name = "mgvVehiculos";
            this.mgvVehiculos.ReadOnly = true;
            this.mgvVehiculos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvVehiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.mgvVehiculos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvVehiculos.Size = new System.Drawing.Size(774, 172);
            this.mgvVehiculos.TabIndex = 0;
            this.mgvVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgvVehiculos_CellContentClick);
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(357, 220);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(75, 33);
            this.btnCompra.TabIndex = 67;
            this.btnCompra.Text = "Comprar";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(442, 158);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(74, 13);
            this.lblEdad.TabIndex = 80;
            this.lblEdad.Text = "Precio Alquiler";
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.Location = new System.Drawing.Point(477, 220);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(75, 33);
            this.btnAlquilar.TabIndex = 68;
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.UseVisualStyleBackColor = true;
            this.btnAlquilar.Click += new System.EventHandler(this.btnAlquilar_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(261, 109);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(151, 20);
            this.txtColor.TabIndex = 74;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(442, 115);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(76, 13);
            this.lblCorreo.TabIndex = 79;
            this.lblCorreo.Text = "Precio Compra";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(261, 70);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(151, 20);
            this.txtPlaca.TabIndex = 73;
            // 
            // txtKilometros
            // 
            this.txtKilometros.Location = new System.Drawing.Point(261, 156);
            this.txtKilometros.Margin = new System.Windows.Forms.Padding(2);
            this.txtKilometros.Name = "txtKilometros";
            this.txtKilometros.Size = new System.Drawing.Size(151, 20);
            this.txtKilometros.TabIndex = 75;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(474, 71);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(42, 13);
            this.lblTelefono.TabIndex = 78;
            this.lblTelefono.Text = "Modelo";
            // 
            // lblKilometros
            // 
            this.lblKilometros.AutoSize = true;
            this.lblKilometros.Location = new System.Drawing.Point(127, 156);
            this.lblKilometros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKilometros.Name = "lblKilometros";
            this.lblKilometros.Size = new System.Drawing.Size(55, 13);
            this.lblKilometros.TabIndex = 72;
            this.lblKilometros.Text = "Kilometros";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(127, 72);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 13);
            this.lblId.TabIndex = 70;
            this.lblId.Text = "Placa";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(542, 68);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(151, 20);
            this.txtModelo.TabIndex = 76;
            // 
            // txtPrecioC
            // 
            this.txtPrecioC.Location = new System.Drawing.Point(542, 111);
            this.txtPrecioC.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioC.Name = "txtPrecioC";
            this.txtPrecioC.Size = new System.Drawing.Size(151, 20);
            this.txtPrecioC.TabIndex = 77;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(127, 113);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(31, 13);
            this.lblNombres.TabIndex = 71;
            this.lblNombres.Text = "Color";
            // 
            // txtPrecioA
            // 
            this.txtPrecioA.Location = new System.Drawing.Point(542, 155);
            this.txtPrecioA.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioA.Name = "txtPrecioA";
            this.txtPrecioA.Size = new System.Drawing.Size(151, 20);
            this.txtPrecioA.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Identificacion";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(136, 251);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(151, 20);
            this.txtId.TabIndex = 82;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(760, 54);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCliente.TabIndex = 84;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.mgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvClientes.DefaultCellStyle = dataGridViewCellStyle11;
            this.mgvClientes.EnableHeadersVisualStyles = false;
            this.mgvClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvClientes.GridColor = System.Drawing.Color.Black;
            this.mgvClientes.Location = new System.Drawing.Point(53, 32);
            this.mgvClientes.Name = "mgvClientes";
            this.mgvClientes.ReadOnly = true;
            this.mgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.mgvClientes.RowHeadersWidth = 62;
            this.mgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvClientes.Size = new System.Drawing.Size(653, 134);
            this.mgvClientes.TabIndex = 2;
            this.mgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgvClientes_CellContentClick);
            // 
            // pnlCliente
            // 
            this.pnlCliente.BackColor = System.Drawing.Color.Transparent;
            this.pnlCliente.Controls.Add(this.button1);
            this.pnlCliente.Controls.Add(this.mgvClientes);
            this.pnlCliente.Location = new System.Drawing.Point(104, 292);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(755, 188);
            this.pnlCliente.TabIndex = 85;
            // 
            // btnVendedor
            // 
            this.btnVendedor.Location = new System.Drawing.Point(760, 103);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(75, 23);
            this.btnVendedor.TabIndex = 86;
            this.btnVendedor.Text = "Vendedor";
            this.btnVendedor.UseVisualStyleBackColor = true;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(760, 158);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 87;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 522);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVendedor);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPrecioA);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.btnAlquilar);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtKilometros);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblKilometros);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtPrecioC);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.mgvVehiculos);
            this.Name = "frmVehiculo";
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.frmVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgvVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgvClientes)).EndInit();
            this.pnlCliente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mgvVehiculos;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Button btnAlquilar;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblCorreo;
        public System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtKilometros;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblKilometros;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPrecioC;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtPrecioA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroGrid mgvClientes;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Button btnVendedor;
        private System.Windows.Forms.Button btnSalir;
    }
}