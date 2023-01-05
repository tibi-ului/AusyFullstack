using System;


namespace ClassLibrary1
{
    public class Customer
    {
        public (int CustomerId, string CustomerName, string CustomerEmail) GetCustomerDetails()
        {
            return (1, "tibi", "tibi@gmail.com");
        }
    }
}
