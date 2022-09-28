using Entidades;
using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Negocio electronicLife = new Negocio();
            Producto p1 = new Producto("Asus", Categoria.Placa_Video, "3050TI", 50000, 100);
            Producto p2 = new Producto("Aorus", Categoria.Placa_Video, "205TI", 2354, 100);
            Producto p3 = new Producto("Ventus", Categoria.Placa_Video, "1050", 42354, 100);
            Producto p4 = new Producto("Asus", Categoria.Placa_Video, "3050TI", 2354, 100);
            electronicLife += p1;
            electronicLife += p2;
            electronicLife += p3;
            electronicLife += p4;
            Console.WriteLine(electronicLife.ToString());
        }
    }
}
