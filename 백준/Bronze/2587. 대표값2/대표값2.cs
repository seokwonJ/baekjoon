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
            int sum = 0;
            int[] a = new int[5];
            for (int i=0;i < 5;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                sum += a[i];
            }
            
            for (int i=0; i < 5;i++)
            {
                int min = a[i];
                int minindex=i;
                for (int j = i + 1; j < 5; j++)
                {
                    if (a[j] < min)
                    {
                        min = a[j];
                        minindex = j;
                    }
                }
                int aa = a[i];
                a[i] = a[minindex];
                a[minindex] = aa;
            }
            Console.WriteLine(sum/5);
            Console.Write(a[2]);
        }
    }
}