using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LINQ
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public string City { get; set; }
        public double Salary { get; set; }
    }

    class Person
    {
        public string PersonName { get; set; }
    }

 
    class Program
    {
     
        static void Main()
        {
            //Collection of objects
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { EmpID = 101, EmpName = "Henry", Job = "Designer", City = "Boston", Salary = 7232 },
                new Employee() { EmpID = 102, EmpName = "Jack", Job = "Developer", City = "New York", Salary = 4500 },
                new Employee() { EmpID = 103, EmpName = "Gabriel", Job = "Analist", City = "Tokyo", Salary = 1293 },
                new Employee() { EmpID = 104, EmpName = "William", Job = "Manager", City = "Tokyo", Salary = 2873 },
                new Employee() { EmpID = 105, EmpName = "Alexa", Job = "Manager", City = "New York", Salary = 6232 },
                new Employee() { EmpID = 106, EmpName = "Jess", Job = "Manager", City = "New York", Salary = 4545 }
            };

            #region Where
            var result = employees.Where(emp => emp.Job == "Manager");
            var result1 = employees.Where(emp => emp.Job == "London");
            //var = IEnumerable<Employee>
            //IEnumerable<Employee> result = employees.Where(emp => emp.Job == "Manager");
           foreach(Employee emp in result)
            {
                Console.WriteLine(emp.EmpID + " , " + emp.EmpName + " , " + emp.Job + " , " + emp.City);
            }
            #endregion
            Console.WriteLine();

            #region Where cu index
            var resultIndex = employees.Where(emp => emp.Job == "Manager").ToList();
            Console.WriteLine("index " + resultIndex[1].EmpName + " , " + resultIndex[1].Salary);
           
            #endregion
            Console.WriteLine();


            #region Where pentru last index
            List<Employee> lastIndex = employees.Where(emp => emp.Job == "Manager").ToList();
            Console.WriteLine("last index with Where() " + lastIndex[lastIndex.Count - 1].EmpName + " , " + lastIndex[lastIndex.Count - 1].Salary);

            #endregion
            Console.WriteLine();

            #region OrderBy

            var orderBySalary = employees.OrderBy(emp => emp.Salary);
            foreach(Employee emp in orderBySalary)
            {
                Console.WriteLine(emp.EmpName + " salary is: " + emp.Salary);
            }
            Console.WriteLine();
            var orderByJob = employees.OrderBy(emp => emp.Job).ThenBy(emp => emp.EmpName);
            foreach(Employee emp in orderByJob)
            {
                Console.WriteLine(emp.EmpName + " is a " + emp.Job);
            }
            #endregion
            Console.WriteLine();

            #region OrderByDescending

            var orderByDescendingSalary = employees.OrderByDescending(emp => emp.Salary);
            foreach (Employee emp in orderByDescendingSalary)
            {
                Console.WriteLine(emp.EmpName + " salary is: " + emp.Salary);
            }
            #endregion
            Console.WriteLine();

            #region First
            var first = employees.First(emp => emp.Job == "Manager");

            Console.WriteLine("first method " + first.EmpName);
       
            #endregion
            Console.WriteLine();

            #region FirstOrDefault
            var firstOrDefault = employees.FirstOrDefault(emp => emp.Job == "Manager");

            Console.WriteLine("firstOrDefault method " + firstOrDefault.EmpName);
            Console.WriteLine();

            var firstOrDefaultNotMatching = employees.FirstOrDefault(emp => emp.Job == "Rabin");
            if (firstOrDefaultNotMatching != null)
            {

            Console.WriteLine("firstOrDefault method " + firstOrDefaultNotMatching.EmpName);
            }
            else
            {
                Console.WriteLine("no Rabin in the list");
            }

            #endregion
            Console.WriteLine();


            #region Last
            var last = employees.Last(emp => emp.Job == "Manager");

            Console.WriteLine("last method " + last.EmpName);

            #endregion
            Console.WriteLine();

            #region LastOrDefault
            var lastOrDefault = employees.LastOrDefault(emp => emp.Job == "Manager");

            Console.WriteLine("LastOrDefault method " + lastOrDefault.EmpName);
            Console.WriteLine();

            var lastOrDefaultNotMatching = employees.LastOrDefault(emp => emp.Job == "Rabin");
            if (lastOrDefaultNotMatching != null)
            {

                Console.WriteLine("LastOrDefault method " + lastOrDefaultNotMatching.EmpName);
            }
            else
            {
                Console.WriteLine("no Rabin found");
            }

            #endregion
            Console.WriteLine();

            #region ElementAt
            Employee elementAtEmployee = employees.Where(emp => emp.Job == "Manager").ElementAt(1);
            Console.WriteLine("elementAt - " + elementAtEmployee.EmpID + " , " + elementAtEmployee.EmpName);
            #endregion
            Console.WriteLine();

            #region ElementAtOrDefault
            Employee elementAtOrDefaultEmployee = employees.Where(emp => emp.Job == "Manager").ElementAtOrDefault(4);
           
            if(elementAtOrDefaultEmployee != null) {
                Console.WriteLine("elementAt - " + elementAtOrDefaultEmployee.EmpID + " , " + elementAtOrDefaultEmployee.EmpName);
            }
            else
            {
                Console.WriteLine("no manager at index 4");
            }
            #endregion
            Console.WriteLine();


            #region Select

            IEnumerable<int> selectEx1 = employees.Select(emp => 10);
            foreach(int item in selectEx1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();



            IEnumerable<Person> selectEx2 = employees.Select(emp => new Person() { PersonName = emp.EmpName.ToLower() });
           
            foreach (Person item in selectEx2)
            {
                Console.WriteLine(item.PersonName);
            }
            Console.WriteLine();



            List<Person> selectEx3 = employees.Select(emp => new Person() { PersonName = emp.EmpName }).ToList();
            Console.WriteLine(selectEx3.Count);
            Console.WriteLine();

            foreach (Person item in selectEx3)
            {
                Console.WriteLine(item.PersonName);
            }
            Console.WriteLine();

            #endregion  
            Console.WriteLine();



            #region Min, Max, Count, Sum, Average
            
            double min = employees.Min(emp => emp.Salary);
            double max = employees.Max(emp => emp.Salary);
            double sum = employees.Sum(emp => emp.Salary);
            double count = employees.Count();
            double average = employees.Average(emp => emp.Salary);

            Console.WriteLine("min: " + min);
            Console.WriteLine("max: " + max);
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("count: " + count);
            Console.WriteLine("average: " + average);
            #endregion


            Console.ReadKey();
        }
    }
}
    