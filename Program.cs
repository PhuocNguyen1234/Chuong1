using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 21: Tính tổng tất cả các ước số của số nguyên dương n
namespace Bai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int gtri, i, tong_132;
            tong_132 = 0;
            Console.Write("Nhap vao gia tri: ");
            gtri = int.Parse(Console.ReadLine());
            for(i = 1; i <= gtri; i++)
            {
                if (gtri % i == 0)
                {
                    Console.Write("{0}  ", +i);
                    tong_132 = tong_132 + i;
                }
                    
            }
            Console.Write("\nTong cac uoc cua {0} la: {1}", gtri, tong_132);
        }
    }
}
