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
            int num = 0;
            c = c - a;
            if (c <= 0)
            {
            }
            else
            {
                num = c / (a - b);
                if (c % (a-b) != 0)
                {
                    num += 1;
                }
            }
            Console.WriteLine(num + 1);
        }
    }
}        