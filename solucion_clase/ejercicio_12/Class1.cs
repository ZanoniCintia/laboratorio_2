using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_12
{
    public class ValidarRespuesta
    {
        public static bool validaS_N(char c)
        {
            bool retorno = false;
            if (c == 's' || c=='S')
            {
                retorno=true;
            }
            return retorno;
        }
    }
}
