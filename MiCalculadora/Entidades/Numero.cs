using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;
        
        public string SetNumero
        {
            
            set { numero = ValidarNumero( value); }
        }


        /// <summary>
        /// Constructor asigna 0 al atributo numero
        /// </summary>
        public Numero()
        {
            numero = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// recibe un string y lo convierte en double
        /// </summary>
        /// <param name="strNum"></param>
        public Numero(string strNum)
        {
            double.TryParse(strNum, out numero);
        }



        /// <summary>
        /// valida que el numero ingresado sea numerico,retorna un double, caso contrario un 0
        /// </summary>
        /// <param name="StrNumero"></param>
        /// <returns></returns>
        private static double ValidarNumero(string StrNumero)
        {
            double retorno;
            if (!double.TryParse(StrNumero, out retorno))
            {
                retorno = 0;
            }
            return retorno;
        }

        #region Operadores

        /// <summary>
        /// retorna la diferencia entre n1 y n2
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return (n1.numero - n2.numero);
        }

        /// <summary>
        /// retorna la suma de n1 y n2
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return (n1.numero + n2.numero);
        }

        /// <summary>
        /// retorna la multiplicacion entre n1 y n2
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return (n1.numero * n2.numero);
        }

        /// <summary>
        /// si n2 es distinto de cero retorna la division entre n1 y n2, de lo contrario retorna double.MinValue
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = double.MinValue;
            if (n2.numero != 0)
            {
                retorno = n1.numero / n2.numero;
            }
           
            return retorno;
        }


        #endregion

        #region Conversores

        /// <summary>
        /// convierte un numero binario a decimal. caso contrario retorna invalido
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor invàlido";
            long StrNum = Convert.ToInt64(binario, 2);
            double n = BitConverter.Int64BitsToDouble(StrNum);
            retorno = Convert.ToString(n);
            return retorno;

        }

        //hacer
        public string DecimalBinario(double numero)
        {
            return 0;
        }



        #endregion
    }
}
