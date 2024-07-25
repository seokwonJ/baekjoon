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
            while(true)
            {
                int nn = 0;
                if(n==1)
                {
                    break;
                }
                for (int i = 2; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        n /= i;
                        Console.WriteLine(i);
                        break;
                    }
                    if (i == n)
                    {
                        nn = 1;
                        Console.WriteLine(n);
                    }
                }
                if (nn == 1)
                {
                    break;
                }
            }

        }
    }
}        