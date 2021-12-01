using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            CalkSum(ref a, b);
            Console.WriteLine(a);
            Console.ReadKey();
        }
        static void CalkSum(ref int a, int b)
        {
            a = +b;
        }
    }
}
}
