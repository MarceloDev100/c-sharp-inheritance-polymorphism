using Course.Entities;

/*
   ******** Override *********
   
   - Method implementation from a superclass in subclass.
   - In other words: A method in subclass that already exists
   in superclass(base class) is reimplemented to provide a different behavior.
   - To allow a common method to be overriden, it must include the virtual prefix.
   - When overriding a method, we must include the override prefix in it .

   - Suppose the following rules for withdraw:
   - Common account:  is charged a fee of 5.0
   - Saving account:  no fee is charged.
 */

Account acc1 = new Account(1001, "Alex", 500.0);
Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

acc1.Withdraw(10.0);
acc2.Withdraw(10.0);

Console.WriteLine(acc1.Balance);
Console.WriteLine(acc2.Balance);

