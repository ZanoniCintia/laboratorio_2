using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario:Persona
    {
        #region Campos
        private int legajo;
        #endregion

        #region Metodos
        public  override bool  Equals(object obj)
        {
            return true;//preguntar
        }

        protected virtual string MostrarDatos()
        {
            return base.ToString();
        }

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool retorno = false;
            if (pg1.legajo == pg2.legajo && pg1.DNI == pg2.DNI)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        protected abstract string ParticiparEnClase();

        public Universitario()
        {

        }
        public Universitario(int legajo,string nombre,string apellido, string dni,ENacionalidad nacionalidad)
            :base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

    }
}
