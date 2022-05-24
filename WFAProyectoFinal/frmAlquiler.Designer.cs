
namespace WFAProyectoFinal
{
    partial class frmAlquiler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpGriev = new System.Windows.Forms.GroupBox();
            this.mdgvAlquiler = new MetroFramework.Controls.MetroGrid();
            this.mTltAgregar = new MetroFramework.Controls.MetroTile();
            this.MLblPlaca = new System.Windows.Forms.Label();
            this.MlblModelo = new System.Windows.Forms.Label();
            this.MlblPrecio = new System.Windows.Forms.Label();
            this.mlblColor = new System.Windows.Forms.Label();
            this.labMlblKilomentrosel5 = new System.Windows.Forms.Label();
            this.mtxtPlaca = new System.Windows.Forms.TextBox();
            this.mtxtModelo = new System.Windows.Forms.TextBox();
            this.mtxtPrecio = new System.Windows.Forms.TextBox();
            this.mtxtColor = new System.Windows.Forms.TextBox();
            this.mtxtKilometros = new System.Windows.Forms.TextBox();
            this.grpGriev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGriev
            // 
            this.grpGriev.Controls.Add(this.mdgvAlquiler);
            this.grpGriev.Location = new System.Drawing.Point(100, 402);
            this.grpGriev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpGriev.Name = "grpGriev";
            this.grpGriev.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpGriev.Size = new System.Drawing.Size(1000, 329);
            this.grpGriev.TabIndex = 14;
            this.grpGriev.TabStop = false;
            this.grpGriev.Text = "Datos ingresados";
            // 
            // mdgvAlquiler
            // 
            this.mdgvAlquiler.AllowUserToOrderColumns = true;
            this.mdgvAlquiler.AllowUserToResizeRows = false;
            this.mdgvAlquiler.BackgroundColor = System.Drawing.Color.White;
            this.mdgvAlquiler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvAlquiler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvAlquiler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvAlquiler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mdgvAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvAlquiler.DefaultCellStyle = dataGridViewCellStyle5;
            this.mdgvAlquiler.EnableHeadersVisualStyles = false;
            this.mdgvAlquiler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvAlquiler.GridColor = System.Drawing.Color.Black;
            this.mdgvAlquiler.Location = new System.Drawing.Point(92, 74);
            this.mdgvAlquiler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mdgvAlquiler.Name = "mdgvAlquiler";
            this.mdgvAlquiler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvAlquiler.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mdgvAlquiler.RowHeadersWidth = 62;
            this.mdgvAlquiler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvAlquiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvAlquiler.Size = new System.Drawing.Size(830, 209);
            this.mdgvAlquiler.TabIndex = 1;
            // 
            // mTltAgregar
            // 
            this.mTltAgregar.ActiveControl = null;
            this.mTltAgregar.Location = new System.Drawing.Point(100, 318);
            this.mTltAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mTltAgregar.Name = "mTltAgregar";
            this.mTltAgregar.Size = new System.Drawing.Size(122, 60);
            this.mTltAgregar.TabIndex = 13;
            this.mTltAgregar.Text = "metroTile1";
            this.mTltAgregar.UseSelectable = true;
            // 
            // MLblPlaca
            // 
            this.MLblPlaca.AutoSize = true;
            this.MLblPlaca.Location = new System.Drawing.Point(96, 146);
            this.MLblPlaca.Name = "MLblPlaca";
            this.MLblPlaca.Size = new System.Drawing.Size(48, 20);
            this.MLblPlaca.TabIndex = 25;
            this.MLblPlaca.Text = "Placa";
            this.MLblPlaca.Click += new System.EventHandler(this.label1_Click);
            // 
            // MlblModelo
            // 
            this.MlblModelo.AutoSize = true;
            this.MlblModelo.Location = new System.Drawing.Point(96, 224);
            this.MlblModelo.Name = "MlblModelo";
            this.MlblModelo.Size = new System.Drawing.Size(61, 20);
            this.MlblModelo.TabIndex = 26;
            this.MlblModelo.Text = "Modelo";
            // 
            // MlblPrecio
            // 
            this.MlblPrecio.AutoSize = true;
            this.MlblPrecio.Location = new System.Drawing.Point(377, 146);
            this.MlblPrecio.Name = "MlblPrecio";
            this.MlblPrecio.Size = new System.Drawing.Size(53, 20);
            this.MlblPrecio.TabIndex = 27;
            this.MlblPrecio.Text = "Precio";
            // 
            // mlblColor
            // 
            this.mlblColor.AutoSize = true;
            this.mlblColor.Location = new System.Drawing.Point(377, 230);
            this.mlblColor.Name = "mlblColor";
            this.mlblColor.Size = new System.Drawing.Size(46, 20);
            this.mlblColor.TabIndex = 28;
            this.mlblColor.Text = "Color";
            // 
            // labMlblKilomentrosel5
            // 
            this.labMlblKilomentrosel5.AutoSize = true;
            this.labMlblKilomentrosel5.Location = new System.Drawing.Point(618, 146);
            this.labMlblKilomentrosel5.Name = "labMlblKilomentrosel5";
            this.labMlblKilomentrosel5.Size = new System.Drawing.Size(32, 20);
            this.labMlblKilomentrosel5.TabIndex = 29;
            this.labMlblKilomentrosel5.Text = "KM";
            // 
            // mtxtPlaca
            // 
            this.mtxtPlaca.Location = new System.Drawing.Point(192, 143);
            this.mtxtPlaca.Name = "mtxtPlaca";
            this.mtxtPlaca.Size = new System.Drawing.Size(100, 26);
            this.mtxtPlaca.TabIndex = 30;
            this.mtxtPlaca.Enter += new System.EventHandler(this.mtxtPlaca_Enter);
            this.mtxtPlaca.Leave += new System.EventHandler(this.mtxtPlaca_Leave);
            // 
            // mtxtModelo
            // 
            this.mtxtModelo.Location = new System.Drawing.Point(192, 221);
            this.mtxtModelo.Name = "mtxtModelo";
            this.mtxtModelo.Size = new System.Drawing.Size(100, 26);
            this.mtxtModelo.TabIndex = 31;
            // 
            // mtxtPrecio
            // 
            this.mtxtPrecio.Location = new System.Drawing.Point(460, 146);
            this.mtxtPrecio.Name = "mtxtPrecio";
            this.mtxtPrecio.Size = new System.Drawing.Size(100, 26);
            this.mtxtPrecio.TabIndex = 32;
            // 
            // mtxtColor
            // 
            this.mtxtColor.Location = new System.Drawing.Point(460, 227);
            this.mtxtColor.Name = "mtxtColor";
            this.mtxtColor.Size = new System.Drawing.Size(100, 26);
            this.mtxtColor.TabIndex = 33;
            // 
            // mtxtKilometros
            // 
            this.mtxtKilometros.Location = new System.Drawing.Point(668, 146);
            this.mtxtKilometros.Name = "mtxtKilometros";
            this.mtxtKilometros.Size = new System.Drawing.Size(100, 26);
            this.mtxtKilometros.TabIndex = 34;
            // 
            // frmAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 777);
            this.Controls.Add(this.mtxtKilometros);
            this.Controls.Add(this.mtxtColor);
            this.Controls.Add(this.mtxtPrecio);
            this.Controls.Add(this.mtxtModelo);
            this.Controls.Add(this.mtxtPlaca);
            this.Controls.Add(this.labMlblKilomentrosel5);
            this.Controls.Add(this.mlblColor);
            this.Controls.Add(this.MlblPrecio);
            this.Controls.Add(this.MlblModelo);
            this.Controls.Add(this.MLblPlaca);
            this.Controls.Add(this.grpGriev);
            this.Controls.Add(this.mTltAgregar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAlquiler";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Text = "Alquiler";
            this.grpGriev.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mdgvAlquiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpGriev;
        private MetroFramework.Controls.MetroGrid mdgvAlquiler;
        private MetroFramework.Controls.MetroTile mTltAgregar;
        private System.Windows.Forms.Label MLblPlaca;
        private System.Windows.Forms.Label MlblModelo;
        private System.Windows.Forms.Label MlblPrecio;
        private System.Windows.Forms.Label mlblColor;
        private System.Windows.Forms.Label labMlblKilomentrosel5;
        private System.Windows.Forms.TextBox mtxtPlaca;
        private System.Windows.Forms.TextBox mtxtModelo;
        private System.Windows.Forms.TextBox mtxtPrecio;
        private System.Windows.Forms.TextBox mtxtColor;
        private System.Windows.Forms.TextBox mtxtKilometros;
    }
}