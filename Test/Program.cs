using Entidades;
using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Negocio electronicLife = new Negocio();
            Producto p1 = new Producto("Asus", Tag.Placa_Video, "3050TI", 50000, 100);
            Producto p2 = new Producto("Aorus", Tag.Placa_Video, "205TI", 2354, 100);
            Producto p3 = new Producto("Ventus", Tag.Placa_Video, "1050", 42354, 100);
            Producto p4 = new Producto("Asus", Tag.Placa_Video, "3050TI", 2354, 100);
            Producto p5 = new Producto("Asus", Tag.Placa_Video, "3050TI", 2354, 100);
            Producto p6 = new Producto("Aorus", Tag.Placa_Video, "205TI", 2354, 100);
            Vendedor vendedor = new Vendedor("Alberto", "Perez", "alberto@gmail.com", "Adf145633");
            electronicLife += p1;
            electronicLife += p2;
            electronicLife += p3;
            electronicLife += p4;
            electronicLife += p5;
            electronicLife += p6;
            Console.WriteLine(electronicLife.ToString());

            Console.WriteLine("--------------");
            Console.WriteLine(p1.ToString());
            vendedor.Vender(p1,200);
            Console.WriteLine(p1.ToString());
            Console.WriteLine("--------------");
            Console.WriteLine(p2.ToString());
            vendedor.Vender(p2, 100);
            Console.WriteLine(p2.ToString());
        }
    }
}
