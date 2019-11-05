using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Universidad;

namespace Entidades
{
    public class Jornada
    {
        #region Campos
        private List<Alumno> alumnos;
        private EClases clase;
        private Profesor instructor;

        #endregion

        #region Propiedades

        #endregion

        #region Metodos
        public bool Guardar(Jornada jornada)
        {
            
        }

        private Jornada()
        {
            List<Alumno> alumnos = new List<>;
        }
        public Jornada(EClases clase,Profesor instructor)
        {

        }
        #endregion
    }
}
