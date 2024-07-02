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
                string[] ss = Console.ReadLine().Split();
                Console.WriteLine("Case #" + (i+1) + ": " + (int.Parse(ss[0]) + int.Parse(ss[1])));
            }
        }
    }
}