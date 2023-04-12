using Activity2.Entities;
using System.Globalization;

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

List<Product> products = new List<Product>();
for (int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Product #{i} data: ");
    Console.Write("Common, used or imported (c/u/i)? ");
    char answer = char.Parse(Console.ReadLine().ToLower());

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(answer == 'c')
    {
        products.Add(new Product(name, price));
    }
    else if (answer == 'i')
    {
        Console.Write("Customs fee : ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        products.Add(new ImportedProduct(name, price, customsFee));
    }
    else if(answer == 'u')
    {
        Console.Write("Manufacture Date (DD/MM/YYYY): ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
        products.Add(new UsedProduct(name, price, manufactureDate));    
    }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS: ");
foreach(Product product in products)
{
    Console.WriteLine(product.PriceTag());
}