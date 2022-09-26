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
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login.ValidarDatos(txtMail.Text, txtContraseña.Text))
            {
                if (txtMail.Text == "admin@admin.com" && txtContraseña.Text == "1234")
                {
                    FrmMenu menu = new FrmMenu();
                    menu.ShowDialog();
                }else if(txtMail.Text == "alberto@gmail.com" && txtContraseña.Text == "Adf145633")
                {
                    FrmMenu menu = new FrmMenu();
                    menu.ShowDialog();
                }
                else
                {
                    lblMensaje.Text = "*Usuario Incorrecto";
                }
                
            }
            else
            {
                lblMensaje.Text = "*Se deben Completar todos los campos";
            }
        }

        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            if (cmbRol.Text == "Administrador")
            {
                txtContraseña.Text = "1234";
                txtMail.Text = "admin@admin.com";
                if (txtContraseña.Text !="1234" && txtMail.Text != "admin@admin.com")
                lblMensaje.Visible = !lblMensaje.Visible;

            }
            else if (cmbRol.Text == "Vendedor")
            {
                txtContraseña.Text = "Adf145633";
                txtMail.Text = "alberto@gmail.com";
                if(txtContraseña.Text !="Adf145633" && txtMail.Text != "alberto@gmail.com")
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
    }
}
