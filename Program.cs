using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tính S(n) = 1 + 1/2 + 1/3 + ... +1/n
namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            float s;
            s = 0;
            Console.Write("Nhap vao so n: ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
                s = s + 1.0f / i;
            Console.Write("Ket qua cua phep tinh: 1 + 1/2 + ... + 1/{0} la: {1}", n, s);

        }
    }
}
