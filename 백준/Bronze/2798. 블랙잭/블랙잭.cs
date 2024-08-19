using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,sum=0, fix;
            
            string[] s = Console.ReadLine().Split();
            a = int.Parse(s[0]);
            b = int.Parse(s[1]);
            string[] ss = Console.ReadLine().Split();
            for (int i =0;i  < a-2; i++)
            {
                for (int j = i+1;j < a-1;j++)
                {
                    for (int u = j+1;u < a; u++)
                    {
                        int num = int.Parse(ss[i]) + int.Parse(ss[j]) + int.Parse(ss[u]);
                        if (num > sum && num <= b)
                        {
                            sum = num;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}