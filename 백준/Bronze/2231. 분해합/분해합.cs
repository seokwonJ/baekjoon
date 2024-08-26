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
            int sum = 0,kk = 0;
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i <= a; i++)
            {
                sum = 0;
                sum += i;
                int ss = i;
                while (true)
                {
                    if (ss == 0)
                    {
                        break;
                    }
                    sum += ss % 10;
                    ss /= 10;
                }
                if (sum == a)
                {
                    kk = i;
                    break;
                }
            }
            Console.WriteLine(kk);
        }
    }
}