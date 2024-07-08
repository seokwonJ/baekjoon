using System;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int count = 1;
            for (int i=0;i < s.Length/2;i++)
            {
                if (s[i] != s[s.Length-1-i])
                {
                    count = 0;
                }
            }
            Console.WriteLine(count);
        }
    }
}        