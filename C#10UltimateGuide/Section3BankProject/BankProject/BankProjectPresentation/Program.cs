using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("************FriendlyBank************");
        Console.WriteLine("Login Page");

        string userName = null, password = null;

        Console.Write("Username: ");
        userName = Console.ReadLine();

        if (userName !="")
        {
            Console.Write("Password: ");
            password = Console.ReadLine();
        }

        if (userName == "system" && password == "manager")
        {
                int mainMenuChoice = -1;
            do
            {

                Console.WriteLine("\nMain menu");
                Console.WriteLine("1.Customers");
                Console.WriteLine("2.Accounts");
                Console.WriteLine("3.Funds Transfer");
                Console.WriteLine("4.Funds Transfer Statement");
                Console.WriteLine("5.Account Statement");
                Console.WriteLine("0.Exit");

                Console.WriteLine("Enter Choice");
                mainMenuChoice = int.Parse(Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1:
                        CustomersMenu();
                        break;
                    case 2: 
                        AccountsMenu();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;

                }
            }
                while (mainMenuChoice != 0) ;
        }
        else
        {
            Console.WriteLine("Invalid username or password");

        }


        Console.WriteLine("Thank you!");
        Console.ReadKey();



    }

    static void CustomersMenu()
    {
        int customerMenuChoice = -1;

        do
        {
            Console.WriteLine("Customer Menu");
            Console.WriteLine("1.Add Customer");
            Console.WriteLine("2.Delete Customer");
            Console.WriteLine("3.Update Customer");
            Console.WriteLine("4.View Customer");
            Console.WriteLine("0.Back to Main Menu");

            Console.WriteLine("Enter Choice");
            customerMenuChoice = int.Parse(Console.ReadLine());
        } while (customerMenuChoice != 0);

    }

    static void AccountsMenu()
    {
        int accountsMenuChoice = -1;

        do
        {
            Console.WriteLine("Accounts Menu");
            Console.WriteLine("1.Add Account");
            Console.WriteLine("2.Delete Account");
            Console.WriteLine("3.Update Account");
            Console.WriteLine("4.View Account");
            Console.WriteLine("0.Back to Main Menu");

            Console.WriteLine("Enter Choice");
            accountsMenuChoice = int.Parse(Console.ReadLine());
        } while (accountsMenuChoice != 0);
    }
}