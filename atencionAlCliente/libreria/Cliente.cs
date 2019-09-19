using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    public class Cliente
    {
        #region Fields
        private string nombre;
        private int numero;
        #endregion

        #region Properties
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre=nombre;
            }
        }
        public int Numero
        {
            get
            {
                return numero;
            }
        }
       

        #endregion

        #region Methods
        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero,string nombre):this(numero)
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;

        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        #endregion




    }
}
