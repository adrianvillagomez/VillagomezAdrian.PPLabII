using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dueño : Usuario
    {
        public Dueño(string nombre, string apellido, string mail, string contraseña) : base(nombre,apellido, mail, contraseña)
        {
        }
        public override void Vender(Producto p1, int cantidad)
        {
            if (p1.Stock > 0 && cantidad > 0)
            {
                p1.Stock = -cantidad;
            }
        }


    }
}
