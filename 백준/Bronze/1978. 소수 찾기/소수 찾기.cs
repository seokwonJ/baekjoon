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

            int n = int.Parse(Console.ReadLine());
            int count = 0;
            string[] kk = Console.ReadLine().Split();
            for (int i =0; i < n;i++)
            {
                int k = int.Parse(kk[i]);
                int cont2 = 0;
                for (int j = 1; j <  k/2+1;j++)
                {
                    if (k % j == 0)
                    {
                        cont2 += 1;
                    }
                }
                if (cont2 == 1)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
            
        }
    }
}        