using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aa = new int[101];
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            for (int i =1; i <= a;i++)
            {
                aa[i] = i;
            }
            for (int i =0; i < b;i++)
            {
                string[] ss = Console.ReadLine().Split();
                int q = int.Parse(ss[0]);
                int w = int.Parse(ss[1]);
                int kk = aa[q];
                aa[q] = aa[w];
                aa[w] = kk;
            }
            for (int i=1;i <= a;i++)
            {
                Console.Write(aa[i] + " ");
            }
        }
    }
}