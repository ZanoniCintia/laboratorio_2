using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_30
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;

        }

        public short CantidadCombustible
        {
            get { return cantidadCombustible; }
            set { cantidadCombustible = value; }
        }
        public bool EnCompetencia
        {
            get { return enCompetencia; }
            set { enCompetencia = value; }
        }
        public short VueltasRestantes
        {
            get { return vueltasRestantes; }
            set { vueltasRestantes = value; }
        }





        public string mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Cantidad de combustible :{0}", cantidadCombustible);
            sb.AppendFormat("Numero : {0}", numero);
            sb.AppendFormat("En competencia :{0}", enCompetencia);
            sb.AppendFormat("Vueltas Restantes :{0}", vueltasRestantes);
            sb.AppendFormat("Escuderia :{0}", escuderia);
            return sb.ToString();
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;
            if (a1.escuderia == a2.escuderia && a1.numero == a2.numero )
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }


    }
}
