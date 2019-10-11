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
        protected string Marca;
        #endregion

        #region Propiedades


        public int CapacidadLitros
        {
            get { return (capacidadML)/1000; }
            
        }



        public int Contenido
        {
            get { return Contenido; }
            set { contenidoML = value; }
        }



        public int PorcentajeContenido
        {
            get
            {


                return PorcentajeContenido;
            } ///terminar
            set { PorcentajeContenido = value; }
        }

        #endregion

        #region Metodos
        protected  Botella(string marca,int capacidadML,int contenidoML)
        {
            this.Marca = marca;
            this.capacidadML = capacidadML;
            this.contenidoML = contenidoML;


        }

        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Capacidad : {0}",this.capacidadML );
            sb.AppendFormat("Contenido : {0} ",this.contenidoML );
            sb.AppendFormat("Marca: {0}", this.Marca);

            return sb.ToString();
        }

        public string ToString()
        {
            return GenerarInforme();
            
        }

      /*  public abstract int ServirMedida()
        {
            return 
        }*/
        #endregion

        public enum Tipo
        {
            Plastico,
            Vidrio
        }
            
    }
}
