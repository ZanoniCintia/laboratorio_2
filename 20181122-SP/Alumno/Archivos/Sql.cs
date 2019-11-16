using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<Queue<Patente>>
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public void Guardar(string tabla, Queue<Patente> datos)
        {
            conexion = new SqlConnection(tabla);
            conexion.Open();
            StringBuilder cadena = new StringBuilder();
            foreach (Patente pat in datos)//datos deberia tener una propiedad para acceder a la lista
            {
                //cadena.AppendFormat("INSERT INTO Votaciones(nombreLey,afirmativos,negativos,abstenciones,nombreAlumno) VALUES('{0}',{1},{2},{3},'DanielaMoreno')", datos.NombreLey, datos.Afirmativo, datos.Negativo, datos.Abstencion);
                //aca fijarse pat. algo
            }

            comando = new SqlCommand(cadena.ToString(), conexion);
            comando.ExecuteNonQuery();
            conexion.Close();

        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            datos=null;
        }

        public Sql()
        {

        }
    }
}
