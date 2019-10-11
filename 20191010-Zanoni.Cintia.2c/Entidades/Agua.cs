using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        const int Medida=40;

        public Agua(string marca,int capacidadML ,int contenidoML): base (marca,capacidadML,contenidoML)
        {

        }

        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("AGUA");
            sb.AppendFormat(base.GenerarInforme());
            
            return sb.ToString();

        }
        public int ServirMedida(int medida)
        {
            
        }

        public int ServirMedida()
        {
            if (Medida <= contenidoML)
            {
                 ;

            }
            else if (Medida > contenidoML)
            {
                 ;
            }
            return ;
        }
        
        
    }
}
