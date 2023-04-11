namespace Course.Entities
{
    class SavingsAccountPlus : SavingsAccount
    {
        /*
          Compiler doesn't show Withdraw method here, because
          this method is sealed in SavingAccount class. So it
          can't be overridden here.

          Reasons to have a sealed class or method:

          - Security: Depending on business rules, sometimes 
          it is more appropriate to ensure that a class is not
          inherited or a method is not overridden. 
          Multiples overridden methods may be a gateway to 
          inconsistences in code.
          - Performance: type attributes of a sealed class are
          analyzed faster at runtime.   
         */
    }
}
