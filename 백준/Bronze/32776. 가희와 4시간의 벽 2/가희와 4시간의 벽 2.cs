using System;

namespace hello
{
    class h
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int nn = 0;
            for (int i = 0; i < 3; i++)
            {
                nn += int.Parse(s[i]);
            }
            if (n <= nn || n <= 240) Console.WriteLine("high speed rail");
            else if (n >= nn) Console.WriteLine("flight");

        }
    }
}