using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = new int[31];

            for (int i = 1; i <= 30; i++)
            {
                a[i] = 0;
            }

            for (int i = 0; i < 28; i++)
            {
                int s = int.Parse(Console.ReadLine());
                a[s] = 1;
            }
            for (int i = 1; i<=30;i++)
            {
                if (a[i] != 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
        
    }
}