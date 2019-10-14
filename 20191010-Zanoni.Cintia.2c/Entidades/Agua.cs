using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        private const int medida=40;

        public Agua(string marca,int capacidadML ,int contenidoML): base (marca,capacidadML,contenidoML)
        {

        }

        protected override string GenerarInforme()
        {
            
            return base.ToString();

        }
        public int ServirMedida(int medida)
        {
            return contenidoML - medida;
        }

        public override int ServirMedida()
        {
            if (medida >= Contenido)
            {
                Contenido=Contenido-medida ;

            }
            else if (medida > Contenido)
            {
                Contenido=Contenido-Contenido ;
            }
            return Contenido;
        }
        
        
    }
}
