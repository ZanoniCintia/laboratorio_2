using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Biblioteca_68
{
    public class Persona
    {
        private string apellido;
        private string nombre;
        private event DelegadoString EventoString;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Persona()
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre :{0}",this.Nombre);
            sb.AppendFormat("Apellido :{0}",this.Apellido);
            return sb.ToString();
        }


    }

    public delegate string DelegadoString(string msg);
}