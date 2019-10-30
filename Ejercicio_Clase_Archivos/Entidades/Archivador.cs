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

            if (!(path is null) && !(nombreTexto is null))
            {
                if (Directory.Exists(path))
                {
                    StreamWriter aux = new StreamWriter(path + "\\" + nombreTexto + ".txt", sobreescribe);
                    aux.Write(nombreTexto);
                    aux.Close();

                }
                else
                {
                    throw new Exception("Path invalido");
                }
            }
        }
        public static string LeeArchivo(string archivoPath)
        {
            string retorno="";

            if (!(archivoPath is null))
            {
                if (!Directory.Exists(archivoPath))
                {
                    throw new Exception("Archivo invalido");

                }
                else
                {
                    StringReader aux = new StringReader(archivoPath);
                    retorno = aux.ReadToEnd();
                    aux.Close();
                }
            }
            return retorno; 
        }
    }  
}
