namespace Course.Entities
{
    // sealed : prevents SavingsAccount class from being inherited
    // It may protect some business rules when avoiding this class to be inherited
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // sealed method: Only possible when applied to overridden methods.
        // this method can't be overridden again in other subclass
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
