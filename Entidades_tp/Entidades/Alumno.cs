using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Entidades
{
    sealed class Alumno: Universidad
    {
        #region Campos
        private EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #endregion






        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
        
    }
}
