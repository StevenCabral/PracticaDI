using PracticaDI;

public class Program
{
	public static void Main(string[] args)
	{
		
		ICustomerRepository customerRepository = new CustomerRepository();
		CustomerService customerService = new CustomerService(customerRepository);

		
		customerService.ProcessCustomerData();
		Console.ReadKey();
	}
}

