using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace biblioteca_31
{
    class PuestoAtencion
    {
        #region Fields
        private static int numeroActual;
        private Puesto puesto;
        #endregion

        #region Properties
        public static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }
        #endregion

        #region Methods
        public bool Atender(Cliente cli)
        {
            Thread.Sleep(5000);
            return true;
        }
        static PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        #endregion



        public enum Puesto
        {
            Caja1,
            Caja2
        }
    }
}
