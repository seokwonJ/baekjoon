using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.PerformanceData;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int a = n / 5;
            int b = 0;
            while (true)
            {
                if (a == -1)
                {
                    break;
                }
                if (a*5 == n)
                {
                    count = a;
                    break;
                }
                else
                {
                    if (((n-(5*a)) % 3 == 0))
                    {
                        count = a + (n - (5 * a)) / 3;
                        break;
                    }
                }
                a -= 1;
            }
            if (count == 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(count);
            }
        }
    }
}