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

        protected new string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CERVEZA");
            sb.AppendFormat(base.GenerarInforme()); 
            sb.AppendFormat("Tipo: {0} \n", this.tipo);

            return sb.ToString();
        }

        public override int ServirMedida()
        {
            int retorno;
            if (medida <= Contenido)
            {
                Contenido = Contenido - (medida * 80)/100;
                retorno = medida;

            }
            else
            {
                Contenido = Contenido - Contenido;
                retorno = Contenido;
            }
            return retorno;
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
    }
}
