public class Employee
{
    public int empId;
    public string empName;
    public string job;

    public static string companyName;

    public Employee(int empId, string empName, string job)
    {
        this.empId = empId;
        this.empName = empName;
        this.job = job;
    }

    public Employee()
    {
       // empId = 1;
    }

    static Employee()
    {
        companyName = "ausy";
    }
}