using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQL
{
    public static class DAO
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string connectionString;

        static DAO()
        {
            string connectionString = @"Data source- ./SQLEXPRESS ; Initial Catalog - BDVet; ; Integrated Security = true";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static void InsertarCliente(string nombre, string apellido, string dni)
        {
            try
            {
                connection.Open();
                string comando = string.Format("INSERT INTO CLIENTES (nombre, apellido,dni) VALUES ({0} , {1} , {2} );", nombre, apellido, dni);
                command.CommandText = comando;
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public static void ModificarCliente(int id, string nombre, string apellido, string dni, DateTime? fecha)
        {
            using (SqlConnection connection = new SqlConnection(DAO.connectionString)) ;
            {
                command.Parameters.AddWithValue("@nombre", nombre);
                string comando = ("UPDATE CLIENTES SET nombre = @nombre, apellido =@apellido, dni=@dni, fecha=@fechaNac WHERE id=@id;");
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@fechaNac", fecha);
                command.Parameters.AddWithValue("@dni", dni);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
