
namespace WFAProyectoFinal
{
    partial class frmDetalleFactura
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
            this.mtltComprar = new MetroFramework.Controls.MetroTile();
            this.mgvFactura = new MetroFramework.Controls.MetroGrid();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pctDFactura = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mgvFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // mtltComprar
            // 
            this.mtltComprar.ActiveControl = null;
            this.mtltComprar.Location = new System.Drawing.Point(344, 166);
            this.mtltComprar.Name = "mtltComprar";
            this.mtltComprar.Size = new System.Drawing.Size(108, 44);
            this.mtltComprar.TabIndex = 8;
            this.mtltComprar.Text = "Comprar";
            this.mtltComprar.UseSelectable = true;
            this.mtltComprar.Click += new System.EventHandler(this.mtltComprar_Click);
            // 
            // mgvFactura
            // 
            this.mgvFactura.AllowUserToAddRows = false;
            this.mgvFactura.AllowUserToDeleteRows = false;
            this.mgvFactura.AllowUserToOrderColumns = true;
            this.mgvFactura.AllowUserToResizeRows = false;
            this.mgvFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvFactura.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgvFactura.EnableHeadersVisualStyles = false;
            this.mgvFactura.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvFactura.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvFactura.Location = new System.Drawing.Point(154, 236);
            this.mgvFactura.Name = "mgvFactura";
            this.mgvFactura.ReadOnly = true;
            this.mgvFactura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgvFactura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvFactura.Size = new System.Drawing.Size(573, 164);
            this.mgvFactura.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(692, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(62, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // pctDFactura
            // 
            this.pctDFactura.Location = new System.Drawing.Point(188, 36);
            this.pctDFactura.Name = "pctDFactura";
            this.pctDFactura.Size = new System.Drawing.Size(434, 112);
            this.pctDFactura.TabIndex = 11;
            this.pctDFactura.TabStop = false;
            // 
            // frmDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctDFactura);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.mtltComprar);
            this.Controls.Add(this.mgvFactura);
            this.Name = "frmDetalleFactura";
            this.Text = "DetalleFactura";
            this.Load += new System.EventHandler(this.frmDetalleFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgvFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile mtltComprar;
        private MetroFramework.Controls.MetroGrid mgvFactura;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pctDFactura;
    }
}