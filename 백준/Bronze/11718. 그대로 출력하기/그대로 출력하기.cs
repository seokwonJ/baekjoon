using System;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string s = Console.ReadLine();
                if (s != null)
                {
                    Console.WriteLine(s);
                }
                else
                {
                    break;
                }
            }
        }
    }
}