using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza:Botella
    {
        const int Medida = 330;
        private Tipo tipo;

        public Cerveza (int capacidadML,string marca,int contenidoML):base(marca,capacidadML,contenidoML)
        {

        }

        public Cerveza(int capacidadML,string marca,Tipo tipo,int contenidoML):this(capacidadML,marca,contenidoML)
        {
            this.tipo = tipo;
        }

        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CERVEZA");
            sb.AppendFormat(base.GenerarInforme());

            return sb.ToString();
        }

        public int ServirMedida()
        {

        }
    }
}
