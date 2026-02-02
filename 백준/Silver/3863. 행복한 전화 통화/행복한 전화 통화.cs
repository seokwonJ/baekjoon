using System;
using System.Collections.Generic;

namespace hello
{
    class h
    {
        static void Main(string[] arg)
        {
            while (true)
            {
                string[] s = Console.ReadLine().Split();
                int n = int.Parse(s[0]);
                int m = int.Parse(s[1]);

                if (n == 0 && m == 0) break;

                List<long> li = new List<long>();
                List<long> li2 = new List<long>();

                for (int i = 0; i < n; i++)
                {
                    string[] ss = Console.ReadLine().Split();
                    li.Add(long.Parse(ss[2]));
                    li2.Add(long.Parse(ss[3]));
                }

                for (int j = 0; j < m; j++)
                {
                    string[] ss = Console.ReadLine().Split();
                    int num = 0;
                    for (int jj = 0; jj < li2.Count; jj++)
                    {
                        if (li[jj] + li2[jj] > long.Parse(ss[0]) && li[jj] < long.Parse(ss[0]) + long.Parse(ss[1])) num++;
                    }
                    Console.WriteLine(num);
                }
            }
        }
    }
}