namespace Vista
{
    partial class FrmEstadistica
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
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblVentasRealizadas = new System.Windows.Forms.Label();
            this.lstVentas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductoMasVendido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Location = new System.Drawing.Point(43, 56);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(104, 15);
            this.lblVentas.TabIndex = 0;
            this.lblVentas.Text = "Ventas Realziadas :";
            // 
            // lblVentasRealizadas
            // 
            this.lblVentasRealizadas.AutoSize = true;
            this.lblVentasRealizadas.Location = new System.Drawing.Point(166, 56);
            this.lblVentasRealizadas.Name = "lblVentasRealizadas";
            this.lblVentasRealizadas.Size = new System.Drawing.Size(38, 15);
            this.lblVentasRealizadas.TabIndex = 1;
            this.lblVentasRealizadas.Text = "label1";
            // 
            // lstVentas
            // 
            this.lstVentas.FormattingEnabled = true;
            this.lstVentas.ItemHeight = 15;
            this.lstVentas.Location = new System.Drawing.Point(53, 113);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(343, 169);
            this.lstVentas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // lblProductoMasVendido
            // 
            this.lblProductoMasVendido.AutoSize = true;
            this.lblProductoMasVendido.Location = new System.Drawing.Point(47, 75);
            this.lblProductoMasVendido.Name = "lblProductoMasVendido";
            this.lblProductoMasVendido.Size = new System.Drawing.Size(127, 15);
            this.lblProductoMasVendido.TabIndex = 4;
            this.lblProductoMasVendido.Text = "Producto mas vendido";
            // 
            // FrmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProductoMasVendido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstVentas);
            this.Controls.Add(this.lblVentasRealizadas);
            this.Controls.Add(this.lblVentas);
            this.Name = "FrmEstadistica";
            this.Text = "FrmEstadistica";
            this.Load += new System.EventHandler(this.FrmEstadistica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblVentasRealizadas;
        private System.Windows.Forms.ListBox lstVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductoMasVendido;
    }
}