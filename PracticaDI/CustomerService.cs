using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDI
{
	public class CustomerService
	{
		private readonly ICustomerRepository _customerRepository;

		
		public CustomerService(ICustomerRepository customerRepository)
		{
			_customerRepository = customerRepository;
		}

		public void ProcessCustomerData()
		{
			Console.WriteLine("Ingrese el nombre del cliente:");
			string nombre = Console.ReadLine();

			Console.WriteLine("Ingrese el apellido del cliente:");
			string apellido = Console.ReadLine();

			Console.WriteLine("Ingrese la edad del cliente:");
			int edad;
			while (!int.TryParse(Console.ReadLine(), out edad))
			{
				Console.WriteLine("Por favor, ingrese una edad válida.");
			}

			_customerRepository.SaveCustomerData(nombre, apellido, edad);
		}
	}

}
