using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        List<Producto> listaAuxPedido;
        Cliente cliente;
        int codigo;
        decimal subTotal;
        decimal total;
        MetodoDePago medioDePago;
       
        public Factura()
        {  
        }     
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<Producto> ListaAuxPedido { get => listaAuxPedido; set => listaAuxPedido = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public decimal SubTotal { get => subTotal; set => subTotal = value; }
        public decimal Total { get => total; set => total = value; }
        public MetodoDePago MedioDePago { get => medioDePago; set => medioDePago = value; }
    }
}
