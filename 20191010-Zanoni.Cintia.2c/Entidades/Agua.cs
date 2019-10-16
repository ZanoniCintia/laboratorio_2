using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        private const int medida=400;

        public Agua(string marca,int capacidadML ,int contenidoML): base (marca,capacidadML,contenidoML)
        {

        }

        protected new string GenerarInforme()
        {
            
            return base.ToString();

        }
        public int ServirMedida(int medida)
        {
            int retorno;
            if (medida <= Contenido)
            {
               Contenido = Contenido - medida;
               retorno = medida;
            }
            else
            {
                Contenido = Contenido - Contenido;
                retorno = Contenido;
            }
            return retorno;
            
        }

        public override int ServirMedida()
        {
            return ServirMedida(medida);
        }
        
        
    }
}
