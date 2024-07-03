using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            int max = int.Parse(Console.ReadLine());
            for (int i = 2; i <= 9; i++)
            {
                string kk = Console.ReadLine();
                if (max < int.Parse(kk))
                {
                    max = int.Parse(kk);
                    index = i;
                }
                
            }
            Console.WriteLine(max);
            Console.WriteLine(index);
        }
    }
}