using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Login
    {
        static List<Usuario> usuarios;

        public static List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }

        static Login()
        {
            usuarios = new List<Usuario>();
            AgregarUsuarios();
        }

    
        public static bool ValidarDatos(string value,string pass)
        {
            if (!(string.IsNullOrEmpty(value))&& !(string.IsNullOrEmpty(pass)))
            {
                return true;
            }
            return false;
        }
        public static void AgregarUsuarios()
        {
            usuarios.Add(new Dueño("Juan", "Perez", "admin@admin.com", "1234"));
            usuarios.Add(new Vendedor("Alberto", "Gonzales", "alberto@gmail.com", "Adf145633"));
            usuarios.Add(new Vendedor("Juan", "Lara", "juan@gmail.com", "Adf2233"));
            usuarios.Add(new Vendedor("Jorge", "Gutierrez", "jorge@gmail.com", "Assdf145633"));
            usuarios.Add(new Vendedor("Lucho", "Kmpe", "lucho@gmail.com", "asd225633"));
            usuarios.Add(new Contador("pablo", "Diaz", "pablo@gmail.com", "123456789"));
        }
    }
}
