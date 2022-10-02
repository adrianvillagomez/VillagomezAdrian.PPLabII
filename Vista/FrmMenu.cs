﻿using Entidades;
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
        Negocio central;
        public FrmMenu(FrmIngreso ingreso,Negocio central)
        {
            InitializeComponent();
            this.ingreso = ingreso;
            this.central = central; 
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ingreso.Close();
        }

        private void btnInvenario_Click(object sender, EventArgs e)
        {
            FrmInventario inventario = new FrmInventario(central);
            inventario.ShowDialog();
            this.Close();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas ventas = new FrmVentas(central);
            ventas.ShowDialog();
        }
    }
}
