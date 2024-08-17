using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDI
{
	public class CustomerRepository : ICustomerRepository
	{
		public void SaveCustomerData(string nombre, string apellido, int edad)
		{
	
			Console.WriteLine($"Datos del cliente guardados:  {nombre} {apellido}, Edad: {edad}");
		}
	}
}
