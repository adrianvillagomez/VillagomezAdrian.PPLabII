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
            Vendedor vendedor = new Vendedor("Alberto","Perez" ,"alberto@gmail.com", "Adf145633");          
            usuarios.Add(dueño);
            usuarios.Add(vendedor);
           
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
