using System;
namespace obligatorio
{ 
public class PeriodosActualizacion
{
	public PeriodosActualizacion()
	{
        public string Año { get; set; }
        public string Semestre { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
    }
    // Método para verificar si el periodo de actualización está vigente
    public bool EstaVigente()
    {
        // Lógica para verificar si el periodo de actualización está vigente
        // Puedes comparar la fecha actual con Fch_Inicio y Fch_Fin.
        // Retorna true si está vigente, false si no lo está.
    }

    // Método para modificar las fechas de inicio y fin del periodo de actualización
    public void ModificarFechas(DateTime nuevaFechaInicio, DateTime nuevaFechaFin)
    {
        // Lógica para modificar las fechas de inicio y fin del periodo de actualización
        Fch_Inicio = nuevaFechaInicio;
        Fch_Fin = nuevaFechaFin;

        // Actualiza la información en la base de datos utilizando Entity Framework Core
    }
}
}
}