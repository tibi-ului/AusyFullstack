using System;
using ClassLibrary1;

namespace ValueTuples
{
    internal class Program
    {
        static void Main()
        {
            Customer c = new Customer();
            (int CustomerId, string CustomerName, string CustomerEmail) customer =  c.GetCustomerDetails();
            Console.WriteLine(customer.CustomerName);
            Console.WriteLine(customer.CustomerId);
            Console.WriteLine(customer.CustomerEmail);
            Console.ReadKey();
        }
    }
}
