using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmDetalleFactura : Form
    {
        Cliente cliente;
        string codigo;
        string subtotal;
        string total;
        string metodoPago;
        public FrmDetalleFactura()
        {
            InitializeComponent();
        }
        public FrmDetalleFactura(Cliente cliente, string codigo, string subtotal, string total, string metodoPago):this()
        {
            this.cliente = cliente;
            this.codigo = codigo;
            this.subtotal = subtotal;
            this.total = total;
            this.metodoPago = metodoPago;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDetalleFactura_Load(object sender, EventArgs e)
        {
            lblNombre.Text = cliente.Nombre;
            lblApellido.Text = cliente.Apellido;
            lblDoc.Text = cliente.Dni;
            lblCodigoFactura.Text = this.codigo;
            lblSubTotal.Text = this.subtotal;
            lblTotal.Text = this.total;
            lblProducto.Text = this.metodoPago;
        }
    }
}
