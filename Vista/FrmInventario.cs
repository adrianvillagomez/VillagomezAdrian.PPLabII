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
        public FrmInventario()
        {
            InitializeComponent();
            this.central = AgregarProductos();
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
        private Negocio AgregarProductos()
        {
            Negocio electronicLife = new Negocio();
            Producto p1 = new Producto("Asus", Entidades.Tag.Placa_Video, "3050TI", 50000, 100);
            Producto p2 = new Producto("Aorus", Entidades.Tag.Placa_Video, "205TI", 2354, 100);
            Producto p3 = new Producto("Ventus", Entidades.Tag.Placa_Video, "1050", 42354, 100);
            Producto p4 = new Producto("Kingston", Entidades.Tag.Componente_PC, "1050", 42354, 100);
            Producto p5 = new Producto("Lenovo", Entidades.Tag.Computadoras, "B522", 42354, 2);
            Producto p6 = new Producto("Samsumg", Entidades.Tag.Smarphones, "A23", 42354, 100);
            Producto p7 = new Producto("Lenovo", Entidades.Tag.Computadoras, "C253", 10000, 10);
            Producto p8 = new Producto("Samsumg", Entidades.Tag.Periferico, "Z25", 1000, 100);
            Producto p9 = new Producto("WIffi", Entidades.Tag.Conectividad, "j21-58", 1500, 100);
            Producto p10 = new Producto("Samsumg", Entidades.Tag.Almacenamiento, "SSD", 2500, 100);
            Producto p11 = new Producto("Sonic", Entidades.Tag.Consolas, "PS4", 150000, 1);
            Producto p12 = new Producto("Samsumg", Entidades.Tag.Periferico, "B35", 500, 100);
            Producto p13 = new Producto("Aple", Entidades.Tag.Smarphones, "h35", 150000, 50);
            
            electronicLife += p1;
            electronicLife += p2;
            electronicLife += p3;
            electronicLife += p4;
            electronicLife += p5;
            electronicLife += p6;
            electronicLife += p7;
            electronicLife += p8;
            electronicLife += p9;
            electronicLife += p10;
            electronicLife += p11;
            electronicLife += p12;
            electronicLife += p13;

            return electronicLife;
        }

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
