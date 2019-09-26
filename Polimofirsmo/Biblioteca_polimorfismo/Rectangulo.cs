using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_polimorfismo
{
    public class Rectangulo:Figura
    {
        private double altura;
        private double Base;

        public Rectangulo(double altura,double Base)
        {
            this.altura = altura;
            this.Base = Base;
        }
        public override string MetodoDibujar()
        {
            return "Dibujando Rectangulo";
        }

        public override double CalcularSuperficie()
        {
            return Base*altura;
        }

        public override double CalcularPerimetro()
        {   
            return (Base+altura)*2;
        }

    }
}
