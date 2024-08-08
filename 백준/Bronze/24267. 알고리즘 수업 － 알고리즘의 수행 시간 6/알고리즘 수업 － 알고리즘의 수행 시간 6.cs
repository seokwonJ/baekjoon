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
            long sum = 0;
            long rsum = 0;
            for (int i =1;i <= n-2;i++)
            {
                sum = sum + i;
                rsum += sum;
            }
            Console.WriteLine(rsum);
            Console.WriteLine(3);
        }
    }
}