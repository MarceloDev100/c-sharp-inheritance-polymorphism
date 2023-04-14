using Activity4.Entities;
using System.Globalization;

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

List<TaxPayer> list = new List<TaxPayer>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Tax payer #{i} data: ");
    Console.Write("Individual or company (i/c)? ");
    char answer = char.Parse(Console.ReadLine().ToLower());
    bool isIndividual = answer == 'i';

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Annual Income: ");
    double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (isIndividual)
    {
        Console.Write("Health expenditures: ");
        double expenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Individual(name, annualIncome, expenses));
    }
    else
    {
        Console.Write("Number of employees: ");
        int total = int.Parse(Console.ReadLine());
        list.Add(new Company(name, annualIncome, total));
    }
}

Console.WriteLine();
Console.WriteLine("TAXES PAID: ");
Console.WriteLine("{0,-15} {1,-5}", "Name", "Tax");
double totalTaxes = 0.0;
foreach (TaxPayer taxPayer in list)
{
    Console.WriteLine("{0,-15} $ {1,-5}",
        taxPayer.Name, taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
    totalTaxes += taxPayer.Tax();
}

Console.WriteLine();
Console.WriteLine("{0,-15} $ {1,-5}", "TOTAL TAXES: ",
    totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
