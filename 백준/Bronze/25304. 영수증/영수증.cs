using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int b = 0;
            string ss = Console.ReadLine();
            int a = int.Parse(s);
            int aa = int.Parse(ss);
            for (int i=0; i < aa;i++)
            {
                string[] sss = Console.ReadLine().Split();
                int q = int.Parse(sss[0]);
                int qq = int.Parse(sss[1]);
                b += q * qq;
            }
            if (b == a)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}