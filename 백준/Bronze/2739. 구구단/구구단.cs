using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);
            for (int i =1; i <= 9;i++)
            {
                Console.WriteLine(a + " * " + i + " = " + a * i);
            }
        }
    }
}