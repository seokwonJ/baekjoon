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
            int aa = 0;
            int n = int.Parse(Console.ReadLine());
            int k = 1;
            int num = 6;
            while(true)
            {
                aa += 1;
                if (n <= k)
                {
                    break;
                }
                k += num;
                num += 6;
            }
            Console.WriteLine(aa);
        }
    }
}        