using System;
class Employee
{
    public string EmpName;
    public decimal BasicSalary;
    public decimal HRA, DA, Tax, GrossPay, NetPay;

    public Employee(string name, decimal basicSalary)
    {
        EmpName = name;
        BasicSalary = basicSalary;
    }

    public void CalculateNetPay()
    {
        HRA = BasicSalary * 0.15m;
        DA = BasicSalary * 0.10m;
        GrossPay = BasicSalary + HRA + DA;
        Tax = GrossPay * 0.08m;
        NetPay = GrossPay - Tax;
    }

    public void Display()
    {
        Console.WriteLine("\n----- Employee Salary Details -----");
        Console.WriteLine("Employee Name : " + EmpName);
        Console.WriteLine("Basic Salary  : " + BasicSalary);
        Console.WriteLine("HRA           : " + HRA);
        Console.WriteLine("DA            : " + DA);
        Console.WriteLine("Gross Pay     : " + GrossPay);
        Console.WriteLine("Tax           : " +  Tax);
        Console.WriteLine("Net Pay       : " +  NetPay);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter Emploee Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Basic Salary: ");
        decimal salary = Convert.ToDecimal(Console.ReadLine());

        Employee emp = new Employee(name, salary);

        emp.CalculateNetPay();
        emp.Display();
    }
}