using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contador : Usuario
    {
        int ventasRealizadas;
        static List<Producto> listaProductoVendidos;
        static Contador()
        {
            Contador.listaProductoVendidos = new List<Producto>();
        }
        public Contador(string nombre, string apellido, string mail, string contraseña) : base(nombre, apellido, mail, contraseña)
        {
        }

        public static List<Producto> ListaProductoVendidos { get => listaProductoVendidos; set => listaProductoVendidos = value; }
        public int VentasRealizadas { get => ventasRealizadas; set => ventasRealizadas = value; }

        public override void Vender(Producto p1, int cantidad)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Toma por parametro el un enumerado y segun el criterio te devuelve una lista de productos
        /// con esa tag en especifico
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public static List<Producto> ProductosVendidosPorTag(Tag categoria)
        {
            List<Producto> listaDeProduuctosPorCategoria = new List<Producto>();
            foreach (Producto item in Contador.ListaProductoVendidos)
            {
                if (item.Tag == categoria)
                {
                    listaDeProduuctosPorCategoria.Add(item);
                }
            }
            return listaDeProduuctosPorCategoria;
        }
        public static string ProductoMasVendidoSegunTag(Tag categoria)
        {
            List<Producto> listaAux = new List<Producto>();
            listaAux = ProductosVendidosPorTag(categoria);
            int maximo = 0;
            string nombre = string.Empty;
            foreach (Producto item in listaAux)
            {
                if (item.Stock > maximo)
                {
                    maximo = item.Stock;
                    nombre = item.Marca;
                }
            }
            return nombre;
        }
        public static decimal PromedioGanaciaPorTag(Tag categoria)
        {
            decimal result = 0;
            decimal acumuladorGanancia = 0;
            int cantidadItems = 0;
            List<Producto> listaAux = new List<Producto>();
            listaAux = ProductosVendidosPorTag(categoria);
            foreach (Producto item in listaAux)
            {
                cantidadItems++;
                acumuladorGanancia += item.Precio;
            }
            if (cantidadItems != 0)
            {
                result = acumuladorGanancia / cantidadItems;
            }

            return result;
        }

    }
}
