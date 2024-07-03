using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] aa = new int[10001];
            string aaa = Console.ReadLine();
            string[] kk = Console.ReadLine().Split();
            int min = 1000001;
            int max = -1000001;
            for (int i = 0; i < int.Parse(aaa); i++)
            {
                
                if (max < int.Parse(kk[i]))
                {
                    max = int.Parse(kk[i]);
                }
                if (int.Parse(kk[i]) < min)
                {
                    min = int.Parse(kk[i]);
                }
            }
            Console.WriteLine(min + " " + max);
        }
    }
}