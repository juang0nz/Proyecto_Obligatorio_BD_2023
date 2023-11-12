using System;
using System.Security.Cryptography.X509Certificates;

namespace obligatorio
{
	public class CarnetSalud
	{
		public CarnetSalud()
		{
			public int CI { get; set; }
			public DateTime  FechaEmision { get; set; }
			public DateTime FechaVencimiento { get; set; }
			public string Comprobante { get; set; }
    }
}
}