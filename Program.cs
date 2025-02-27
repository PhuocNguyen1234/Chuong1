using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 62: Cho hai số nguyên a, b hãy tìm ước chung lơn nhất của 2 số này
namespace Bai_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a_132, b_132, x, y;
            Console.Write("Nhap vao so nguyen a: ");
            a_132 = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so nguyen b: ");
            b_132 = int.Parse(Console.ReadLine());
            x = a_132;
            y = b_132;
            while (a_132 != b_132)
                if (a_132 > b_132)
                    a_132 = a_132 - b_132;
                else
                    b_132 = b_132 - a_132;
            Console.Write("UCLN cua {0} va {1} la {2}", x, y, b_132);
        }
    }
}
