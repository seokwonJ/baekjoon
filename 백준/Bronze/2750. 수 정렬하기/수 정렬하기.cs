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
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[1000];
            int minnum =0;

            for (int i=0;i < n;i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i=0;i < n;i++)
            {
                minnum = numbers[i];
                int index = i;
                for (int j =i+1;j < n;j++)
                {
                    if (numbers[j] < minnum)
                    {
                        minnum = numbers[j];
                        index = j;
                    }
                }
                minnum = numbers[index];
                numbers[index] = numbers[i];
                numbers[i] = minnum;
            }
            for (int i =0; i < n;i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}