using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = default(int);
            string entrada = string.Empty;
            int cubo=0;
            int cuadrado = 0;

            Console.WriteLine("Ingrese un numero");
            entrada = Console.ReadLine();
            Int32.TryParse(entrada, out numero);


            if(numero<=0)
            {
                Console.WriteLine("Erros! ingreses mayor un numero mayor a cero");
            }else if(numero>0)
            {
                cuadrado = (int)Math.Pow(numero, 2);
                cubo =(int) Math.Pow(numero, 3);
                Console.WriteLine("el cuadrado es {0}  ", cuadrado);
                Console.WriteLine("el cubo es {0}  ", cubo);
            }
            Console.ReadKey();





        }
    }
}
