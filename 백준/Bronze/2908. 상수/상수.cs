using System;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int ii = 0;
            string[] s = Console.ReadLine().Split();
            for (int i=2; i >= 0;i--)
            {
                if (s[0][i] - '0' > s[1][i] - '0')
                {
                    ii = 0;
                    break;
                }
                else if (s[0][i] - '0' < s[1][i] - '0')
                {
                    ii = 1;
                    break;
                }
            }

            for (int i =2; i >= 0; i--)
            {
                Console.Write(s[ii][i]);
            }
            
        }
    }
}