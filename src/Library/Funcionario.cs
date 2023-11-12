using System;
using MySql.Data.MySqlClient;
namespace obligatorio
{

	public class Funcionario 
	{
		public Funcionario()
		{
            public int Ci { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public DateTime Fch_Nacimiento { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
            public int LogId { get; set; }
        }
    }
}