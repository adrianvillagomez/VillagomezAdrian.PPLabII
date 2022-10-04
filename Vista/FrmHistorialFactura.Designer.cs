namespace Vista
{
    partial class FrmHistorialFactura
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
            this.dtvHistorial = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvHistorial
            // 
            this.dtvHistorial.AllowUserToAddRows = false;
            this.dtvHistorial.AllowUserToDeleteRows = false;
            this.dtvHistorial.AllowUserToResizeColumns = false;
            this.dtvHistorial.AllowUserToResizeRows = false;
            this.dtvHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dtvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvHistorial.Location = new System.Drawing.Point(12, 30);
            this.dtvHistorial.Name = "dtvHistorial";
            this.dtvHistorial.ReadOnly = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            this.dtvHistorial.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvHistorial.RowTemplate.Height = 25;
            this.dtvHistorial.Size = new System.Drawing.Size(776, 408);
            this.dtvHistorial.TabIndex = 40;
            this.dtvHistorial.DoubleClick += new System.EventHandler(this.dtvHistorial_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(12, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Historial de Facturacion";
            // 
            // FrmHistorialFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtvHistorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHistorialFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.FrmHistorialFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvHistorial;
        private System.Windows.Forms.Label label6;
    }
}