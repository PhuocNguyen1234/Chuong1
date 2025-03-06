using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_OOP
{
    class PartTimeEmployee:Employee
    {
        private int workingHour;
        public PartTimeEmployee(int workingHour, string name, int paymentPerHour) : base(name, paymentPerHour)
        {
            this.workingHour = workingHour;
        }
        public int WorkingHour
        {
            get { return workingHour; }
            set { workingHour = value; }
        }
        public override int calculateSalary()
        {
            return workingHour * paymentPerHour;
        }
    }
}
