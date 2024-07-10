using System;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int kk = 0;
            string[] s = new string[5];
            for (int i =0; i < 5;i++)
            {
                string ss = Console.ReadLine();
                s[i] = ss;
            }
            while(true)
            {
                int dddd = 0;
                for (int i=0;i < 5;i++)
                {
                    if (kk < s[i].Length)
                    {
                        Console.Write(s[i][kk]);
                        dddd = 1;
                    }
                }
                if (dddd == 0)
                {
                    break;
                }
                kk += 1;
            }
        }
    }
}        