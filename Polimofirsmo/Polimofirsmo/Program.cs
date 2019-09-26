using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_polimorfismo;

namespace Polimofirsmo
{
    class Program
    {
        static void Main(string[] args)
        {
            List < Figura > figuras = new List<Figura>();

            figuras.Add(new Circulo(2));
            figuras.Add(new Cuadrado(3));
            figuras.Add(new Rectangulo(4,8));



        }
    }
}
