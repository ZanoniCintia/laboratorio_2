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
            Euro e = new Euro(10);
            Dolar d = new Dolar(10);
            Pesos p = new Pesos(10);

            Dolar auxe = d + e;
            Console.WriteLine("Euro +Dolar  : {0:#.00}",auxe.GetCantidad());
            Pesos aux2 = p + e;
            Console.WriteLine("Euro + Pesos : {0:#.00}", aux2.GetCantidad());
            Console.ReadKey();
        }
    }
}
