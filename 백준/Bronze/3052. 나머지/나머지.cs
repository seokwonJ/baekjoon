using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = new int[42];
            int count = 0;
            for (int i = 0; i <= 41; i++)
            {
                a[i] = 0;
            }

            for (int i = 0; i < 10; i++)
            {
                int s = int.Parse(Console.ReadLine());
                a[s%42] = 1;
            }
            for (int i = 0; i <= 41;i++)
            {
                if (a[i] == 1)
                {
                    count += 1;
                   
                }
            }
            Console.WriteLine(count);
        }
        
    }
}