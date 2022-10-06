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
        int ventasPerifericos;
        int ventasplacaVideo;
        int ventasNote;
        int ventasComputadoras;
        int ventasComponentePc;
        int ventasConsolas;
        int ventasSmarphones;
        int ventasConectividad;
        int ventasAlmacenamiento;
        public Contador(string nombre, string apellido, string mail, string contraseña) : base(nombre, apellido, mail, contraseña)
        {
        }

        public int VentasRealizadas { get => ventasRealizadas; set => ventasRealizadas = value; }
        public int VentasPerifericos { get => ventasPerifericos; set => ventasPerifericos = value; }
        public int VentasplacaVideo { get => ventasplacaVideo; set => ventasplacaVideo = value; }
        public int VentasNote { get => ventasNote; set => ventasNote = value; }
        public int VentasComputadoras { get => ventasComputadoras; set => ventasComputadoras = value; }
        public int VentasComponentePc { get => ventasComponentePc; set => ventasComponentePc = value; }
        public int VentasConsolas { get => ventasConsolas; set => ventasConsolas = value; }
        public int VentasSmarphones { get => ventasSmarphones; set => ventasSmarphones = value; }
        public int VentasConectividad { get => ventasConectividad; set => ventasConectividad = value; }
        public int VentasAlmacenamiento { get => ventasAlmacenamiento; set => ventasAlmacenamiento = value; }

        public override void Vender(Producto p1, int cantidad)
        {
            throw new NotImplementedException();
        }
    }
}
