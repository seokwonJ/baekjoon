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
            int n = int.Parse(Console.ReadLine());
            int x1 = -10001,x2=10001;
            int y1 = -10001,y2=10001;
            for (int i =0;i < n;i++)
            {
                string[] s = Console.ReadLine().Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                if (a < x2)
                {
                    x2 = a;
                }
                if (a > x1)
                {
                    x1 = a;
                }
                if (b < y2)
                {
                    y2 = b;
                }
                if (b > y1)
                {
                    y1 = b;
                }
            }
            Console.WriteLine((x1 - x2) * (y1 - y2));
        }
    }
}