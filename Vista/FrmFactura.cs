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
        public FrmFactura(Factura f1)
        {
            InitializeComponent();
            this.factura = f1;
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
                
            }                         
        }
    }
}
