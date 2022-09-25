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

        protected string Nombre { get => nombre; set => nombre = value; }
        protected string Mail { get => mail; set => mail = value; }
        protected string Contraseña { get => contraseña; }
        protected string Apellido { get => apellido; set => apellido = value; }

        protected Usuario(string nombre, string mail, string contraseña)
        {
            this.nombre = nombre;
            this.mail = mail;
            this.contraseña = contraseña;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre : {this.Nombre}");
            sb.AppendLine($"Mail : {this.Mail}");
            
            return sb.ToString();
        }

    }
}
