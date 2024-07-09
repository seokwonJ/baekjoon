using System;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int bignum = -1;
            int bigR = 0;
            int bigC = 0;
            for (int i = 0; i < 9; i++)
            {
                string[] s = Console.ReadLine().Split();
                for (int j = 0; j < 9; j++)
                {
                    if (int.Parse(s[j]) > bignum)
                    {
                        bignum = int.Parse(s[j]);
                        bigR = i + 1;
                        bigC = j + 1;
                    }
                }
            }
            Console.WriteLine(bignum);
            Console.WriteLine(bigR + " " + bigC);
        }
    }
}        
