using System;


namespace Tuples
{
    class Sample
    {
        public Tuple<string, int> GetPersonDetails()
        {
            Tuple<string, int> tuple = new Tuple<string, int>("tibi", 41);            
                return tuple;
        }
    }
    internal class Program
    {
        static void Main()
        {
            Sample s = new Sample();
            Tuple<string, int> person = s.GetPersonDetails();
            Console.WriteLine(person);
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
            Console.ReadKey();
        }
    }
}
