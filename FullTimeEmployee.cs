using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_OOP
{
    class FullTimeEmployee:Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour):base(name, paymentPerHour)
        {  
        }
        public override int calculateSalary()
        {
            return 8 * paymentPerHour;
        }
    }
}
