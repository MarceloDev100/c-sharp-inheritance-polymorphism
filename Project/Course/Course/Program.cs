using Course.Entities;

BusinessAccount account = new BusinessAccount(8010, "Bob", 100.0, 500.00);
Console.WriteLine(account.Balance);

// Balance has protected property, so it can only be changed in Account subclasses.
// Classes doesn't have permission to set it.
//account.Balance = 300.00;  // error