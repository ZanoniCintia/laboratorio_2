using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_16
{
    public class Alumno
    {
        #region Atributo
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        private string apellido;
        private int legajo;
        private string nombre;
        #endregion

        public Alumno(string nombre,string apellido,int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;

        }
        public void CalcularFinal()
        {
            Random final = new Random();
            if (this.nota1 >= 4 && this.nota2 >=4)
            {
                
                this.notaFinal= final.Next(1, 11);

            }
            else
            {
                this.notaFinal = -1;
            }
            
        }
        /// <summary>
        /// carga las notas del alumno
        /// </summary>
        /// <param name="notaUno">nota del primer parcial</param>
        /// <param name="notaDos">nota del segundo parcial</param>
        public void Estudiar(byte notaUno,byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public string Mostrar()
        {
            string mostrar = string.Empty;
            mostrar += string.Format("Nombre: {0}\n", this.nombre);
            mostrar += string.Format("Apellido: {0}\n", this.apellido);
            mostrar += string.Format("Legajo:{0}\n", this.legajo);
            mostrar += string.Format("Nota final:{0}\n", this.notaFinal);
            return mostrar;
        }


    }
}
