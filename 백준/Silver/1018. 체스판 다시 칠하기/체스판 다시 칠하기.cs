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
            int b = int.Parse(s[1]);
            int count1 = 0, count2 = 0;
            int min = 100000;
            string[] ss = new string[51];

            for (int i=0; i < a;i++)
            {
                ss[i] = Console.ReadLine();
            }

            for (int ee = 0; ee <= a - 8; ee++)
            { 
                for (int ww = 0; ww <= b-8; ww++)
                {
                    count1 = 0;
                    count2 = 0;
                    for (int i = ee; i < 8 + ee; i++)
                    {
                        if (i % 2 == 0)
                        {
                            for (int j = ww; j < 8 + ww; j++)
                            {
                                if (j % 2 == 0)
                                {
                                    if (ss[i][j] == 'B')
                                    {
                                        count1 += 1;
                                    }
                                    if (ss[i][j] == 'W')
                                    {
                                        count2 += 1;
                                    }
                                }
                                if (j % 2 == 1)
                                {
                                    if (ss[i][j] == 'W')
                                    {
                                        count1 += 1;
                                    }
                                    if (ss[i][j] == 'B')
                                    {
                                        count2 += 1;
                                    }
                                }
                            }
                        }
                        else
                        {
                            for (int j = ww; j < 8 + ww; j++)
                            {
                                if (j % 2 == 0)
                                {
                                    if (ss[i][j] == 'W')
                                    {
                                        count1 += 1;
                                    }
                                    if (ss[i][j] == 'B')
                                    {
                                        count2 += 1;
                                    }
                                }
                                if (j % 2 == 1)
                                {
                                    if (ss[i][j] == 'B')
                                    {
                                        count1 += 1;
                                    }
                                    if (ss[i][j] == 'W')
                                    {
                                        count2 += 1;
                                    }
                                }
                            }
                        }
                    }
                    if (count1 < count2)
                    {
                        if (count1 < min)
                        {
                            min = count1;
                        }
                    }
                    else
                    {
                        if (count2 < min)
                        {
                            min = count2;
                        }
                    }
                }
                
            }

            Console.WriteLine(min);
        }
    }
}