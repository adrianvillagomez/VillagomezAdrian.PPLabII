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
            cmbCategoria.SelectedItem = null;   
            
            cmbBuscador.DataSource = Enum.GetValues(typeof(Tag));

        }
        private Negocio AgregarProductos()
        {
            Negocio electronicLife = new Negocio();
            Producto p1 = new Producto("Asus", Entidades.Tag.Placa_Video, "3050TI", 50000, 100);
            Producto p2 = new Producto("Aorus", Entidades.Tag.Placa_Video, "205TI", 2354, 100);
            Producto p3 = new Producto("Ventus", Entidades.Tag.Placa_Video, "1050", 42354, 100);
            Producto p4 = new Producto("Kingston", Entidades.Tag.Componente_PC, "1050", 42354, 100);
            Producto p5 = new Producto("Lenovo", Entidades.Tag.Computadoras, "B522", 42354, 5);
            Producto p6 = new Producto("Samsumg", Entidades.Tag.Smarphones, "A23", 42354, 100);

            Producto p7 = new Producto("Lenovo", Entidades.Tag.Computadoras, "B522", 42354, 10);
            electronicLife += p1;
            electronicLife += p2;
            electronicLife += p3;
            electronicLife += p4;
            electronicLife += p5;
            electronicLife += p6;
            electronicLife += p7;
            return electronicLife;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount =
             dtvProductos.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (dtvProductos.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    System.Text.StringBuilder sb =
                        new System.Text.StringBuilder();

                    for (int i = 0;
                                     i < selectedCellCount; i++)
                    {
                        sb.Append("Row: ");
                        sb.Append(dtvProductos.SelectedCells[i].RowIndex
                            .ToString());
                        sb.Append(", Column: ");
                        sb.Append(dtvProductos.SelectedCells[i].ColumnIndex
                            .ToString());
                        sb.Append(Environment.NewLine);
                    }

                    sb.Append("Total: " + selectedCellCount.ToString());
                    MessageBox.Show(sb.ToString(), "Selected Cells");
                }
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            Tag tag;
            decimal precio;
            int cantidad;
            string marca=txtMarca.Text; 
            Enum.TryParse<Tag>(cmbCategoria.SelectedValue.ToString(),out tag);
            string modelo = txtModelo.Text;
            decimal.TryParse(txtFijarPrecio.Text,out precio);
            int.TryParse(txtCantidad.Text,out cantidad);

            Producto productoNuevo = new Producto(marca, tag, modelo, precio, cantidad);
            central += productoNuevo;

            LimpiarDataGrid();
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
    }
}
