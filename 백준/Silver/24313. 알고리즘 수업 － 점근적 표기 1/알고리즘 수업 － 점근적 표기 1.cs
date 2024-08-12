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
            string[] s = Console.ReadLine().Split();
            long a1, a0, c, n0, k = 1;
            a1 = int.Parse(s[0]);
            a0 = int.Parse(s[1]);
            c = int.Parse(Console.ReadLine());
            n0 = int.Parse(Console.ReadLine());

            for (long i =n0; i < 1000;i++)
            {
                if (a1 * i + a0 <= c * i)
                {
                    
                }
                else
                {
                    k = 0;
                    break;
                }
            }
            Console.WriteLine(k);
        }
    }
}