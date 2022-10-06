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
    public partial class FrmInventario : Form
    {
        Negocio central;

        public FrmInventario(Negocio central)
        {
            InitializeComponent();
            this.central = central;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {

            LimpiarDataGrid();

            cmbCategoria.DataSource = Enum.GetValues(typeof(Tag));
            

            cmbBuscador.DataSource = Enum.GetValues(typeof(Tag));

        }
      
        /// <summary>
        /// Agregara prodcutos a mi inventario de productos y validara que los campos no esten vacios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Trim() == "" || txtMarca.Text.Trim() == "" || txtFijarPrecio.Text.Trim() == "" || txtModelo.Text.Trim() == "")
            {
                lblErrorInv.Text = "*Se deben completar todos los campos";
                lblErrorInv.ForeColor = Color.Red;
            }
            else
            {

                Tag tag;
                decimal precio;
                int cantidad;
                string marca = txtMarca.Text;
                Enum.TryParse<Tag>(cmbCategoria.SelectedValue.ToString(), out tag);
                string modelo = txtModelo.Text;
                bool resultado1 = decimal.TryParse(txtFijarPrecio.Text, out precio);
                bool resultado2 = int.TryParse(txtCantidad.Text, out cantidad);
                if (resultado1 && resultado2)
                {
                    Producto productoNuevo = new Producto(marca, tag, modelo, precio, cantidad);
                    central += productoNuevo;

                    lblErrorInv.Text = "Producto Agregado con Exito!";
                    lblErrorInv.ForeColor = Color.Blue;
                    txtMarca.Text = "";
                    txtModelo.Text = "";
                    txtFijarPrecio.Text = "";
                    txtCantidad.Text = "";
                    LimpiarDataGrid();
                } else
                {                  
                    lblErrorInv.Text = "*Precio y Cantidad Solo valores numericos";
                    lblErrorInv.ForeColor = Color.Red;
                }
            }
           
        }
        private void LimpiarDataGrid()
        {
            dtvProductos.DataSource = null;
            dtvProductos.DataSource = central.ListaProductos;
            this.dtvProductos.Columns["Cantidad"].Visible = false;
        }
        /// <summary>
        /// Boton de busqueda de productos segun el criterio elegido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxBuscar_Click(object sender, EventArgs e)
        {
            List<Producto> listaAux = new List<Producto>();
            string buscar = cmbBuscador.SelectedItem.ToString();
            foreach (Producto item in central.ListaProductos)
            {

                if (item.Tag.ToString().Contains(buscar))
                {
                    listaAux.Add(item);
                }
            }
            dtvProductos.DataSource = null;
            dtvProductos.DataSource = listaAux;
            this.dtvProductos.Columns["Cantidad"].Visible = false;

        }
        /// <summary>
        /// boton para refrescar mi lista de inventario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LimpiarDataGrid();
        }

        private void dtvProductos_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVentas f = new FrmVentas(central);
            f.ShowDialog();
        }
    }
}
