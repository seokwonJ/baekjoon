using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            Console.WriteLine(long.Parse(s[0]) + long.Parse(s[1]) + long.Parse(s[2]));
        }
    }
}