using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);
            int b = 0;
            for (int i =1; i <= a;i++)
            {
                b += i;   
            }
            Console.WriteLine(b);
        }
    }
}