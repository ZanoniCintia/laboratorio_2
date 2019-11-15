using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
    
        public class Texto : IArchivo<string>
        {
            public void Guardar(string archivo, string datos)
            {
                try
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(archivo, true))
                    {
                        file.WriteLine(datos);
                    }

                    
                }
                catch (Exception)
                {
                    
                }
            }
            public void Leer(string archivo, out string datos)
            {
                try
                {
                    using (System.IO.StreamReader file = new System.IO.StreamReader(archivo))
                    {
                        datos = file.ReadToEnd();
                    }

                    
                }
                catch (Exception)
                {
                    datos = "";
                    
                }
            }
        }

    
}
