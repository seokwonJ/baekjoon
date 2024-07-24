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
            int a, b, sum = 0, small = 0;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            for (int i =a; i <= b;i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count += 1;
                    }
                }
                if (count == 2)
                {
                    if (sum == 0)
                    {
                        small = i;
                    }
                    sum += i;
                }
            }
            if (sum == 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(sum);
                Console.WriteLine(small);
            }
        }
    }
}        