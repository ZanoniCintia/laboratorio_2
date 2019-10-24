using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_30
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVuelta;
        private List<AutoF1> competidores;

        private Competencia()
        {
            List<AutoF1> competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas,short cantidadCompetidores):this()
        {
            this.cantidadVuelta = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Competidores : " + competidores);
            sb.AppendLine("Cantidad de competidores : " + cantidadCompetidores);
            sb.AppendLine("Cantidad de vueltas : " + cantidadVuelta);
            return sb.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            Random aux = new Random();
            int num = aux.Next(15, 100);
            if(!(c is null) && !(a is null))
            {
                if (!c.competidores.Contains(a) && c.cantidadCompetidores > c.competidores.Count)
                {
                    c.competidores.Add(a);
                    a.EnCompetencia = true;
                    a.VueltasRestantes = c.cantidadVuelta;
                    a.CantidadCombustible = (short)num;

                    retorno = true;
                }
            }
            return retorno;
            
        }

        public static bool operator ==(Competencia c,AutoF1 a)
        {
            bool retorno = true;
            if(!(c is null) && !(a is null))
            {
                if(c==a)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
    }
}
