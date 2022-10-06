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
    public partial class FrmEstadistica : Form
    {
        Negocio central;
        Contador contador;
        public FrmEstadistica(Negocio central,Contador contador)
        {
            InitializeComponent();
            this.central = central;
            this.contador = contador;   
        }

        private void FrmEstadistica_Load(object sender, EventArgs e)
        {
            lblVentasRealizadas.Text = contador.VentasRealizadas.ToString();
            
           
        }
    }
}
