using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                for (int j= 0; j < a-i-1;j++)
                {
                    Console.Write(" ");
                }
                for (int j =0; j < i+1;j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}