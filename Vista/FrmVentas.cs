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
        decimal acumulador;
        public FrmVentas(Negocio negocio)
        {
            InitializeComponent();
            this.central = negocio;
            listaAuxPedido = new List<Producto>();
        }
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            cmbBuscador.DataSource = Enum.GetValues(typeof(Tag));
           
            LimpiarListBoxAux();


            cmbMetodoDePago.DataSource = Enum.GetValues(typeof(MetodoDePago));
            cmbMetodoDePago.SelectedItem = 0;

        }

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
                        lblErrorInv.Text ="";
                        AgregarProductosCarrito();
                        if(cmbMetodoDePago.SelectedIndex == 0)
                        {
                            decimal.TryParse(txtPrecioTotal.Text, out decimal total);
                            txtPrecioFinal.Text = total.ToString();
                        }
                        if (cmbMetodoDePago.SelectedIndex == 1)
                        {
                            decimal.TryParse(txtPrecioTotal.Text, out decimal total);
                            txtPrecioFinal.Text = (total+(total*10/100)).ToString();
                        }
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

        private void btnVenta_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            Cliente c1 = new Cliente(txtNombreCliente.Text,txtApellidoCliente.Text,txtDniCliente.Text);
            Factura f1 = new Factura();
            f1.Cliente= c1;
            f1.ListaAuxPedido=this.listaAuxPedido;
            f1.Codigo = rd.Next(1500, 2000);

            //Agregar a una lsita de facturas para el historial ;
            FrmFactura factura = new FrmFactura(f1);
            factura.ShowDialog();
        }
        //Agregar a una lsita de facturas para el historial ;
        //Boton de historial
        //Validar q se completen los nombres en ventas
        //validar q se eligan productos
    }
}
