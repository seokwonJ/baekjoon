using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);
            for (int i =0; i < a/4; i++)
            {
                Console.Write("long ");
            }
            Console.WriteLine("int");
        }
    }
}