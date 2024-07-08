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
            int[] aa = new int[200];
            int count = 0;
            int count2 = 0;
            int ss = 0;

            for (int i = 0; i < 200;i++)
            {
                aa[i] = 0;
            }
            for (int i =0;i < s.Length;i++)
            {
                if (s[i] - 'a' >= 0)
                {
                    aa[s[i]  - 'a'] += 1;
                }
                else
                {
                    aa[s[i] - 'A'] += 1;
                }
            }
            for (int i =0; i < 26; i++)
            {
                if (aa[i] > count)
                {
                    count = aa[i];
                    count2 = 0;
                    ss = i;
                }
                else if (aa[i] == count)
                {
                    count2 += 1;
                }
            }
            if (count2 >= 1)
            {
                Console.WriteLine("?");
            }
            else
            {
                Console.WriteLine((char)('A' + ss));
            }
        }
    }
}        