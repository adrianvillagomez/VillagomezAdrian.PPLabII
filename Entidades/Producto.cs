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
        private Categoria categoria;
        private string modelo;
        private decimal precio;
        private int stock;

        public Producto(string marca, Categoria categoria, string modelo, decimal precio, int stock)
        {
            this.marca = marca;
            this.categoria = categoria;
            this.modelo = modelo;
            this.precio = precio;
            this.stock = stock;
        }

        public string Marca { get => marca; set => marca = value; }
        public Categoria Categoria { get => categoria; set => categoria = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }

        public static bool operator ==(Producto c1, Producto c2)
        {
            return c1.marca == c2.marca && c1.categoria == c2.categoria && c1.modelo == c2.modelo;
        }
        public static bool operator !=(Producto c1, Producto c2)
        {
            return !(c1 == c2);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca : {this.Marca}");
            sb.AppendLine($"Categoria : {this.Categoria}");
            sb.AppendLine($"Modelo : {this.Modelo}");
            sb.AppendLine($"Precio : {this.Precio}");
            sb.AppendLine($"Stock: {this.Stock}");
            return sb.ToString();
        }
    }
}
