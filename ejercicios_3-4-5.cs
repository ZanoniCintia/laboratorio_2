using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 5";
            int numero = default(int);
            int i = 0;
            int acumulador = 0;
            int centroNumerico;
            int acumuladorDecreciente = 0;
            string entrada = string.Empty;

            Console.WriteLine("Ingrese un numero");
            entrada = Console.ReadLine();

            if (!Int32.TryParse(entrada, out numero) || numero < 0)
            {
                Console.WriteLine("ERROR,ingrese un numero mayor a cero");
            }
            else
            {
                for( i = numero-1;i>0;i-- )
                {
                    
                    acumuladorDecreciente += i;
                    
                }
                for (int j = numero+1; acumulador<=acumuladorDecreciente ; j++)
                {
                    acumulador += j;
                    if (acumuladorDecreciente == acumulador)
                    {
                        centroNumerico = numero;
                        Console.WriteLine("el numero {0} es un centro numerico", centroNumerico);
                    }


                }









            }

            Console.ReadKey();
        }
    }
}
