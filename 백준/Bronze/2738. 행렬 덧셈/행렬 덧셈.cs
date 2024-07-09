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
            int[,] aa = new int[101,101];
            int[,] bb = new int[101, 101];
            for (int i =0;i < int.Parse(s[0]);i++)
            {
                string[] ss = Console.ReadLine().Split();
                for (int j = 0; j < int.Parse(s[1]);j++)
                {
                    aa[i, j] = int.Parse(ss[j]); 
                }
            }
            for (int i = 0; i < int.Parse(s[0]); i++)
            {
                string[] ss = Console.ReadLine().Split();
                for (int j = 0; j < int.Parse(s[1]); j++)
                {
                    bb[i, j] = int.Parse(ss[j]) + aa[i,j];
                }
            }

            for (int i = 0; i < int.Parse(s[0]); i++)
            {
                for (int j = 0; j < int.Parse(s[1]); j++)
                {
                    Console.Write(bb[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}        
