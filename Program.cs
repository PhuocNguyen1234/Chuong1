using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nguyen Huu Phuoc");
            Console.WriteLine("MSV: 23115053122132");
            PartTimeEmployee nv1_132 = new PartTimeEmployee(10, "Nam", 10);
            Console.WriteLine("Nhan vien parttime: {0}, co luong {1}", nv1_132.getName(), nv1_132.calculateSalary());

            FullTimeEmployee nv2_132 = new FullTimeEmployee("Dung", 10);
            Console.WriteLine("Nhan vien fulltime: {0}, co luong {1}", nv2_132.getName(), nv2_132.calculateSalary());
            Console.ReadKey();
        }
    }
}
