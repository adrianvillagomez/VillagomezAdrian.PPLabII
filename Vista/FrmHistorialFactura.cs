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
    public partial class FrmHistorialFactura : Form
    {
        List<Factura> listaFacturas;
        Factura f1;
        public FrmHistorialFactura(List<Factura> listaFacturas, Factura f1)
        {
            InitializeComponent();
            this.listaFacturas = listaFacturas;
            this.f1 = f1;
        }

        private void FrmHistorialFactura_Load(object sender, EventArgs e)
        {

            dtvHistorial.DataSource = null;
            dtvHistorial.DataSource = listaFacturas;
            this.dtvHistorial.Columns["Cliente"].Visible = false;

        }

        private void dtvHistorial_DoubleClick(object sender, EventArgs e)
        {         
            Cliente item1 = (Cliente)dtvHistorial.CurrentRow.Cells[0].Value;
            string codigo = dtvHistorial.CurrentRow.Cells[1].Value.ToString();
            string subTotal = dtvHistorial.CurrentRow.Cells[2].Value.ToString();
            string total = dtvHistorial.CurrentRow.Cells[3].Value.ToString();
            string metodoPago = dtvHistorial.CurrentRow.Cells[4].Value.ToString();
            FrmDetalleFactura detalle = new FrmDetalleFactura(item1,codigo,subTotal,total,metodoPago);
            detalle.ShowDialog();
        }
     
    }
}
