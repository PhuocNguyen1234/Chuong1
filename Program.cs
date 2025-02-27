using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 12: Tính S(n) =  x + x^2 + x^3 + ... +x^n
namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float x_132, tong_132, tich_132;
            int n_132, i_132;
            tong_132 = 0;
            tich_132 = 1;
            Console.Write("Nhap vao gia tri cua x: ");
            x_132 = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao gia tri cua n: ");
            n_132 = int.Parse(Console.ReadLine());
            for (i_132 = 1; i_132 <= n_132; i_132++)
            {
                tich_132 = tich_132 * x_132;
                tong_132 = tong_132 + tich_132;
            }
            Console.Write("Ket qua cua phep tinh la: {0}", tong_132);
        }
    }
}
