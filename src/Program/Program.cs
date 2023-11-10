using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Server=localhost;Database=obligatorio;User ID=root;Password=bernardo";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                // Realiza operaciones en la base de datos
                Console.WriteLine("Conexión exitosa!");

                // Ejemplo de consulta
                string query = "SELECT * FROM TuTabla";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader["Columna1"]}, {reader["Columna2"]}");
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
