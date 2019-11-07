using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DAO.InsertarCliente("Joe", "Morello", "52917868","13/01/19");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
