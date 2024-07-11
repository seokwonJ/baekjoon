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
            long a = 1;
            long num = 0;
            for (int i= s[0].Length - 1; i >=0;i--)
            {
                if (0 <= s[0][i] - '0' && s[0][i]- '0' <= 9)
                {
                    num += a * (s[0][i] - '0');
                }
                else
                {
                    num += a * (s[0][i] - 'A' + 10);
                }
                a *= int.Parse(s[1]);
            }
            Console.WriteLine(num);
        }
    }
}        