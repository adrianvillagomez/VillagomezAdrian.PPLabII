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
    public partial class FrmFactura : Form
    {
        Factura factura;
        List<Factura> listaFacturas;
        Contador contador;
        public FrmFactura(Factura f1, List<Factura> listaFacturas, Contador contador)
        {
            InitializeComponent();
            this.factura = f1;
            this.listaFacturas = listaFacturas;
            this.contador = contador;
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            lblNombre.Text = factura.Cliente.Nombre;
            lblApellido.Text = factura.Cliente.Apellido;
            lblDoc.Text = factura.Cliente.Dni;
            lblCodigoFactura.Text = factura.Codigo.ToString();
            foreach (var item in factura.ListaAuxPedido)
            {
                lstProductos.DataSource = null;
                lstProductos.Items.Add($"Marca : {item.Marca}");
                lstProductos.Items.Add($"Precio :{item.Precio}");
                lstProductos.Items.Add($"Tag : {item.Tag}");
            }
            lblSubTotal.Text = factura.SubTotal.ToString();
            lblProducto.Text = factura.MedioDePago.ToString();
            lblTotal.Text = factura.Total.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venta Realizado con exito!");
            contador.VentasRealizadas += 1;
            foreach (Producto item in factura.ListaAuxPedido)
            {
                Contador.ListaProductoVendidos.Add(item);
            }
 
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venta Cancelada!");
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
