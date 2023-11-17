using System;
using System.Security.Cryptography.X509Certificates;

namespace obligatorio
{
    public class Agenda		
{
	public Agenda()
	{
		public int Numero { get; set; }
		public int CI { get; set; }
		public string FechaAgenda { get; set; }
    }
    // Método para agregar una nueva cita a la agenda
    public static void AgregarCita(int ci, String fechaAgenda)
    {
        // Lógica para agregar una nueva cita a la base de datos
        // Utiliza Entity Framework Core u otro método de acceso a datos.
    }

    // Método para obtener todas las citas de un funcionario
    public static List<Agenda> ObtenerCitasPorCi(int ci)
    {
        // Lógica para obtener todas las citas de un funcionario de la base de datos
        // Utiliza Entity Framework Core u otro método de acceso a datos.
        return new List<Agenda>(); // Retorna la lista de citas
    }

    // Método para eliminar una cita de la agenda
    public void EliminarCita()
    {
        // Lógica para eliminar la cita de la base de datos
        // Utiliza Entity Framework Core u otro método de acceso a datos.
    }

}
}