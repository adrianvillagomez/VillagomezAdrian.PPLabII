using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string marca;
        private Tag tag;
        private string modelo;
        private decimal precio;
        private int stock;
        private int cantidad;
        public Producto(string marca, Tag categoria, string modelo, decimal precio, int cantidad)
        {
            this.marca = marca;
            this.tag = categoria;
            this.modelo = modelo;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public string Marca { get => marca; set => marca = value; }
        public Tag Tag { get => tag; set => tag = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                if (stock >= 0)
                {
                    stock += value;
                }
            }
        }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        /// <summary>
        /// Dos usuarios sera iguales si tienen la misma marca,Tag y modelo
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto c1, Producto c2)
        {
            return c1.marca == c2.marca && c1.tag == c2.tag && c1.modelo == c2.modelo;
        }
        public static bool operator !=(Producto c1, Producto c2)
        {
            return !(c1 == c2);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca : {this.Marca}");
            sb.AppendLine($"Tag : {this.Tag}");
            sb.AppendLine($"Modelo : {this.Modelo}");
            sb.AppendLine($"Precio : {this.Precio}");
            sb.AppendLine($"Stock: {this.Stock}");
            return sb.ToString();
        }
    }
}
