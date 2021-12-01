using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            CalkSum(a, b);
            Console.ReadKey();
        }
        static void CalkSum(int a, int b)
        {
            int Sum = a + b;
            Console.WriteLine(Sum);
        }
        static void CalkSum(int a, int b, int c)
        {
            int Sum = a + b + c;
            Console.WriteLine(Sum);
        }
    }
}
