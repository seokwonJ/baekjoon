using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.PerformanceData;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2;
            string[] ss = Console.ReadLine().Split();

            n1 = int.Parse(ss[0]);
            n2 = int.Parse(ss[1]);

            int[] a = new int[1000];

            string[] sss = Console.ReadLine().Split();

            for (int i=0;i < n1;i++)
            {
                a[i] = int.Parse(sss[i]);
            }
            
            for (int i=0; i < n1;i++)
            {
                int max = a[i];
                int maxIndex=i;
                for (int j = i + 1; j < n1; j++)
                {
                    if (a[j] > max)
                    {
                        max = a[j];
                        maxIndex = j;
                    }
                }
                int aa = a[i];
                a[i] = a[maxIndex];
                a[maxIndex] = aa;
            }
            Console.Write(a[n2-1]);
        }
    }
}