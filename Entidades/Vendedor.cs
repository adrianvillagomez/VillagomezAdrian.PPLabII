using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor : Usuario
    {
        public Vendedor(string nombre, string mail, string contraseña) : base(nombre, mail, contraseña)
        {
        }
    }
}
