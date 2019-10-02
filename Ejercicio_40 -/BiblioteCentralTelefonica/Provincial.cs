using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioteCentralTelefonica
{
    public class Provincial : Llamada
    {
        #region Fields
        protected Franja franjaHoraria;

        #endregion

        #region Properties
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        #endregion

        #region Methods
        private float CalcularCosto()
        {
            float retorno = 0;
            float costo = 0;
            switch (this.franjaHoraria)
            {
                

                case Franja.Franja_1:
                costo = 0.99f ;
                break;

                case Franja.Franja_2:
                costo = 1.25f;
                break;
                case Franja.Franja_3:
                costo = 0.66f;
                break;

                
            }
            retorno = costo * base.duracion;
            return retorno; 
        }

        protected new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
           
            sb.AppendLine("Provincial**");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("costo : {0} ", this.CostoLlamada);
            sb.AppendFormat("Franja horaria :{0}", this.franjaHoraria);

            return sb.ToString();

        }
        public Provincial(Franja miFranja,Llamada llamada):this(miFranja ,llamada.NroOrigen,llamada.Duracion,llamada.NroDestino)
        {

        }
        public Provincial(Franja miFranja, string origen, float duracion,string destino):base(duracion,destino,origen)
        {

        }
        #endregion

        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj != null)
            {
                if(obj is Provincial)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            return base.Mostrar();
        }
    }

}
