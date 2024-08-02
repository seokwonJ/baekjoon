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
            int a, b, c;
            string[] s = Console.ReadLine().Split();
            a = int.Parse(s[0]);
            b = int.Parse(s[1]);
            c = int.Parse(s[2]);
            if (a > b && a > c)
            {
                if (b + c > a)
                {
                    Console.WriteLine(a + b + c);
                }
                else
                {
                    Console.WriteLine(2 * b + 2 * c - 1);
                }
            }
            else if (b > a && b > c)
            {
                if (a + c > b)
                {
                    Console.WriteLine(a + b + c);
                }
                else
                {
                    Console.WriteLine(2 * a + 2 * c - 1);
                }
            }
            else if (c > a && c > b)
            {
                if (a + b > c)
                {
                    Console.WriteLine(a + b + c);
                }
                else
                {
                    Console.WriteLine(2 * a + 2 * b - 1);
                }
            }
            else
            {
                Console.WriteLine(a + b + c);
            }
        }
    }
}