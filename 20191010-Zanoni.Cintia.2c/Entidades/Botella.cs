using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        #region Campos
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;
        #endregion

        #region Propiedades


        public int CapacidadLitros
        {
            get { return (capacidadML)/1000; }
            
        }



        public int Contenido
        {
            get { return contenidoML; }
            set { contenidoML = value; }
        }



        public int PorcentajeContenido
        {
            get
            {
                return (contenidoML*capacidadML)/100;
            } 
            
        }

        #endregion

        #region Metodos
        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.marca = marca;
            if (contenidoML < capacidadML)
            {
                this.capacidadML = capacidadML;
                this.contenidoML = contenidoML;
            }
            else if (capacidadML < contenidoML)
            {
                this.contenidoML = capacidadML;
                this.capacidadML = capacidadML;
            }


        }

        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Capacidad : {0}",this.capacidadML );
            sb.AppendFormat("Contenido : {0} ",this.contenidoML );
            sb.AppendFormat("Marca: {0}", this.marca);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.GenerarInforme();
            
        }

        public abstract int ServirMedida();
      
        #endregion

        public enum Tipo
        {
            Plastico,
            Vidrio
        }
            
    }
}
