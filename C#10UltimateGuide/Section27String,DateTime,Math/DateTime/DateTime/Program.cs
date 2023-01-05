using System;
using System.Collections.Generic;


namespace DateTimeEx
{
    class Person
    {
        public string PersonName { get; set; }  
        public DateTime DateOfBirth{ get; set; }  
    }
    internal class Program

    {
        static void Main()
        {
            Person person = new Person();

            person.PersonName = "tibi";
            person.DateOfBirth = DateTime.Parse("1981-02-15 12:32:22.837 AM");
            //sau
            person.DateOfBirth = Convert.ToDateTime("1981-02-15 12:32:22.837 AM");




            Console.WriteLine(person.PersonName + " is born in " + person.DateOfBirth.ToString());
            Console.WriteLine(person.PersonName + " is born in " + person.DateOfBirth);
            Console.WriteLine(person.PersonName + " is born in " + person.DateOfBirth.Year);
            Console.WriteLine(person.PersonName + " is born in a " + person.DateOfBirth.DayOfWeek);
            Console.WriteLine(person.PersonName + " is born in a " + (int)person.DateOfBirth.DayOfWeek);
            Console.WriteLine(person.PersonName + " is born in a " + person.DateOfBirth.DayOfYear);

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            Console.ReadKey();
        }
    }
}
