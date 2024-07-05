using System;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int ss = int.Parse(Console.ReadLine());
            for(int i =0; i < ss;i++)
            {
                string s = Console.ReadLine();
                Console.WriteLine(s[0] +"" + s[s.Length - 1]);
            }
        }
    }
}