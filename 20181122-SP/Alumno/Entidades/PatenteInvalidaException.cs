using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PatenteInvalidaException:Exception
    {
       // private const string mensajeBase = "No cumple el formato";


        public PatenteInvalidaException(string msg) : this(msg,null)
        {

        }

        public PatenteInvalidaException(string msg, Exception e) : base(msg, e)
        {

        }

        
    }
}
