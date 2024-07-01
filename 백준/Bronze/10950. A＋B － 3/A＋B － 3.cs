using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);
            for (int i =1; i <= a;i++)
            {
                string[] ss = Console.ReadLine().Split();
                int aa = int.Parse(ss[0]);
                int bb = int.Parse(ss[1]);

                Console.WriteLine(aa + bb);
            }
        }
    }
}