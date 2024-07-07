using System;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 0;
            string s = Console.ReadLine();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'Z' || s[i] == 'Y') {
                    time += 10;
                }
                else if(s[i] == 'S') {
                    time += 8;
                }
                else if (s[i] == 'V')
                {
                    time += 9;
                }
                else
                {
                    time += ((s[i] - 'A') / 3) + 3;
                }
            }
            Console.WriteLine(time);
        }
    }
}