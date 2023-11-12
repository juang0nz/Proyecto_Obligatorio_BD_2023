using System;
using System.Security.Cryptography.X509Certificates;

namespace obligatorio
{
	public class CarnetSalud
	{
		public CarnetSalud()
		{
			public int CI { get; set; }
			public string  FechaEmision { get; set; }
			public string FechaVencimiento { get; set; }
			public string Comprobante { get; set; }
		 }
    // Método para verificar si el carné de salud está vigente
        public bool EstaVigente()
        {
            // Lógica para verificar la vigencia del carné de salud
            // Puedes comparar la fecha actual con Fch_Vencimiento, por ejemplo.
            // Retorna true si está vigente, false si no lo está.
        }

        // Método para renovar el carné de salud
        public void RenovarCarnet(string nuevaFechaEmision, string nuevaFechaVencimiento, string nuevoComprobante)
        {
            // Lógica para renovar el carné de salud
            FechaEmision = nuevaFechaEmision;
            FechaVencimiento = nuevaFechaVencimiento;
            Comprobante = nuevoComprobante;

            // Actualiza la información en la base de datos utilizando Entity Framework Core
        }

        // Método para adjuntar un nuevo comprobante al carné de salud
        public void AdjuntarComprobante(string nuevoComprobante)
        {
            // Lógica para adjuntar un nuevo comprobante al carné de salud
            Comprobante = nuevoComprobante;

            // Actualiza la información en la base de datos utilizando Entity Framework Core
        }

}
}