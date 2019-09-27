using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioteCentralTelefonica
{
    public abstract class Llamada
    {
        #region Fields
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region Properties

        public abstract float CostoLlamada
        {
            get;
            
        }

        public float Duracion
        {
            get
            {
                return duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }
        #endregion

        #region Methods
        public Llamada(float duracion,string nroDestino,string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
           
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Duracion: {0}", duracion);
            sb.AppendFormat("NUmero destino: {0} ",nroDestino);
            sb.AppendFormat("Numero origen: {0}",nroOrigen);

            return sb.ToString();

        }

        public static int OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
        {
            int retorno = 0;
            if(llamada1.duracion<llamada2.duracion)
            {
                retorno = -1;
            }
            else if(llamada1.duracion > llamada2.duracion)
                {
                retorno = 1;
                }




            return retorno;
        }

        public static bool operator ==( Llamada l1,Llamada l2)
        {
            bool retorno = false;
            if (l1.Equals(l2) && l1.nroDestino == l2.nroDestino && l1.nroOrigen == l2.nroOrigen)
            {
                retorno = true;
            }
            return retorno;

        }
        public static bool operator !=(Llamada l1,Llamada l2)
        {
            return !(l1 == l2);
        }
        #endregion

        #region Nested TYpes
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
        #endregion

    }
}
