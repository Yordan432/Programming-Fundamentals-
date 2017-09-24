using System;

class EmployeeData
{
    static void Main()
    {
        var name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        int Employee = int.Parse(Console.ReadLine());
        double Salary = double.Parse(Console.ReadLine());

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");      
        Console.WriteLine($"Employee ID: {Employee.ToString("D8")}");
        Console.WriteLine($"Salary: {Salary:f2}");



    }
}

