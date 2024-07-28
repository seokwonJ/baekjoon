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
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);
            int d = int.Parse(s[3]);
            int small = a;
            if (c - a < small)
            {
                small = c - a;
            }
            if (b < small)
            {
                small = b;
            }
            if (d - b < small)
            {
                small = d - b;
            }
            Console.WriteLine(small);
        }
    }
}