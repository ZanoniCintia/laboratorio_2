using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace libreria
{
    public class PuestoAtencion
    {
        #region Fields
        private static int numeroActual;
        private Puesto puesto;
        #endregion

        #region Properties
        private static int NumeroActual
       {
            get
            {
                numeroActual += numeroActual;
                return numeroActual;
            }
       }

        #endregion

        #region methods

        public bool Atender(Cliente cli)
        {
            
            Thread.Sleep(3000);
        }

        #endregion

        public enum Puesto
        {
            caja1, caja2

        }
    }

   
}
