using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 32: Cho số nguyên dương n. Kiểm tra xem n có phải là số chính phương hay không?
namespace Bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap vao mot so can kiem tra: ");
            n = int.Parse(Console.ReadLine());
            if (Math.Sqrt(n) == (int)Math.Sqrt(n))
                Console.Write("{0} la so chinh phuong", n);
            else
                Console.Write("{0} khong phai la so chinh phuong", n);
        }
    }
}
