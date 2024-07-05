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
            string si = Console.ReadLine();
            int sii = int.Parse(si);
            Console.WriteLine(s[sii-1]);
        }
    }
}