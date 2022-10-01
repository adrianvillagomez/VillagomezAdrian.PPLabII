namespace Vista
{
    partial class FrmInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblInicio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lvlCerrarSesion = new System.Windows.Forms.Label();
            this.dtvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFijarPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.pictureBoxBuscar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBuscador = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.BackColor = System.Drawing.Color.Teal;
            this.lblInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInicio.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(0, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(1089, 87);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Electronic Life Inventario";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.Logout_37127;
            this.pictureBox1.Location = new System.Drawing.Point(1007, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lvlCerrarSesion
            // 
            this.lvlCerrarSesion.AutoSize = true;
            this.lvlCerrarSesion.BackColor = System.Drawing.Color.Teal;
            this.lvlCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvlCerrarSesion.ForeColor = System.Drawing.Color.RosyBrown;
            this.lvlCerrarSesion.Location = new System.Drawing.Point(983, 63);
            this.lvlCerrarSesion.Name = "lvlCerrarSesion";
            this.lvlCerrarSesion.Size = new System.Drawing.Size(106, 18);
            this.lvlCerrarSesion.TabIndex = 2;
            this.lvlCerrarSesion.Text = "Cerrar Sesion";
            // 
            // dtvProductos
            // 
            this.dtvProductos.AllowUserToAddRows = false;
            this.dtvProductos.AllowUserToDeleteRows = false;
            this.dtvProductos.AllowUserToResizeColumns = false;
            this.dtvProductos.AllowUserToResizeRows = false;
            this.dtvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dtvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvProductos.Location = new System.Drawing.Point(255, 140);
            this.dtvProductos.Name = "dtvProductos";
            this.dtvProductos.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            this.dtvProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtvProductos.RowTemplate.Height = 25;
            this.dtvProductos.Size = new System.Drawing.Size(587, 367);
            this.dtvProductos.TabIndex = 3;
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.Location = new System.Drawing.Point(38, 389);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(138, 23);
            this.btnAgregarProductos.TabIndex = 4;
            this.btnAgregarProductos.Text = "Agregar Producto";
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDetalle.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDetalle.Location = new System.Drawing.Point(37, 118);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(136, 19);
            this.lblDetalle.TabIndex = 5;
            this.lblDetalle.Text = "Detalle Producto";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(37, 152);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 15);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca :";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(37, 170);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(139, 23);
            this.txtMarca.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fijar Categoria :";
            // 
            // txtFijarPrecio
            // 
            this.txtFijarPrecio.Location = new System.Drawing.Point(37, 302);
            this.txtFijarPrecio.Name = "txtFijarPrecio";
            this.txtFijarPrecio.Size = new System.Drawing.Size(139, 23);
            this.txtFijarPrecio.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Modelo :";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(37, 258);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(139, 23);
            this.txtModelo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fijar Precio :";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(37, 214);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(139, 23);
            this.cmbCategoria.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cantidad :";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(37, 346);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(139, 23);
            this.txtCantidad.TabIndex = 15;
            // 
            // pictureBoxBuscar
            // 
            this.pictureBoxBuscar.Image = global::Vista.Properties.Resources.find_search_locate_6201;
            this.pictureBoxBuscar.Location = new System.Drawing.Point(1007, 152);
            this.pictureBoxBuscar.Name = "pictureBoxBuscar";
            this.pictureBoxBuscar.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBuscar.TabIndex = 16;
            this.pictureBoxBuscar.TabStop = false;
            this.pictureBoxBuscar.Click += new System.EventHandler(this.pictureBoxBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(255, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Lista De Productos";
            // 
            // cmbBuscador
            // 
            this.cmbBuscador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscador.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBuscador.FormattingEnabled = true;
            this.cmbBuscador.Location = new System.Drawing.Point(848, 158);
            this.cmbBuscador.Name = "cmbBuscador";
            this.cmbBuscador.Size = new System.Drawing.Size(153, 25);
            this.cmbBuscador.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(848, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Buscar Por Tags :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vista.Properties.Resources.refresh_14433;
            this.pictureBox2.Location = new System.Drawing.Point(1045, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1089, 523);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbBuscador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxBuscar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFijarPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.btnAgregarProductos);
            this.Controls.Add(this.dtvProductos);
            this.Controls.Add(this.lvlCerrarSesion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lvlCerrarSesion;
        private System.Windows.Forms.DataGridView dtvProductos;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFijarPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.PictureBox pictureBoxBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBuscador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}