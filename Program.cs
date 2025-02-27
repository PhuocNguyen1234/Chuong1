using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 82: Viết chương trình tìm số lớn nhất trong 3 số thực a,b,c
namespace Bai_8
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, max;
            Console.Write("Nhap vao so a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao so b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao so c: ");
            c = float.Parse(Console.ReadLine());
            max = a;
            if (max < b)
                max = b;
            if (max < c)
                max = c;
            Console.WriteLine("So lon nhat trong ba so {0}, {1}, {2} la {3}", a, b, c, max);

        }
    }
}
