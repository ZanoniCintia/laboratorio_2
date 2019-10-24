using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_30
{
    public class Competencia
    {
        public enum TipoCompetencia
        {
            F1, MotoCross
        }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { cantidadCompetidores = value; }
        }

        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set { cantidadVueltas = value; }
        }
        public TipoCompetencia Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return competidores[i];
            }
        }

        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantCompetidores;
            this.Tipo = tipo;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Cantidad de competidores :{0}", this.cantidadCompetidores);
            sb.AppendFormat("Cantidad de vueltas :{0}", this.cantidadVueltas);
            sb.AppendFormat("Tipo : {0}", this.tipo);
            return sb.ToString();

        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            bool retorno = false;
            if(!(c is null) && !(a is null))
            {
                foreach(VehiculoDeCarrera vehiculo in c.competidores)
                {
                    if(vehiculo is MotoCross && c.tipo == Competencia.TipoCompetencia.MotoCross)
                    {
                        retorno = true;
                    }
                    else
                    {
                        if(vehiculo is AutoF1 && c.tipo == Competencia.TipoCompetencia.F1)
                        {
                            retorno = true;
                        }
                    }
                }
                
            }
            return retorno;
        }

        public static bool operator !=(Competencia c,VehiculoDeCarrera a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            bool retorno = false;
            if (!(c is null) && !(a is null))
            {
                if (c.cantidadCompetidores > c.competidores.Count && c == a)
                {
                    a.EnCompetencia = true;
                    Random numero = new Random();
                    int aux = numero.Next();
                    a.CantidadCombustible = (short)aux;
                    a.VueltasRestantes = c.cantidadVueltas;
                    c.competidores.Add(a);
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            if (!(c is null) && !(a is null))
            {
                c.competidores.Remove(a);
                retorno = true;
            }
            return retorno;
        }


    }
}
