using System;
using MySql.Data.MySqlClient;
namespace obligatorio
{

class Program
{
    static void Main()
    {
        string connectionString = "Server=localhost;Port=3306;Database=obligatorio;User ID=root;Password=bernardo";

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                // Realiza operaciones en la base de datos
                Console.WriteLine("Conexión exitosa!");

                // Ejemplo de consulta
                string query = "SELECT * FROM Funcionarios";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader["Ci"]}, {reader["Nombre"]}");
                            // Procesa los resultados
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


    }
}
}
