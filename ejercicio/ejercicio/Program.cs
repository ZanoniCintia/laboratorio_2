using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro e = new Euro(10,1.16);
            Dolar d = new Dolar(10);
            Pesos p = new Pesos(10,38.33);

            Euro auxe = e + d;
            Console.WriteLine("Euro + Dolar  : {0:#.00}",auxe.GetCantidad());
            auxe = e + p;
            Console.WriteLine("Euro + Pesos : {0:#.00}", auxe.GetCantidad());

            Console.ReadKey();
        }
    }
}
