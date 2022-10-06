using Entidades;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmIngreso : Form
    {
        Negocio central;
        Contador contador;
        public FrmIngreso()
        {
            InitializeComponent();
            central = AgregarProductos();
        }
        /// <summary>
        /// Boton para ingresar al inventario o a ventas segun el criterio elegido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (Login.ValidarDatos(txtMail.Text, txtContraseña.Text))
            {
                foreach (Usuario item in Login.Usuarios)
                {
                    if (item is Dueño)
                    {
                        if (txtMail.Text == ((Dueño)item).Mail && txtContraseña.Text == "1234")
                        {
                            
                            FrmMenu menu = new FrmMenu(central,contador);
                            menu.ShowDialog();
                            break;
                        }
                    }
                    else if (item is Vendedor)
                    {
                        if (txtMail.Text == ((Vendedor)item).Mail && txtContraseña.Text == "Adf145633")
                        {
                            FrmVentas ventas = new FrmVentas(central,contador);
                            ventas.ShowDialog();
                            break;
                        }                      
                    }
                    else if (item is Contador)
                    {
                        if (txtMail.Text == ((Contador)item).Mail && txtContraseña.Text == "123456789")
                        {
                            contador = (Contador)item;
                            FrmEstadistica estadisticas = new FrmEstadistica(central,contador);
                            estadisticas.ShowDialog();
                            break;
                        }
                    }else
                    {
                        lblMensaje.Text = "*Usuario Incorrecto";
                    }
                }
            }
            else
            {
                lblMensaje.Text = "*Se deben Completar todos los campos";
            }
        }
        /// <summary>
        /// Boton para autocompletar el login como vendedor o administrador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            if (cmbRol.Text == "Administrador")
            {
                txtContraseña.Text = "1234";
                txtMail.Text = "admin@admin.com";
                if (txtContraseña.Text != "1234" && txtMail.Text != "admin@admin.com")
                    lblMensaje.Visible = !lblMensaje.Visible;

            }
            else if (cmbRol.Text == "Vendedor")
            {
                txtContraseña.Text = "Adf145633";
                txtMail.Text = "alberto@gmail.com";
                if (txtContraseña.Text != "Adf145633" && txtMail.Text != "alberto@gmail.com")
                    lblMensaje.Visible = !lblMensaje.Visible;

            }
            else if (cmbRol.Text == "Contador")
            {
                txtContraseña.Text = "123456789";
                txtMail.Text = "pablo@gmail.com";
                if (txtContraseña.Text != "Adf145633" && txtMail.Text != "alberto@gmail.com")
                    lblMensaje.Visible = !lblMensaje.Visible;

            }
        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            cmbRol.DataSource = Enum.GetValues(typeof(Roles));
            cmbRol.SelectedItem = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Negocio AgregarProductos()
        {
            Negocio electronicLife = new Negocio();
            Producto p1 = new Producto("asus", Entidades.Tag.Placa_Video, "3050", 50000, 100);
            Producto p2 = new Producto("aorus", Entidades.Tag.Placa_Video, "205", 2354, 100);
            Producto p3 = new Producto("ventus", Entidades.Tag.Placa_Video, "1050", 42354, 100);
            Producto p4 = new Producto("kingston", Entidades.Tag.Componente_PC, "1050", 42354, 100);
            Producto p5 = new Producto("lenovo", Entidades.Tag.Computadoras, "b522", 42354, 2);
            Producto p6 = new Producto("samsumg", Entidades.Tag.Smarphones, "a23", 42354, 100);
            Producto p7 = new Producto("lenovo", Entidades.Tag.Computadoras, "c253", 10000, 10);
            Producto p8 = new Producto("samsumg", Entidades.Tag.Periferico, "z25", 1000, 100);
            Producto p9 = new Producto("wifi", Entidades.Tag.Conectividad, "j2158", 1500, 100);
            Producto p10 = new Producto("samsumg", Entidades.Tag.Almacenamiento, "ssd", 2500, 100);
            Producto p11 = new Producto("sonic", Entidades.Tag.Consolas, "ps4", 150000, 1);
            Producto p12 = new Producto("samsumg", Entidades.Tag.Periferico, "b35", 500, 100);
            Producto p13 = new Producto("aplle", Entidades.Tag.Smarphones, "h35", 150000, 50);

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
    }
}
