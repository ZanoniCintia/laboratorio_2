using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejrcicios_clase
{
    public class validacion
    {
        public static bool validar(int valor, int min, int max)
        {
           
            if(valor < min || valor > max)
            {
                return false;
            }
           
            return true;
        }
    }
}
