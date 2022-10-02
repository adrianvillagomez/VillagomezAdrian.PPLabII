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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class FrmVentas : Form
    {
        Negocio central;
        List<Producto> listaAux;
        List<Producto> listaAuxPedido;
        public FrmVentas(Negocio negocio)
        {
            InitializeComponent();
            this.central = negocio;
            listaAuxPedido = new List<Producto>();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            cmbBuscador.DataSource = Enum.GetValues(typeof(Tag));

            LimpiarListBoxAux();
        }

        private void pictureBoxBuscar_Click(object sender, EventArgs e)
        {
            listaAux = new List<Producto>();
            string buscar = cmbBuscador.SelectedItem.ToString();
            foreach (Producto item in central.ListaProductos)
            {

                if (item.Tag.ToString().Contains(buscar))
                {
                    listaAux.Add(item);
                }
            }
            LimpiarListBoxAux();
        }
        private void lstProductos_DoubleClick(object sender, EventArgs e)
        {
            if (lstProductos.SelectedIndex != -1)
            {
                Producto p = listaAux[lstProductos.SelectedIndex];
                txtMarca.Text = p.Marca;
                txtModelo.Text = p.Modelo;
                txtPrecio.Text = p.Precio.ToString();
                txtStock.Text = p.Stock.ToString();
                txtCategoria.Text = p.Tag.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lstProductos.SelectedIndex != -1)
            {
                Producto p = listaAux[lstProductos.SelectedIndex];
                if (p.Stock > 0)
                {
                    p.Stock = -1;
                    lstProductos.DataSource = null;
                    lstProductos.DataSource = listaAux;
                    AgregarProductosCarrito();
                }
            }
        }
        private void AgregarProductosCarrito()
        {
            Tag tag;
            Enum.TryParse<Tag>(txtCategoria.Text, out tag);
            decimal.TryParse(txtPrecio.Text, out decimal precio);
            Producto pedido = new Producto(txtMarca.Text, tag, txtModelo.Text, precio, 0);
            listaAuxPedido.Add(pedido);
            dtvCarrito.DataSource = null;
            dtvCarrito.DataSource = listaAuxPedido;
            dtvCarrito.Columns["Cantidad"].Visible = false;
            dtvCarrito.Columns["Stock"].Visible = false;
        }
        private void LimpiarListBoxAux()
        {
            lstProductos.DataSource = null;
            lstProductos.DataSource = listaAux;
        }
        /*
         Facturacion y problema de la list auxiliar no cambia stock;
         */
    }
}