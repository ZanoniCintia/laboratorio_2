using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejrcicios_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";
            int numero = default(int);
            int i = 0;
            int acumulador = 0;
            int Maximo = default(int);
            int Minimo = default(int);
            int iteraciones = 10;
            //string entrada = string.Empty;

           for(i=0;i<iteraciones;i++)
            {
                //int numero;
                Console.WriteLine("Ingrese un numero  entre -100 y 100");
                while (!int.TryParse(Console.ReadLine(), out numero) || !validacion.validar(numero, -100, 100))
                {
                    Console.WriteLine("ERROR,solo ingrese numeros entre -100 y 100");
                }
                
                    acumulador += numero;
                
                if (i == 0)
                {
                    Maximo = numero;
                    Minimo = numero;
                }
                else if (numero > Maximo)
                {
                    Maximo = numero;
                }
                else if (numero < Minimo)
                {
                    Minimo = numero;
                }

            }
            

            Console.WriteLine("El minimo es :{0} ", Minimo);
            Console.WriteLine("El maximo es :{0} ", Maximo);
            Console.WriteLine("El promedio es :{0} ", acumulador/iteraciones);
            Console.ReadKey();





        }

    }
}