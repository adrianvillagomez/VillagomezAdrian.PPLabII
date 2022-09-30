using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private List<Cliente> listaClientes;
        private List<Producto> listaProductos;
        public Negocio()
        {
            listaClientes = new List<Cliente>();
            listaProductos = new List<Producto>();
        }
        public List<Cliente> ListaClientes { get => listaClientes; set => listaClientes = value; }
        public List<Producto> ListaProductos { get => listaProductos; set => listaProductos = value; }

        public static Negocio operator +(Negocio n1, Producto p1)
        {
            if (n1 is not null && p1 is not null)
            {
                foreach (Producto item in n1.listaProductos)
                {
                    if (item == p1)
                    {
                        Console.WriteLine("El producto ya existe");
                        item.Stock = p1.Cantidad;
                        return n1;
                    }
                }
                n1.listaProductos.Add(p1);
                p1.Stock = p1.Cantidad;
                Console.WriteLine("Se agrego producto con exito");
                return n1;
            }
            return n1;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto item in this.listaProductos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

       
    }
}
