using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);

            if (a >= 90)
            {
                Console.WriteLine("A");
            }
            else if (a >= 80)
            {
                Console.WriteLine("B");
            }
            else if (a >= 70)
            {
                Console.WriteLine("C");
            }
            else if (a >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.Write("F");
            }
        }
    }
}