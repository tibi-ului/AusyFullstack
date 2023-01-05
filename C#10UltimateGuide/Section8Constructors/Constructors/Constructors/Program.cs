using System;

class Program
{
    static void Main()
    {
        var emp1 = new Employee(1, "tibi", "programator");
        var emp2 = new Employee(2, "paula", "analist");
        var emp3 = new Employee(3, "andreea", "medic");
        var emp4 = new Employee() { empName = "adi", job = "tester" };

        Console.WriteLine(emp1.empId + emp2.empName + emp3.job);
        Console.WriteLine(Employee.companyName);

        Console.ReadKey();
    }
}