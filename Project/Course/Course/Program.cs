using Course.Entities;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        /*
          Remarks

          ********** About Abstract class ********** 
          *
          * - If the Account class can't be instantiated, why not just create
          * SavingsAccount and BusinessAccount?
          * 
          * Reasons: 
          * 
          * - Reuse: The members of Account class can be reused avoiding to 
          * rewrite them in each class (SavingsAccount and BusinessAccount).
          * Therefore, it prevents duplicated code, reduces error chances and
          * make the maintenance easier.
          * 
          * - Polymorphism: The generic superclass(base class) allows us to point to
          * all account types. So, it's possible to put all account types in a 
          * same collection.
          *    
         */
        List<Account> list = new List<Account>();

        list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
        list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
        list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
        list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

        // Total balance of all accounts.
        double sum = 0.0;
        foreach(Account acc in list)
        {
            sum += acc.Balance;
        }
        Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

        // Methods that run in a polymorphic way.
        foreach(Account acc in list)
        {
            acc.Withdraw(10.0);
        }

        // Prints updated balance of each account.
        foreach(Account acc in list)
        {
            Console.WriteLine("Updated balance for account "
                + acc.Number
                + ": "
                + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}


