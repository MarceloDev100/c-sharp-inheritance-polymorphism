using Course.Entities;

/*
   ******** Using "base" keyword *********
   *
   - It's possible to call a superclass (or base class) implementation using "base" keyword.
   - Suppose withdraw's rule regarding to SavingAccount is to perform
   the withdraw using  a superclass (Account) and after that, subtract 2.0 from it.
   - In the withdraw method of SavingAccount class, we may call withdraw method of base class 
   (Account class) using "base" word. Next, it is subtracted 2.0 from balance.

   - "base" keyword is also used in a subclass construct to reuse the superclass construct
   passing data to it.
  
 */

Account acc1 = new Account(1001, "Alex", 500.0);
Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

acc1.Withdraw(10.0);
acc2.Withdraw(10.0);

Console.WriteLine(acc1.Balance);
Console.WriteLine(acc2.Balance);

