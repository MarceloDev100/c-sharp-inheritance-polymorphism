﻿using Activity1.Entities;
using System.Globalization;

Console.Write("Enter the number of employees: ");
int n = int.Parse(Console.ReadLine());

List<Employee> employees = new List<Employee>();
for(int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Employee #{i} data: ");
    Console.Write("Outsourced (y/n)? ");
    char answer = char.Parse(Console.ReadLine().ToLower());
    bool isOutsourced = answer == 'y';

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Hours: ");
    int hours  = int.Parse(Console.ReadLine());

    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(isOutsourced)
    {
        Console.Write("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
    }
    else
    {
        employees.Add(new Employee(name, hours, valuePerHour));
    }
}

Console.WriteLine();
Console.WriteLine("PAYMENTS: ");
Console.WriteLine(string.Format("{0,-15}  {1,-6}\n", "Name", "Payment"));
foreach (Employee emp in employees)
{
    Console.WriteLine(emp);
}



