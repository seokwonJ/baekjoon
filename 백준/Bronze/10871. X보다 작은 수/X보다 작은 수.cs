using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] aa = new int[10001];
            string[] aaa = Console.ReadLine().Split();
            string[] kk = Console.ReadLine().Split();
            for (int i = 0; i < int.Parse(aaa[0]); i++)
            {
                aa[i] = int.Parse(kk[i]);
                if (aa[i] < int.Parse(aaa[1]))
                {
                    Console.Write(aa[i] + " ");
                }
            }
        }
    }
}