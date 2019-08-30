using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_16

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 16";
            string entrada = string.Empty;
            
            //instancio e inicializo campos del alumno
            Alumno alumno1 = new Alumno("Carolina", "Stomboli", 22);
            Alumno alumno2 = new Alumno("Daniela", "Moreno", 26);
            Alumno alumno3 = new Alumno("Matias", "Moll", 27);

            //cargo las notas con el metodo estudiar
            alumno1.Estudiar(3, 8);
            alumno2.Estudiar(4, 6);
            alumno3.Estudiar(4, 6);

            //genero la nota final
            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            //mostrar los datos
            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());
            Console.ReadKey();



        }
    }
}
