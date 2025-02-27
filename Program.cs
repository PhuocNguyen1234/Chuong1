using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 109: Viết chương trình in bảng cửu chương ra màn hình
namespace Bai_10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 2; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}",  j, i, i * j);
                }
                Console.WriteLine("\n----------\n");
            }
        }
    }
}
