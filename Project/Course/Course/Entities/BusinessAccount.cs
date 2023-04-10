namespace Course.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        // calls Account constructor by use of word : base 
        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance) 
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
        
    }
}
