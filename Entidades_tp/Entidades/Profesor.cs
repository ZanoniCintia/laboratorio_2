using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;


namespace Entidades
{
    public sealed class Profesor : Universitario
    {
        static Queue<Universidad.EClases> ClasesDelDia;
        static Random random;

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CLASE DEL DIA : {0}", Universidad.EClases.Laboratorio);
            //terminar hacer bien
            return sb.ToString();
        }

        static Profesor()
        {
            random = new Random();
        }
        private void _RandomClases()
        {
            

        }

        protected override string MostrarDatos()
        {
            return base.ToString();
        }

        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            
        }
        public static bool operator !=(Profesor i,Universidad.EClases clase)
        {
            return !(i == clase);
        }

    }
}
