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
            int a=0, b=0, c=0, d=0;
            int n = int.Parse(Console.ReadLine());
            for (int i =0; i < n;i++)
            {
                int nn = int.Parse(Console.ReadLine());
                Console.WriteLine(nn / 25 + " " + (nn % 25) / 10 + " " + ((nn % 25) % 10) / 5 + " " + (((nn % 25) % 10) % 5) / 1);
            }
        }
    }
}        