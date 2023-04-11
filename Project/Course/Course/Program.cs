using Course.Entities;
using System;
 class Program
{
    static void Main(string[] args)
    {
        /* 
        *  ******* Polymorphism ********
        *  
        *  - It consists of a feature that allows variables of generic
        *  types to point to specific objects that have different behaviors.
        *  
        *  - Below, an Account type variable (acc1) points to an Account object
        *  and other Account type variable (acc2) points to a SavingsAccount object.
        *  
        *  - When the Withdraw method is called, each one will have a different 
        *  behavior, because, in SavingsAccount class, this method is overridden to
        *  make a new implementation.
        *  
        *  Remarks:
        *  - The association of the specific type with the generic type is done 
        *  at runtime (upcasting).
        *  - The compiler doesn't know which specific type the Withdraw method 
        *  is being made for. It only knows that there are two variables of Account type.
        *  
        */

        Account acc1 = new Account(1001, "Alex", 500.0);
        Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

        acc1.Withdraw(10.0);
        acc2.Withdraw(10.0);

        Console.WriteLine(acc1.Balance);
        Console.WriteLine(acc2.Balance);
    }
}


