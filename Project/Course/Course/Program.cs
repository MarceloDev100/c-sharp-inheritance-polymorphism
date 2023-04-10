using Course.Entities;

Account acc = new Account(1001, "Alex", 0.0);
BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

/*
 ********* UPCASTING ************
 *
 * - Upcasting (Conversion from subclasse to superclass).
 * - Because of inheritance, BusinessAccount is an Account, so this assign is valid.
 * - An Account variable can receive any type of subclass from it.
 */
Account acc1 = bacc;

Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);

Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

/*
 * ********* DOWNCASTING ************
 * 
 * - Downcasting (Conversion from superclass to subclass).
 * - Here, an error occurs at compile time. 
 * - Compiler only notices the variable type (Account) and
 * doesn't know that it will get an BusinessAccount object. 
 * This object will only exist at runtime.
 * 
 * - That's not possible to implicitly convert Account to BusinessAccount.
 * BusinessAccount acc4 = acc2;  // gives an error
 * 
 * - If I want to convert the acc2 variable content  (BusinessAccount)
 * to a BusinessAcount variable, it is necessary a
 * casting.
 */

BusinessAccount acc4 = (BusinessAccount) acc2;
acc4.Loan(100.0);

/*
  - Notice that Loan operation doesn't exist in acc2 variable,
  because it is Account type.
  acc2.Loan(50.0)    fails!
 */


/*
   - Here, compiler doesn't give an error at compile time,
   but an error occurs at runtime.
   - Compiler "has in mind" that there is an Account variable
   and tries to do a casting to BusinessAccount at compile time.
   - When program runs, it's found that acc3 is not a BusinessAccount
   but is in fact a SavingsAccount object. Therefore, a casting 
   can't be done (runtime error).
   - Downcasting is an unsafe operation, and should be used
   only when strictly necessary.

   BusinessAccount acc5 = (BusinessAccount) acc3;   // fails!
 */


/*
 *  ********* Use of "is" or "as" operator ************
 *  
   - Before performing a downcasting operation, test should be done
    to see if variable is of desired type. This is done with "is" operator.
   - Below, only the last if statement is executed because acc is in fact
   SavingAccount object.
   - As seen above, a downcasting operation may fail at runtime and throws
   an exception (InvalidCastException).
   - Other way to do a downcasting is to use "as" operator. If it's not
   - the correct type, it will return null. (rather then throwing an exception).
 */

if (acc3 is BusinessAccount)
{
    //BusinessAccount acc5 = (BusinessAccount) acc3;
    BusinessAccount? acc5 = acc3 as BusinessAccount;
    acc5?.Loan(200.0);
}

if (acc3 is SavingsAccount)
{
    //SavingsAccount acc5 = (SavingsAccount) acc3;
    SavingsAccount? acc5 = acc3 as SavingsAccount;
    acc5?.UpdateBalance();
    Console.WriteLine("Update!");
}
