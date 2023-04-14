namespace Activity4.Entities
{
    class Individual : TaxPayer
    {
        private double _healthExpenditures;

        public Individual(string name, double annualIncome, double healthExpenditures)
            : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public double HealthExpenditures
        {
            get 
            { 
                return _healthExpenditures;
            }
            set
            {
                if(value >= 0)
                {
                    _healthExpenditures = value;    
                }
            }
        }

        public override double Tax()
        {
            double tax = AnnualIncome <= 20000.00 ? AnnualIncome * 0.15 : AnnualIncome * 0.25;

            tax -= HealthExpenditures * 0.50;

            if(tax < 0.0)
            {
                tax = 0.0;
            } 

            return tax;
        }
    }
}
