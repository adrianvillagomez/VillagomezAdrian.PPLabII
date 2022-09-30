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
    public partial class FrmMenu : Form
    {
        FrmIngreso ingreso;
        public FrmMenu(FrmIngreso ingreso)
        {
            InitializeComponent();
            this.ingreso = ingreso;
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ingreso.Close();
        }

        private void btnInvenario_Click(object sender, EventArgs e)
        {
            FrmInventario inventario = new FrmInventario();
            inventario.ShowDialog();
            this.Close();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

        }
    }
}
