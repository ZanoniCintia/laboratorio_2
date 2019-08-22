using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double acumulador = 0;
            int maximo=0;
            int minimo=0;

            for(int i=0; i<5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
               numero= Convert.ToInt32(Console.ReadLine());
               if(i==0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                if(numero > maximo)
                {
                    maximo = numero;
                }else if( numero < maximo)
                {
                    minimo = numero;
                }
                acumulador += numero;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Maximo : {0}", maximo);
            Console.WriteLine("Minimo : {0}", minimo);
            Console.WriteLine("Promedio : {0}", acumulador / 5);

            Console.ReadKey();

        }
    }
}
