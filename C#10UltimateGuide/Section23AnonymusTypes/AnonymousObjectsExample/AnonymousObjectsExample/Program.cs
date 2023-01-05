using System;
using ClassLibrary1;


namespace AnonymousObjectsExample
{
    internal class Program
    {
        static void Main()
        {
            Person p = new Person();

            var person = new { 
                PersonName = p.GetPersonName(), 
                Age = p.GetPersonAge(),
                PersonDetails = new
                {
                    EyesColor = "blue",
                    HairColor = "brown"
                }
            };

            Console.WriteLine(person.PersonName);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.PersonDetails.EyesColor);
            Console.ReadKey();

            //anonymus array
            var persons = new[]
            {
                new { PersonName = "tibi", Email = "tibi@gmail.com" }
            };
            foreach(var item in persons) {
                Console.WriteLine(item.PersonName);
                Console.WriteLine(item.Email);
            }
            Console.ReadKey();



        }
    }
}
