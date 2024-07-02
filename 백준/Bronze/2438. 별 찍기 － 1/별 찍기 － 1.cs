using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);
            for (int i =0; i < a;i++)
            {
                for (int j = 0; j <=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}