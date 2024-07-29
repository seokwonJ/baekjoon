using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1=0, a2=0, b1=0, b2=0;
            int q, w;
            for (int i =0;i < 3;i++)
            {
                string[] s = Console.ReadLine().Split();
                q = int.Parse(s[0]);
                w = int.Parse(s[1]);
                if (a1 == q)
                {
                    a1 = -1;
                }
                else if (a2 == q)
                {
                    a2 = -1;
                }
                else if (a1 == 0)
                {
                    a1 = q;
                }
                else if (a2 == 0)
                {
                    a2 = q;
                }
                if (b1 == w)
                {
                    b1 = -1;
                }
                else if (b2 == w)
                {
                    b2 = -1;
                }
                else if (b1 == 0)
                {
                    b1 = w;
                }
                else if (b2 == 0)
                {
                    b2 = w;
                }

            }
            
            if (a1 == -1)
            {
                Console.Write(a2 + " ");
            }
            if (a2 == -1)
            {
                Console.Write(a1 + " ");
            }
            if (b1 == -1)
            {
                Console.Write(b2);
            }
            if (b2 == -1)
            {
                Console.Write(b1);
            }
        }
    }
}