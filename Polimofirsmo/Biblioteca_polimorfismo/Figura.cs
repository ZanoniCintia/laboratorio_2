using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_polimorfismo
{
    public abstract class Figura
    {
        public virtual string MetodoDibujar()
        {
            return "Dibujando forma";
        }
        public abstract double CalcularSuperficie();
        public abstract double CalcularPerimetro();
        
    }
}
