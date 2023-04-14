namespace Activity4.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }

        private double _anualIncome;
       
        public TaxPayer(string name, double annualIncome) 
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public double AnnualIncome
        { 
            get 
            {
                return _anualIncome; 
            }
            set
            {
                if(value >= 0)
                {
                    _anualIncome = value;   
                }
            }
        }

        public abstract double Tax();
    }
}
