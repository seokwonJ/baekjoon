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
            int[,] aaa = new int[101,101];
            int count = 0;
            int nn = int.Parse(Console.ReadLine());
            for (int i=0;i < nn;i++)
            {
                string[] s = Console.ReadLine().Split();
                int aa = int.Parse(s[0]);
                int bb = int.Parse(s[1]);

                for (int j=aa;j < aa+10;j++)
                {
                    for (int q = bb; q < bb + 10; q++)
                    {
                        aaa[j, q] = 1;   
                    }
                }
            }
            for (int i =0; i < 101;i++)
            {
                for (int j = 0; j < 101; j++)
                {
                    if (aaa[i,j] == 1)
                    {
                        count += 1;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}        