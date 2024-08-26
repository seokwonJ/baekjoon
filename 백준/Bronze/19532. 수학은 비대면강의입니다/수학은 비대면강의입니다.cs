using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.PerformanceData;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int d = int.Parse(s[3]);

            int b = int.Parse(s[1]); 
            int f = int.Parse(s[4]);

            int c = int.Parse(s[2]); 
            int g = int.Parse(s[5]);

            int qq = 0, ww = 0;

            for (int i = -999; i <= 999;i++)
            {
                bool ok = false;
                for (int j = -999; j <= 999; j++)
                {
                    if(a*i + b*j == c && d*i + f*j == g)
                    {
                        ok = true;
                        qq = i;
                        ww = j;
                        break;
                    }
                }
                if (ok == true)
                {
                    break;
                }
            }
            Console.WriteLine(qq + " " + ww);
        }
    }
}