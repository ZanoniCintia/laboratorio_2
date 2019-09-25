using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_31
{
    class Negocio
    {
        #region Fields
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        #endregion

        #region Properties

        public Cliente Cliente
        {
            get { return clientes.Dequeue(); }
            set {  clientes.Enqueue(value); }
        }

        #endregion

        #region Methods
        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            this.clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }
        #endregion
    }
}
