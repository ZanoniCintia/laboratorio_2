using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza:Botella
    {
        private const int medida = 330;
        public Tipo tipo = Tipo.Vidrio;

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
            sb.AppendFormat("Tipo: {0} \n", this.tipo);

            return sb.ToString();
        }

        public override int ServirMedida()
        {
            return Contenido - (int)(medida * 0.80);
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
    }
}
