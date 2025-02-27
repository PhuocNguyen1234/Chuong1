using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 72: Tính S(x,n) = -x + x^2/2! - x^3/3! + ... (-1)^n*x/n!
namespace Bai_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_132, x, i;
            float tich, tong;
            long luythua;
            Console.Write("Nhap vao x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao n: ");
            n_132 = int.Parse(Console.ReadLine());
            tong = 0;
            tich = 1;
            luythua = 1;
            for(i=1; i<=n_132; i++)
            {
                tich = tich * x;
                luythua = luythua * i;
                tong = (float)(tong + Math.Pow(-1, i) * (tich / luythua));
            }
            Console.WriteLine("Ket qua phep tinh la: {0}", tong);
        }
    }
}
