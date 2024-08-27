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
            int n,count=0,num=666;
            n = int.Parse(Console.ReadLine());
            while(true)
            {
                int sixcount =0;
                int lnum = num;
                while(true)
                {
                   if (lnum % 10 == 6)
                    {
                        sixcount += 1;
                    }
                   else
                    {
                        sixcount = 0;
                    }
                    
                    lnum /= 10;
                    
                    if (sixcount == 3)
                    {
                        count += 1;
                        break;
                    }

                    if (lnum == 0)
                    {
                        break;
                    }
                    
                }
                if (count == n)
                {
                    Console.WriteLine(num);
                    break;
                }
                num += 1;
            }
        }
    }
}