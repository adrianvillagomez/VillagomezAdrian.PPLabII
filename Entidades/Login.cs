using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Login
    {
        private static List<Usuario> usuarios;
        static Login()
        {
            usuarios = new List<Usuario>();
            AgregarUsuarios();
        }

        public static List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }

        public static void AgregarUsuarios()
        {
            Dueño dueño = new Dueño("Juan","Rockefeller", "admin@admin.com", "1234");
            Vendedor vendedor1 = new Vendedor("Alberto","Perez" ,"alberto@gmail.com", "Adf145633");
            //Vendedor vendedor2 = new Vendedor("Federico","Fernandez", "alberto@gmail.com", "2455");
            //Vendedor vendedor3 = new Vendedor("Roberto","Acosta", "alberto@gmail.com", "1564");
            usuarios.Add(dueño);
            usuarios.Add(vendedor1);
            //usuarios.Add(vendedor2);
            //usuarios.Add(vendedor3);
        }
        public static bool ValidarDatos(string value,string pass)
        {
            if (!(string.IsNullOrEmpty(value))&& !(string.IsNullOrEmpty(pass)))
            {
                return true;
            }
            return false;
        }

    }
}
