using System;
using ClassLibrary1;

namespace Deconstruction
{
    internal class Program
    {
        static void Main()
        {
            Customer c = new Customer();
            (int CustomerId, string CustomerName, string CustomerEmail) = c.GetCustomerDetails();

            //discard
            //(int CustomerId, _, string CustomerEmail) = c.GetCustomerDetails();
            Console.WriteLine(CustomerName);
            Console.WriteLine(CustomerId);
            Console.WriteLine(CustomerEmail);
            Console.ReadKey();
        }
    }
}
