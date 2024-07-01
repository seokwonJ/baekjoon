using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);

            if (a == b && b == c )
            {
                Console.WriteLine(10000+ a * 1000);
            }
            else if (a == b  && b != c)
            {
                Console.WriteLine(1000 + a * 100);
            }
            else if (a != b && b == c)
            {
                Console.WriteLine(1000 + b * 100);
            }
            else if (a == c && b != c)
            {
                Console.WriteLine(1000 + a * 100);
            }
            else
            {
                if(a > b && b > c)
                {
                    Console.WriteLine(a*100);
                }
                else if (a > c && c > b)
                {
                    Console.WriteLine(a * 100);
                }
                else if (b > a && a > c)
                {
                    Console.WriteLine(b * 100);
                }
                else if (b > c && c > a)
                {
                    Console.WriteLine(b * 100);
                }
                else if (c > b && b > a)
                {
                    Console.WriteLine(c * 100);
                }
                else if (c > a && a > b)
                {
                    Console.WriteLine(c * 100);
                }
            }
        }
    }
}