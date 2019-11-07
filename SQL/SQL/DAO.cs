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
        private static SqlConnection conection;
        private static SqlCommand command;
        private static string connectionString;

        static DAO()
        {
            connectionString = @"Server= ./SQLSERVER; Database= dboMascotas; Trusted_connection= true; ";        //data trae la instancia del servidor, Initial: El nombre de la base de datos, segurity loguearte con la 
            conection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = conection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static void InsertarCliente(string nombre, string apellido, string dni, string fecha)
        {
            try
            {
                conection.Open();
                string comando = String.Format("INSERT INTO CLIENTES (nombre, apellido, dni) " + "VALUES ('{0}','{1}','{2}'); ", nombre, apellido, dni);
                command.CommandText = comando;
                command.ExecuteNonQuery();
            }
            finally
            {
                if (conection != null && conection.State == System.Data.ConnectionState.Open)
                {
                    conection.Close();
                }

            }

        }

        //si le pongo un signo de pregunta ? al final, acepta null
        public static void ModificarCliente(int id, string nombre, string apellido, string dni, DateTime? fecha)
        {
            //Liberar el recurso, pase lo que pase, adentro de los parentesis lo q quiero liberar
            // Esto es para no hacer el close
            using (SqlConnection connection = new SqlConnection(DAO.connectionString))
            {
                string comando = String.Format("UPDATE CLIENTES SET =@nombre, " + " apellido =@apellido, dni=@dni, fechaNacimiento=@fechaNacimiento "
                    + "WHERE id=@id");
                SqlCommand command = new SqlCommand(comando, connection);
                command.Parameters.AddWithValue("@nombre", nombre); //esto es para seguridad, de la informacion que ingresan!
                command.Parameters.AddWithValue("@nombre", apellido);
                command.Parameters.AddWithValue("@nombre", dni);
                command.Parameters.AddWithValue("@nombre", fecha);
                command.Parameters.AddWithValue("@id", id);
                conection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
    /* private static SqlConnection connection;
     private static SqlCommand command;
     private static string connectionString;

     static DAO()
     {
         /*string connectionString = @"Data source- ./SQLEXPRESS ; Initial Catalog - BDVet; ; Integrated Security = true";
         connection = new SqlConnection(connectionString);
         command = new SqlCommand();
         command.Connection = connection;
         command.CommandType = System.Data.CommandType.Text;*/
    /*  connectionString = @"Server= ./SQLSERVER; Database= dboMascotas; Trusted_connection= true; ";        //data trae la instancia del servidor, Initial: El nombre de la base de datos, segurity loguearte con la 
      connection = new SqlConnection(connectionString);
      command = new SqlCommand();
      command.Connection = connection;
      command.CommandType = System.Data.CommandType.Text;
  }*/

    /*   public static void InsertarCliente(string nombre, string apellido, string dni)
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
       }*/

    /*public static void ModificarCliente(int id, string nombre, string apellido, string dni, DateTime? fecha)
    {
        using (SqlConnection connection = new SqlConnection(DAO.connectionString))

            //command.Parameters.AddWithValue("@nombre", nombre);
            //string comando = string.Format("UPDATE CLIENTES SET nombre = @nombre, apellido = @apellido, dni = @dni, fecha=@fechaNac,id=@id);";
        string comando = String.Format("UPDATE CLIENTES SET =@nombre, " + " apellido =@apellido, dni=@dni, fechaNacimiento=@fechaNacimiento "
                 + "WHERE id=@id;");
        SqlCommand command = new SqlCommand(comando, connection);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@apellido", apellido);
            command.Parameters.AddWithValue("@fechaNac", fecha);
            command.Parameters.AddWithValue("@dni", dni);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();

    }
}*/
}
