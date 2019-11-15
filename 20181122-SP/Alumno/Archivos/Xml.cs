using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Data.SqlClient;
namespace Archivos

{
    public class Xml <T>:IArchivo<T>
    {
        public void  Guardar(string nombre, T datos)
        {
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(nombre, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                //TextWriter writer = new StreamWriter(archivo);
                serializer.Serialize(writer, datos);

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            finally
            {
                if (!object.ReferenceEquals(writer, null))
                    writer.Close();
            }
        }
        public void Leer(string nombre, out T datos)
        {
            XmlTextReader read = null;
            try
            {
                read = new XmlTextReader(nombre);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                //TextReader writer = new StreamReader(archivo);
                datos = (T)serializer.Deserialize(read);
                read.Close();

                
            }
            catch (Exception)
            {
                datos = default(T);
                
            }
            finally
            {
                if (!object.ReferenceEquals(read, null))
                    read.Close();
            }
        }
    }
}

