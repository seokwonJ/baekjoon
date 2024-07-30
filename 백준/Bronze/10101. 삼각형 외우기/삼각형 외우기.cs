using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a+b+c == 180)
            {
                if (a==60 && b == 60 && c == 60)
                {
                    Console.WriteLine("Equilateral");
                }
                else if (a != b && b != c && c!=a)
                {
                    Console.WriteLine("Scalene");
                }
                else
                {
                    Console.WriteLine("Isosceles");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}