using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioteCentralTelefonica
{
    public class Local :Llamada
    {
        #region Fields
        protected float costo;

        #endregion

        #region Properties
        public float CostoLLamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion 

        #region Methods

        private float CalcularCosto()
        {
            float valor = this.duracion * this.costo;

            return valor;
        }


        #endregion

        public Local(Llamada llamada,float costo):this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {

        }
        public Local(string origen,float duracion,string destino,float costo):base(duracion,destino,origen)
        {
            this.costo=costo;

        }
        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**Local**");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("costo : {0}", this.costo);

            return sb.ToString();
        }
    }
}
