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
    public partial class FrmMenu : Form
    {  
        Negocio central;
        Contador contador;
        public FrmMenu(Negocio central,Contador contador)
        {
            InitializeComponent();
            this.central = central; 
            this.contador = contador;
   
        }
        /// <summary>
        /// Evento click del boton Administrar inventario.Nos llevara al inventario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInvenario_Click(object sender, EventArgs e)
        {
            FrmInventario inventario = new FrmInventario(central,contador);
            inventario.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Evento click del boton Administrar ventas.Nos llevara al administrador de ventas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas ventas = new FrmVentas(central, contador);
            ventas.ShowDialog();
        }
    }
}
