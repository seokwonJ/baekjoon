using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n * (n / 2 - 1) + n / 2);
            }
            else
            {   
                Console.WriteLine(n / 2 * n);
            }
            Console.WriteLine(2);
        }
    }
}