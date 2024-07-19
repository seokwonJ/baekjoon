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
            while (true)
            {
                List<int> il = new List<int>();
                string s = Console.ReadLine();
                int a = int.Parse(s);
                int count = 0;
                int num = 0;
                if (a == -1)
                {
                    break;
                }
                for (int i = 1; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        count += 1;
                        num += i;
                        il.Add(i);
                    }
                } 
                if (num == a)
                {
                    Console.Write(num + " = ");
                    for (int i = 0; i < il.Count; i++)
                    {   
                        if (i != il.Count-1)
                        {
                            Console.Write(il[i] + " + ");
                        }
                        else
                        {
                            Console.WriteLine(il[i]);
                        }
                    }
                }
                else
                {
                    Console.WriteLine(a + " is NOT perfect.");
                }
            }
        }
    }
}        