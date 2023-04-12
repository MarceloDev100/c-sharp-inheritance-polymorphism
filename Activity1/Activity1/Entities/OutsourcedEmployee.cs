namespace Activity1.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            AdditionalCharge +=  AdditionalCharge * 10.0 / 100.0;
            return base.Payment() + AdditionalCharge; 
        }
    }
}
