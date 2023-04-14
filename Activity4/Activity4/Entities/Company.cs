
namespace Activity4.Entities
{
    class Company : TaxPayer
    {
        private int _totalEmployees;
     
        public Company(string name, double annualIncome, int totalEmployees) 
            : base(name, annualIncome)
        {
            TotalEmployees = totalEmployees;  
        }

        public int TotalEmployees
        {
            get
            {
                return _totalEmployees;
            }
            set
            {
                _totalEmployees = Math.Abs(value);
            }
        }

        public override double Tax()
        {
            if(TotalEmployees > 10)
            {
                return AnnualIncome * 0.14;
            }
            return AnnualIncome * 0.16;
        }
    }
}
