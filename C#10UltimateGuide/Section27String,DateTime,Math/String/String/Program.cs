using System;
using System.Linq;

namespace String
{
    class Program
    {
        static void Main()
        {

            #region Join() + char[] to string

            string[] array = { "hai", "la", "bere" };
            string strJoin = string.Join("-", array);
            Console.WriteLine(strJoin);

            

            char[] characters2 = new char[] { 'h', 'e', 'l', 'l', 'o' };

            //creeam un string folosind constructorul clasei string
            string str2 = new string(characters2);
            Console.WriteLine("New string: " + str2);



            char[] charArray = { 'h', 'e', 'l', 'l', 'o', 'o' };

            string stringHello = string.Join("", charArray);
            Console.WriteLine("New string: " + stringHello);

            string stringHello1 = new string(charArray);
            Console.WriteLine("New string: " + stringHello1);


            #endregion
            Console.WriteLine();


            #region Format
            string employee = "tibi", job = "programmer";
            string message = string.Format("{0} is {1}", employee, job);
            Console.WriteLine(message);

            string newWay = string.Format($"{employee} is a good {job}");
            Console.WriteLine(newWay);
            #endregion
            Console.WriteLine();




            Console.ReadKey();
        }
    }
}
