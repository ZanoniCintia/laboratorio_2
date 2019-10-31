using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class Archivador
    {
        public static void GuardarTexto(string path,bool sobreescribe,string nombreTexto,string texto)
        {
            //using(streamWriter sw= new streamWriter (path)){}

            if (Directory.Exists(path))
            {

                StreamWriter aux = new StreamWriter(path + "\\" + nombreTexto + ".txt", sobreescribe);
                aux.Write(texto);
                
                aux.Close();

            }
            else
            {
                throw new Exception("Ruta Invalida");
            }
            
        }
        public static string LeeArchivo(string archivoPath)
        {
                string retorno="";
            if (File.Exists(archivoPath))
            {
                StringReader aux = new StringReader(archivoPath);
                retorno = aux.ReadToEnd();
                aux.Close();
            }
            
            return retorno;

        }
    }  
}
