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
            int count = 0;
            int num = 0;
            for (int i=1; i <= a;i++)
            { 
                if (a%i == 0)
                {
                    count += 1;
                    num = i;
                }
                if (count == b)
                {
                    break;
                }
            }
            if (count < b)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
}        