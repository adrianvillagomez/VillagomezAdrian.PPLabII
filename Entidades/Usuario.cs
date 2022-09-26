using System;
using System.Text;

namespace Entidades
{
    public abstract class Usuario
    {
        protected string nombre;
        protected string apellido;
        protected string mail;
        protected string contraseña;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Mail { get => mail; set => mail = value; }       
        public string Apellido { get => apellido; set => apellido = value; }

        protected Usuario(string nombre, string apellido,string mail, string contraseña)
        {
            this.nombre = nombre;
            this.mail = mail;
            this.contraseña = contraseña;
            this.apellido = apellido;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre : {this.Nombre}");
            sb.AppendLine($"Nombre : {this.Apellido}");
            sb.AppendLine($"Mail : {this.Mail}");
            
            return sb.ToString();
        }

    }
}
