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
            if (Login.ValidarDatos(txtMail.Text) && Login.ValidarDatos(txtContraseña.Text))
            {
                if (txtMail.Text == "admin@admin.com" && txtContraseña.Text == "1234")
                {
                    FrmMenu menu = new FrmMenu();
                    menu.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            if (cmbRol.Text == "Administrador")
            {
                txtContraseña.Text = "1234";
                txtMail.Text = "admin@admin.com";
            }
            else if (cmbRol.Text == "Vendedor")
            {
                Random rd = new Random();

                foreach (Usuario item in Login.Usuarios)
                {

                    if (item is Vendedor)
                    {
                        txtContraseña.Text = ((Vendedor)item).Contraseña;
                        txtMail.Text = ((Vendedor)item).Mail;
                    }
                }
            }
        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            cmbRol.DataSource = Enum.GetValues(typeof(Roles));
            cmbRol.SelectedItem = null;
        }
    }
}
