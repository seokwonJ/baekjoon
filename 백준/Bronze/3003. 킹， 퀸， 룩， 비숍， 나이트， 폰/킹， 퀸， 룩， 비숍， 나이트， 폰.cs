using System;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            for (int i=0; i<  6;i++)
            {
                if (i < 2)
                {
                    Console.Write(1 - int.Parse(s[i]) + " ");
                }
                else if (i < 5)
                {
                    Console.Write(2 - int.Parse(s[i]) + " ");
                }
                else if (i == 5)
                {
                    Console.Write(8 - int.Parse(s[i]) + " ");
                }
            }
        }
    }
}        
