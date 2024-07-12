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
            long a = long.Parse(s[0]);
            long k = 1;
            long num = long.Parse(s[1]);
            string ss = "";
            while (true)
            {
                if(a < k)
                {
                    break;
                }
                k *= num;
            }
            k = k / num; 
            while(true)
            {
                if (a/k >= 10)
                {
                    ss = ss + (char)(a / k - 10 + 'A');
                }
                else
                {
                    ss = ss + (char)('0' + a / k);
                }
                a = a % k;
                k = k / num;
                if (k == 0)
                {
                    break;
                }
            }
            Console.WriteLine(ss);
        }
    }
}        