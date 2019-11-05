using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        #region Campos
        private string nombre;
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        #endregion

        #region Propiedades
        public string Apellido
        {
            get
            {
                Regex aux = new Regex(@"^[a-zA-Z]+$");
                if (!aux.IsMatch(apellido))
                {
                    Console.WriteLine("Debe ingresar solo letras");
                }
                return this.apellido;
            }
            set { apellido = value; }
        }

        public int DNI
        {
            get
            {
                return this.dni;
            }
            set { dni = value; }
        }

        public ENacionalidad Nacionalidad
        {
            get
            {              
                return this.nacionalidad;
            }
            set { nacionalidad = value; }
        }

        public string Nombre
        {
            get
            {
                Regex aux = new Regex(@"^[a-zA-Z]+$");
                if (!aux.IsMatch(nombre))
                {
                    Console.WriteLine("Debe ingresar solo letras"); 
                }
                return this.nombre;
               
            }
            set { nombre = value; }
        }

        public string StringToDni//preguntar
        {
            
            set {  value= dni.ToString(); }
        }


        #endregion

        #region Metodos
        public Persona()
        {
            

        }
        public Persona(string nombre,string apellido, ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni,
            ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.dni = dni;
        }

        public Persona(string nombre, string apellido, string dni,
            ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {

           // this.dni = dni;
        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int retorno = 0;
            if ((dato >= 1 && dato <= 89999999) && (nacionalidad==ENacionalidad.Argentino))
            {
                retorno = dato;

            } else if((dato >= 90000000 && dato <= 99999999) && (nacionalidad == ENacionalidad.Extranjero))
            {
                retorno = dato;
            }
            else { //lanzar excepcion
            }
           
            return retorno;
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno = 0;
            int datoInt;
            if(int.TryParse(dato, out datoInt) && dato.Length <= 8)
            {
                retorno = ValidarDni(nacionalidad, datoInt);
            }
            else
            {
                //lanzar excepcion
            }
            return retorno;
        }

        public new string  ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre : {0}", nombre);
            sb.AppendFormat("Apellido : {0}", apellido);
            sb.AppendFormat("DNI : {0}", dni);
            sb.AppendFormat("Nacionalidad : {0}", nacionalidad);

            return sb.ToString();

        }
        #endregion





        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
    }
}
