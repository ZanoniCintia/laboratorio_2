using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona()
        {

        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static  bool  Guardar(Persona p)
        {
            Persona persona = new Persona();

            XmlTextWriter Writer;
            XmlSerializer ser;
            Writer = new XmlTextWriter(,Encoding.UTF8);
            ser = new XmlSerializer(typeof(Persona));

            ser.Serialize(Writer, p);

            Writer.Close();

            return true;

        }
    }
}
