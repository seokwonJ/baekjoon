using System;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i=0;i < n;i++)
            {
                string[] s = Console.ReadLine().Split();
                for (int k =0; k < s[1].Length;k++)
                {
                    for (int j = 0; j < int.Parse(s[0]); j++)
                    {
                        Console.Write(s[1][k]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}