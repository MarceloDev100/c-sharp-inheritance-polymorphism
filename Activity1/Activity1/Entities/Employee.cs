using System.Globalization;
using System.Text;

namespace Activity1.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee() 
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            return sb.Append(string.Format("{0,-15}  $ {1,-6}\n", 
                Name, Payment().ToString("F2", CultureInfo.InvariantCulture))).ToString();
        }
    }
}
