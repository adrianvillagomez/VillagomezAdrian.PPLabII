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

                switch (item.Tag)
                {
                    case Entidades.Tag.Periferico:
                        contador.VentasPerifericos += 1;
                        if (item.Marca == "samsumg")
                        {
                            int contadorSamsumg ++;
                        }
                        break;
                    case Entidades.Tag.Placa_Video:
                        contador.VentasplacaVideo += 1;
                        break;
                    case Entidades.Tag.Notebooks:
                        contador.VentasNote += 1;
                        break;
                    case Entidades.Tag.Computadoras:
                        contador.VentasComputadoras += 1;
                        break;
                    case Entidades.Tag.Componente_PC:
                        contador.VentasComponentePc += 1;
                        break;
                    case Entidades.Tag.Consolas:
                        contador.VentasConsolas += 1;
                        break;
                    case Entidades.Tag.Smarphones:
                        contador.VentasSmarphones += 1;
                        break;
                    case Entidades.Tag.Conectividad:
                        contador.VentasConectividad += 1;
                        break;
                    case Entidades.Tag.Almacenamiento:
                        contador.VentasAlmacenamiento += 1;
                        break;
                    default:
                        break;
                }
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
