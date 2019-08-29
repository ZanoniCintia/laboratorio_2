using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 12";
            int numero = default(int);
            int acumulador = 0;
            char respuesta = 'n';
            do
            {
                Console.WriteLine("Ingrese un numero entero");
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("ERROR,solo ingrese numeros enteros");
                }
                acumulador += numero;
                Console.WriteLine("Desea continuar? s/n");
            } while (ValidarRespuesta.validaS_N(respuesta));

            Console.WriteLine("La suma de todos los numeros ingresados es :{0} ", acumulador);
        }
    }
}
