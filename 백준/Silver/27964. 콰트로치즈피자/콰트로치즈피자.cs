using System;
using System.Collections.Generic;

namespace hello
{
    class h
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> li = new List<string>();

            string[] s = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                string ss = s[i];

                if (ss.Length >= 6)
                {
                    if ("Cheese" == ss.Substring(ss.Length - 6) && !li.Contains(ss))
                    {
                        li.Add(ss);
                    }
                }
            }
            if (li.Count >= 4) Console.WriteLine("yummy");
            else Console.WriteLine("sad");
        }
    }
}