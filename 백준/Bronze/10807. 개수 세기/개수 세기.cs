using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] aa = new int[101];
            int a = int.Parse(Console.ReadLine());
            string[] kk = Console.ReadLine().Split();
            for (int i = 0; i < a;i++)
            {
                aa[i] = int.Parse(kk[i]) ;
            }
            int k = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i =0; i < a;i++)
            {
                if (aa[i] == k)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}