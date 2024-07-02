using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                String[] s = Console.ReadLine().Split();
                if (s[0] == "0" && s[1] == "0") break;
                Console.WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
            }
        }
    }
}