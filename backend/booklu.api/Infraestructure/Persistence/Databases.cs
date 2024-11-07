using booklu.api.Application.Interfaces.IApplication;
using Npgsql;
using System.Data.SqlClient;

namespace booklu.api.Infraestructure.Persistence
{
    public class MsSqlAdapter : IDatabaseAdapter
    {
        public string Name { get; set; }

        public string StringConnection { get; set; }

        public int Port { get; set; }

        public Connection GetConnection()
        {
            var connectionString = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                Console.WriteLine("Conexión exitosa a la base de datos.");

                string sql = "SELECT * FROM your_table";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0}, {1}", reader[0], reader[1]);
                }

                connection.Close();
            }

            return new Connection();
        }
    }

    public class PostgreSqlAdapter : IDatabaseAdapter
    {
        public string Name { get; set; }

        public string StringConnection { get; set;  }

        public int Port { get; set; }

        public Connection GetConnection()
        {
            var connectionString = "Host=your_host;Username=your_username;Password=your_password;Database=your_database";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                Console.WriteLine("Conexión exitosa a la base de datos.");

                string sql = "SELECT * FROM your_table";
                using (var command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("{0}, {1}", reader[0], reader[1]);
                        }
                    }
                }

                connection.Close();
            }

            return new Connection();
        }
    }

    public class Connection
    {

    }
}
