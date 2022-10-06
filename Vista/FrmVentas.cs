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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class FrmVentas : Form
    {
        Negocio central;
        List<Producto> listaAux;
        List<Producto> listaAuxPedido;
        List<Factura> listaFacturas;
        Factura f1;
        decimal acumulador;
        Contador contador;
        public FrmVentas(Negocio negocio, Contador contador)
        {
            InitializeComponent();
            this.central = negocio;
            listaAuxPedido = new List<Producto>();
            listaFacturas = new List<Factura>();
            this.contador = contador;
        }
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            cmbBuscador.DataSource = Enum.GetValues(typeof(Tag));

            LimpiarListBoxAux();


            cmbMetodoDePago.DataSource = Enum.GetValues(typeof(MetodoDePago));
            cmbMetodoDePago.SelectedItem = 0;
            txtNombreCliente.Text = "Juan";
            txtApellidoCliente.Text = "Suarez";
            txtDniCliente.Text = "94562213";

        }
        /// <summary>
        /// boton de busqueda segun criterio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxBuscar_Click(object sender, EventArgs e)
        {
            listaAux = new List<Producto>();
            string buscar = cmbBuscador.SelectedItem.ToString();
            foreach (Producto item in central.ListaProductos)
            {

                if (item.Tag.ToString().Contains(buscar))
                {
                    listaAux.Add(item);
                }
            }
            LimpiarListBoxAux();
        }
        /// <summary>
        /// Evento doble click del listbox de la seccion buscar productos.Agregar los detalles del producto para confirmar compra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstProductos_DoubleClick(object sender, EventArgs e)
        {
            if (lstProductos.SelectedIndex != -1)
            {
                Producto p = listaAux[lstProductos.SelectedIndex];
                txtMarca.Text = p.Marca;
                txtModelo.Text = p.Modelo;
                txtPrecio.Text = p.Precio.ToString();
                txtCategoria.Text = p.Tag.ToString();
            }
        }
        /// <summary>
        /// Evento del boton agregar.Validara que se selecciono productos y los agregara al carrito y le quitara la cantidad de stock correspondiente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lstProductos.SelectedIndex != -1)
            {
                if (txtMarca.Text.Trim() == "" || txtMarca.Text.Trim() == "" || txtCategoria.Text.Trim() == "" || txtModelo.Text.Trim() == "")
                {
                    lblErrorInv.Text = "*Seleccionar productos de la Lista";
                    lblErrorInv.ForeColor = Color.Red;
                }
                else
                {

                    Producto p = listaAux[lstProductos.SelectedIndex];
                    if (p.Stock > 0)
                    {
                        p.Stock = -1;
                        lstProductos.DataSource = null;
                        lstProductos.DataSource = listaAux;
                        acumulador += p.Precio;
                        txtPrecioTotal.Text = acumulador.ToString();
                        lblErrorInv.Text = "";
                        AgregarProductosCarrito();
                        if (cmbMetodoDePago.SelectedIndex == 0)
                        {
                            decimal.TryParse(txtPrecioTotal.Text, out decimal total);
                            txtPrecioFinal.Text = total.ToString();
                        }
                        if (cmbMetodoDePago.SelectedIndex == 1)
                        {
                            decimal.TryParse(txtPrecioTotal.Text, out decimal total);
                            txtPrecioFinal.Text = (total + (total * 10 / 100)).ToString();
                        }
                    }
                    else
                    {
                        lblErrorInv.Text = "*Producto sin stock";
                        lblErrorInv.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                lblErrorInv.Text = "*Seleccionar productos de la Lista";
                lblErrorInv.ForeColor = Color.Red;
            }

        }
        private void AgregarProductosCarrito()
        {
            Tag tag;
            Enum.TryParse<Tag>(txtCategoria.Text, out tag);
            decimal.TryParse(txtPrecio.Text, out decimal precio);
            Producto pedido = new Producto(txtMarca.Text, tag, txtModelo.Text, precio, 0);
            listaAuxPedido.Add(pedido);
            dtvCarrito.DataSource = null;
            dtvCarrito.DataSource = listaAuxPedido;
            dtvCarrito.Columns["Cantidad"].Visible = false;
            dtvCarrito.Columns["Stock"].Visible = false;
        }
        private void LimpiarListBoxAux()
        {
            lstProductos.DataSource = null;
            lstProductos.DataSource = listaAux;
        }
        /// <summary>
        /// Evento del combobox que segun la cantidad de prodcutos calculara  el subtotal y el precio total
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMetodoDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMetodoDePago.SelectedIndex == 0)
            {
                decimal.TryParse(txtPrecioTotal.Text, out decimal total);
                txtPrecioFinal.Text = total.ToString();
            }
            if (cmbMetodoDePago.SelectedIndex == 1)
            {
                decimal.TryParse(txtPrecioTotal.Text, out decimal total);
                txtPrecioFinal.Text = (total + (total * 10 / 100)).ToString();
            }
        }
        /// <summary>
        /// Evento click del boton de venta. Instanciara una factura si se elegi seguir con la compra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVenta_Click(object sender, EventArgs e)
        {
            if (ValidarIngresoDeCliente())
            {
                Random rd = new Random();
                Cliente c1 = new Cliente(txtNombreCliente.Text, txtApellidoCliente.Text, txtDniCliente.Text);
                f1 = new Factura();
                f1.Cliente = c1;
                f1.ListaAuxPedido = this.listaAuxPedido;
                f1.Codigo = rd.Next(1500, 2000);
                decimal.TryParse(txtPrecioTotal.Text, out decimal subTotal);
                decimal.TryParse(txtPrecioFinal.Text, out decimal precioFinal);
                f1.SubTotal = subTotal;
                f1.Total = precioFinal;
                f1.MedioDePago = (MetodoDePago)cmbMetodoDePago.SelectedItem;
               
                listaFacturas.Add(f1);
                FrmFactura factura = new FrmFactura(f1,listaFacturas,contador);
                factura.ShowDialog();
                if (factura.DialogResult == DialogResult.OK)
                {
                    btnLimpiar_Click(sender,e);
                }
                if (factura.DialogResult == DialogResult.Cancel)
                {
                    listaFacturas.Remove(f1);
                    btnLimpiar_Click(sender, e);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listaAuxPedido.Clear();
            dtvCarrito.DataSource = null;

            txtPrecioTotal.Text = "";
            txtPrecioFinal.Text = "";
            cmbMetodoDePago.SelectedIndex = 0;

            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPrecio.Text = "";
            txtCategoria.Text = "";
            lblErrorClientes.Text = "";
        }
        private bool ValidarIngresoDeCliente()
        {
            if (txtApellidoCliente.Text == "" || txtNombreCliente.Text == "" || txtDniCliente.Text == "")
            {
                lblErrorClientes.Text = "*Cliente no Ingresado";
                lblErrorClientes.ForeColor = Color.Red;
                return false;
            }
            if (dtvCarrito.DataSource == null)
            {
                lblErrorClientes.Text = "*Carrito vacio";
                lblErrorClientes.ForeColor = Color.Red;
                return false;
            }

            return true;
        }
        /// <summary>
        /// evento click del boton historial de factura .Abrira el historial de facturas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmHistorialFactura historialFactura = new FrmHistorialFactura(listaFacturas,f1);
            historialFactura.ShowDialog();            
        }
    }
}
