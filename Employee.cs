using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_OOP
{
    class Employee:IEmployee
    {
        protected String name;
        protected int paymentPerHour;
        public Employee(string name, int paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int PaymentPerHour
        {
            get { return paymentPerHour; }
            set { paymentPerHour = value; }
        }
        public String getName()
        {
            return name;
        }
        public virtual int calculateSalary()
        {
            return 0;
        }

    }
}
