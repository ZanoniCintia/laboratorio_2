using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_30
{
        public class VehiculoDeCarrera
        {
            private short cantidadCombustible;
            private bool enCompetencia;
            private string escuderia;
            private short numero;
            private short vueltasRestantes;

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

            public short Numero
            {
                get { return numero; }
                set { numero = value; }
            }

            public string Escuderia
            {
                get { return escuderia; }
                set { escuderia = value; }
            }


            public virtual string MostrarDatos()
            {
                StringBuilder sb = new StringBuilder();
                if (this.enCompetencia)
                {

                    sb.AppendLine("Vehiculo en competencia");
                    sb.AppendFormat("Cantidad de combustible :{0}", this.cantidadCombustible);
                    sb.AppendFormat("Numero : {0}", this.numero);
                    sb.AppendFormat("En competencia :{0}", this.enCompetencia);
                    sb.AppendFormat("Vueltas Restantes :{0}", this.vueltasRestantes);
                    sb.AppendFormat("Escuderia :{0}", this.escuderia);
                }
                else
                {
                    sb.AppendLine("Vehiculo fuera de competencia");
                    sb.AppendFormat("Cantidad de combustible :{0}", this.cantidadCombustible);
                    sb.AppendFormat("Numero : {0}", this.numero);
                    sb.AppendFormat("En competencia :{0}", this.enCompetencia);
                    sb.AppendFormat("Vueltas Restantes :{0}", this.vueltasRestantes);
                    sb.AppendFormat("Escuderia :{0}", this.escuderia);
                }

                return sb.ToString();
            }

            public VehiculoDeCarrera(short numero, string escuderia)
            {
                this.numero = numero;
                this.escuderia = escuderia;
                this.cantidadCombustible = 0;
                this.enCompetencia = false;
                this.vueltasRestantes = 0;

            }
            public static bool operator ==(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
            {
                bool retorno = false;
                if (!(a1 is null) && !(a2 is null))
                {
                    if (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia)
                    {
                        retorno = true;
                    }
                }

                return retorno;
            }

            public static bool operator !=(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
            {
                return !(a1 == a2);
            }




        }
}
