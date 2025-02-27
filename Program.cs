using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 100: Viết chương trình giải phương trình bậc 2
namespace Bai_9
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, x, d, x1, x2, x3;
            Console.Write("Nhap vao he so a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao he so b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao he so c: ");
            c = float.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    if (c == 0)
                        Console.Write("Pt co vo so nghiem");
                    else
                        Console.Write("Pt vo nghiem");
                else
                {
                    x = -b / c;
                    Console.Write("Pt co nghiem x= {0}", x);
                }
            else
            {
                d = b * b - 4 * a * c;
                if (d == 0)
                {
                    x1 = -b / (2 * a);
                    Console.Write("Pt co nghiem x1=x2= {0}", x1);
                }
                else
                    if (d < 0)
                    Console.Write("Pt vo nghiem");
                else
                {
                    x2 = (float)(-b - Math.Sqrt(d)) / (2 * a);
                    x3 = (float) (-b + Math.Sqrt(d)) / (2 * a);
                    Console.Write("Pt co 2 nghiem\n x1= {0}\n x2= {1}", x2, x3);
                }
            }

        }
    }
}
