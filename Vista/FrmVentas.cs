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
    public partial class FrmVentas : Form
    {
        Negocio central;
        List<Producto> listaAux;
        public FrmVentas(Negocio negocio)
        {
            InitializeComponent();
            this.central = negocio;
            listaAux = new List<Producto>();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            cmbBuscador.DataSource = Enum.GetValues(typeof(Tag));
            lstProductos.DataSource = central.ListaProductos;

        }

        private void pictureBoxBuscar_Click(object sender, EventArgs e)
        {
          
            string buscar = cmbBuscador.SelectedItem.ToString();
            foreach (Producto item in central.ListaProductos)
            {

                if (item.Tag.ToString().Contains(buscar))
                {
                    listaAux.Add(item);
                }
            }
            lstProductos.DataSource = null;
            lstProductos.DataSource = listaAux;

        }

     

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lstProductos.SelectedIndex != -1)
            //{
            //    Producto p = listaAux[lstProductos.SelectedIndex];
            //    txtMarca.Text = p.Marca;
            //}
        }
    }
}
