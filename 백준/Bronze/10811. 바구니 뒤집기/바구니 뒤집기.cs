using System;
using System.Diagnostics.PerformanceData;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = new int[101];
            string[] s = Console.ReadLine().Split();
            int aa = int.Parse(s[0]);
            int bb = int.Parse(s[1]);
            for (int i = 1; i <= aa; i++)
            {
                a[i] = i;
            }

            for (int i = 0; i < bb; i++)
            {
                string[] ss = Console.ReadLine().Split(); 
                int q = int.Parse(ss[0]);
                int w = int.Parse(ss[1]);
                
                for (int j = 0; j <= (w-q)/2;j++)
                {
                    int kk = a[q+j];
                    a[q+j] = a[w-j];
                    a[w - j] = kk;
                }
            }
            for (int i = 1; i <= aa;i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}