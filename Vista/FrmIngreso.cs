using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                            //SoundPlayer sound = new SoundPlayer(@"c:\Windows\Media\IniciodenavegacióndeWindows.wav");
                            //sound.Play();
                            FrmMenu menu = new FrmMenu(central);
                            menu.ShowDialog();
                            break;
                        }
                    }
                    else if (item is Vendedor)
                    {
                        if (txtMail.Text == ((Vendedor)item).Mail && txtContraseña.Text == "Adf145633")
                        {
                            FrmVentas ventas = new FrmVentas(central);
                            ventas.ShowDialog();
                            break;
                        }
                        else
                        {
                            lblMensaje.Text = "*Usuario Incorrecto";
                        }
                    }
                } 
            }
            else
            {
                lblMensaje.Text = "*Se deben Completar todos los campos";
            }
        }
        /// <summary>
        /// Boton para autocompletar el login
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
            Producto p1 = new Producto("Asus", Entidades.Tag.Placa_Video, "3050TI", 50000, 100);
            Producto p2 = new Producto("Aorus", Entidades.Tag.Placa_Video, "205TI", 2354, 100);
            Producto p3 = new Producto("Ventus", Entidades.Tag.Placa_Video, "1050", 42354, 100);
            Producto p4 = new Producto("Kingston", Entidades.Tag.Componente_PC, "1050", 42354, 100);
            Producto p5 = new Producto("Lenovo", Entidades.Tag.Computadoras, "B522", 42354, 2);
            Producto p6 = new Producto("Samsumg", Entidades.Tag.Smarphones, "A23", 42354, 100);
            Producto p7 = new Producto("Lenovo", Entidades.Tag.Computadoras, "C253", 10000, 10);
            Producto p8 = new Producto("Samsumg", Entidades.Tag.Periferico, "Z25", 1000, 100);
            Producto p9 = new Producto("WIffi", Entidades.Tag.Conectividad, "j21-58", 1500, 100);
            Producto p10 = new Producto("Samsumg", Entidades.Tag.Almacenamiento, "SSD", 2500, 100);
            Producto p11 = new Producto("Sonic", Entidades.Tag.Consolas, "PS4", 150000, 1);
            Producto p12 = new Producto("Samsumg", Entidades.Tag.Periferico, "B35", 500, 100);
            Producto p13 = new Producto("Aple", Entidades.Tag.Smarphones, "h35", 150000, 50);

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
