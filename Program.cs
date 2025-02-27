using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 57: Kiểm tra số nguyên dương n có toàn chữ số chẵn hay không
namespace Bai_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_132;
            bool ktr = true;
            Console.Write("Nhap vao mot so: ");
            n_132 = int.Parse(Console.ReadLine());
            Console.Write("So {0} gom toan chu so chan phai hay khong", n_132);
            while (n_132 > 0)
            {
                if ((n_132 % 10) % 2 == 1)
                {
                    ktr = false;
                    break;
                }
                n_132 /= 10;
            }
            if (ktr == true)
                Console.Write("\nPhai");
            else
                Console.Write("\nKhong phai");
        }
    }
}
