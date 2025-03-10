using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2._1_Optional_parameters
{
    class Program
    {
        public static int add (int x, int y = 1, int z = 3)
        {
            return (int) (x + y + z);
        }
        static void Main(string[] args)
        {
            var result = add(1);
            Console.WriteLine("Ket qua cua phep tinh la: {0}",result);
            Console.ReadKey();
        }
    }
}
