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
                string ss = Console.ReadLine();
                if (ss != null)
                {
                    string[] s = ss.Split();
                    Console.WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
                }
                else
                {
                    break;
                }
            }
        }
    }
}