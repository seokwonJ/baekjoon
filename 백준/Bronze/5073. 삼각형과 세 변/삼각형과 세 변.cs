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
            while(true)
            {
                string[] s = Console.ReadLine().Split();
                int a, b, c;
                a = int.Parse(s[0]);
                b = int.Parse(s[1]);
                c = int.Parse(s[2]);
                if (a == 0 && b == 0 && c == 0)
                {
                    break;
                }
                if (a == b && b == c && a == c)
                {
                    Console.WriteLine("Equilateral");
                }
                else if (a != b && b != c && a != c)
                {
                    if ((a > b && a > c) && a >= (b + c))
                    {
                        Console.WriteLine("Invalid");
                    }
                    else if ((b > a && b > c) && b >= (a + c))
                    {
                        Console.WriteLine("Invalid");
                    }
                    else if ((c > a && c > b) && c >= (a + b))
                    {
                        Console.WriteLine("Invalid");
                    }
                    else
                    {
                        Console.WriteLine("Scalene");
                    }
                    
                }
                else
                {
                    if ((a > b && a > c) && a >= (b + c))
                    {
                        Console.WriteLine("Invalid");
                    }
                    else if ((b > a && b > c) && b >= (a + c))
                    {
                        Console.WriteLine("Invalid");
                    }
                    else if ((c > a && c > b) && c >= (a + b))
                    {
                        Console.WriteLine("Invalid");
                    }
                    else
                    {
                        Console.WriteLine("Isosceles");
                    }

                }
            }
        }
    }
}