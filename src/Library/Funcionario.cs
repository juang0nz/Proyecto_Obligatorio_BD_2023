using System;
using MySql.Data.MySqlClient;
namespace obligatorio
{

	public class Funcionario 
	{
        //constructor
		public Funcionario()
		{
            public int Ci { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string FechaNacimiento { get; set; }
            public string Direccion { get; set; }
            public int Telefono { get; set; }
            public string Email { get; set; }
            public string LogId { get; set; }
        }

    // Método para verificar si el funcionario tiene el carné de salud vigente
        public bool TieneCarnetVigente()
        {
        // Lógica para verificar la vigencia del carné de salud
        // Puedes comparar la fecha actual con Fch_Vencimiento, por ejemplo.
        // Retorna true si está vigente, false si no lo está.
          return bool
        }
        // Método para cargar datos del funcionario desde la base de datos
        public static string ObtenerFuncionarioPorCi(int ci)
        {
            // Lógica para obtener un funcionario de la base de datos por su CI
            // Utiliza Entity Framework Core u otro método de acceso a datos.
            // Retorna un objeto Funcionario o null si no se encuentra.
            return string
        }
}
}