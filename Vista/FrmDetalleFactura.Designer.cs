namespace Vista
{
    partial class FrmDetalleFactura
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
            this.BarraDeTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDoc = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblCodigoFactura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BarraDeTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraDeTitulo
            // 
            this.BarraDeTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.BarraDeTitulo.Controls.Add(this.label6);
            this.BarraDeTitulo.Controls.Add(this.pictureBox1);
            this.BarraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraDeTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraDeTitulo.Name = "BarraDeTitulo";
            this.BarraDeTitulo.Size = new System.Drawing.Size(463, 50);
            this.BarraDeTitulo.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Vista.Properties.Resources.emblemunreadable_93487;
            this.pictureBox1.Location = new System.Drawing.Point(422, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(147, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "Detalle de Facturacion";
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Location = new System.Drawing.Point(171, 202);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(38, 15);
            this.lblDoc.TabIndex = 22;
            this.lblDoc.Text = "label7";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(145, 164);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(38, 15);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Documento Cliente : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre Cliente :";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(147, 183);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(38, 15);
            this.lblApellido.TabIndex = 24;
            this.lblApellido.Text = "label6";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellidoCliente.Location = new System.Drawing.Point(26, 183);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(115, 17);
            this.lblApellidoCliente.TabIndex = 23;
            this.lblApellidoCliente.Text = "Apellido Cliente :";
            // 
            // lblCodigoFactura
            // 
            this.lblCodigoFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigoFactura.Location = new System.Drawing.Point(161, 87);
            this.lblCodigoFactura.Name = "lblCodigoFactura";
            this.lblCodigoFactura.Size = new System.Drawing.Size(157, 34);
            this.lblCodigoFactura.TabIndex = 26;
            this.lblCodigoFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(161, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "Codigo Factura ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(314, 275);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(140, 34);
            this.lblTotal.TabIndex = 32;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(314, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 36);
            this.label13.TabIndex = 31;
            this.label13.Text = "Total";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProducto
            // 
            this.lblProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProducto.Location = new System.Drawing.Point(161, 275);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(157, 34);
            this.lblProducto.TabIndex = 30;
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(161, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 34);
            this.label11.TabIndex = 29;
            this.label11.Text = "Metodo De Pago";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotal.Location = new System.Drawing.Point(12, 275);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(157, 34);
            this.lblSubTotal.TabIndex = 28;
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 34);
            this.label9.TabIndex = 27;
            this.label9.Text = "Sub Total";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 359);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCodigoFactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BarraDeTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetalleFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDetalleFactura";
            this.Load += new System.EventHandler(this.FrmDetalleFactura_Load);
            this.BarraDeTitulo.ResumeLayout(false);
            this.BarraDeTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraDeTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblCodigoFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label9;
    }
}