using Homework_9;
using System;


class Program
{
    static void Main()
    {
        bool isLocal = true;

        Console.Write("Please confirm whether Company is 'Local' or 'Foreign' ? ");
        string companyIdentity = Console.ReadLine();
        if (companyIdentity.ToLower() == "foreign")
        {
            isLocal = false;
        }
        Company company = new Company(isLocal);

        string firstName, lastName, position, weeklyHours;
        int age;
        GetParameters(out firstName, out lastName, out age, out position, out weeklyHours);

        Employee employee = new Employee(firstName, lastName, age, position, weeklyHours);

        double salary = employee.CalculateWeeklySalary();

        double tax = company.CalculateTax(salary);

        Console.WriteLine($"{employee.FirstName} {employee.LastName}'s weekly salary : {salary}\nTax Paid: {tax}");


    }

    static void GetParameters(out string firstName, out string lastName, out int age, out string position, out string weeklyHours)
    {
        Console.WriteLine("Enter details for Employee 1:");
        Console.Write("First Name: ");
        firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        lastName = Console.ReadLine();
        Console.Write("Age: ");
        age = int.Parse(Console.ReadLine());
        Console.Write("Position (manager/developer/tester/others): ");
        position = Console.ReadLine();
        Console.Write("Enter weekly hours separated by spaces (e.g., 8 8 8 8 8 0 0): ");
        weeklyHours = Console.ReadLine();

    }
}