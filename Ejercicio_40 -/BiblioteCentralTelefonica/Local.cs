using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioteCentralTelefonica
{
    public class Local : Llamada
    {
        #region Fields
        protected float costo;

        #endregion

        #region Properties
        public override float CostoLlamada
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
        protected new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**Local**");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Costo llamada: " + CostoLlamada.ToString());


            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (!(obj is null))
            {
                if (obj is Local)
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
