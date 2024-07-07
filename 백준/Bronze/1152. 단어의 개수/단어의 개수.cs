using System;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string[] s = Console.ReadLine().Split();
            for(int i=0; i < s.Length;i++)
            {
                if (s[i] != "")
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}