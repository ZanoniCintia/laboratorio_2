using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_polimorfismo
{
    public sealed class Circulo:Figura
    {
        private float radio;
        
        public Circulo(float radio)
        {
            this.radio = radio;
        }
        public override string MetodoDibujar()
        {
            return "Dibujando Circulo";
        }

        public override double CalcularSuperficie()
        {
            return (2*3.14f)*radio;
        }

        public override double CalcularPerimetro()
        {
           return (radio*radio)*3.14f ;
        }

    }
}
