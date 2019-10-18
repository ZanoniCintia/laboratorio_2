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
                return (contenidoML* 100)/capacidadML;
            } 
            
        }

        #endregion

        #region Metodos
        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.marca = marca;
            if (contenidoML <= capacidadML)
            {
                this.capacidadML = capacidadML;
                this.contenidoML = contenidoML;
            }
            else
            {
                this.contenidoML = capacidadML;
                this.capacidadML = capacidadML;
            }


        }

        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Capacidad : {0}\n",this.capacidadML );
            sb.AppendFormat("Contenido : {0} \n", this.contenidoML );
            sb.AppendFormat("Marca: {0}\n", this.marca);
            sb.AppendFormat("Porcentaje contenido : {0} %", this.PorcentajeContenido);

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
