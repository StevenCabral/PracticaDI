using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDI
{
	public interface ICustomerRepository
	{
		void SaveCustomerData(string nombre, string apellido, int edad);
	}
}
