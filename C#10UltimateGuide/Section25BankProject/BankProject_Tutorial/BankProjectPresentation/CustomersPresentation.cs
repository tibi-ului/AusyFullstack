using System;
using System.Collections.Generic;
using BankProject.Entities;
using BankProject.Exceptions;
using BankProject.BusinessLogicLayer;
using BankProject.BusinessLogicLayer.BussinessLayerContracts;

namespace BankProject.Presentation
{
    static class CustomersPresentation
    {
        internal static void AddCustomer()
        {
            try
            {
                //create an object of Customer
                Customer customer = new Customer();

                //read all details from the user
                Console.WriteLine("\n---Add Customer---");
                Console.Write("Customer Name: ");
                customer.CustomerName = Console.ReadLine();

                Console.Write("Customer Address: ");
                customer.Address = Console.ReadLine();

                Console.Write("Customer Landmark: ");
                customer.Landmark = Console.ReadLine();

                Console.Write("Customer City: ");
                customer.City = Console.ReadLine();

                Console.Write("Customer Country: ");
                customer.Country = Console.ReadLine();

                Console.Write("Customer Mobile: ");
                customer.Mobile = Console.ReadLine();

                //create bl object
                ICustomersBusinessLogicLayer customersBusinessLogicLayer = new CustomersBusinessLogicLayer();
                Guid newGuid = customersBusinessLogicLayer.AddCustomer(customer);

                List<Customer>matchingCustomers = customersBusinessLogicLayer.GetCustomersByCondition(item => item.CustomerID == newGuid);
                if(matchingCustomers.Count >= 1)
                {
                    Console.WriteLine("New Customer Code:" + matchingCustomers[0].CustomerCode);
                    Console.WriteLine("Customer Not added.\n");

                }
                else
                {
                    Console.WriteLine("Customer Not added");
                }
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
        }
        internal static void ViewCustomers()
        {
            try
            {
                //create bl object
                ICustomersBusinessLogicLayer customersBusinessLogicLayer = new CustomersBusinessLogicLayer();

                List<Customer> allCustomers = customersBusinessLogicLayer.GetCustomers();
                Console.WriteLine("\n---ALL CUSTOMERS---");

                //read all customers

                foreach (var item in allCustomers)
                {
                    Console.WriteLine("Customer Code:" + item.CustomerCode);
                    Console.WriteLine("Customer Name:" + item.CustomerName);
                    Console.WriteLine("Address :" + item.Address);
                    Console.WriteLine("Landmark :" + item.Landmark);
                    Console.WriteLine("City :" + item.City);
                    Console.WriteLine("Country :" + item.Country);
                    Console.WriteLine("Mobile :" + item.Mobile);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
        }
    }
}
