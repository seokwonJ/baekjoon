using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string[] s = Console.ReadLine().Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                if (a == 0 && b == 0)
                {
                    break;
                }
                if (a > b)
                {
                    if (a % b == 0)
                    {
                        Console.WriteLine("multiple");
                    }
                    else
                    {
                        Console.WriteLine("neither");
                    }
                }
                else if (a < b)
                {
                    if (b % a == 0)
                    {
                        Console.WriteLine("factor");
                    }
                    else
                    {
                        Console.WriteLine("neither");
                    }
                }
            }
        }
    }
}        