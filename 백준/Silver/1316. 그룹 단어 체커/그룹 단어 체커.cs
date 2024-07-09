using System;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i =0; i < n;i++)
            {
                string s = Console.ReadLine();
                int[] aa = new int[26];
                int num = 0;
                for (int j = 0; j < 26; j++)
                {
                    aa[j] = 0;
                }
                char nd = '3';
                for (int k = 0; k < s.Length;k++)
                {
                    if (nd == s[k])
                    {
                        continue;
                    }
                    else
                    {
                        if (aa[s[k] - 'a'] == 0)
                        {
                            aa[s[k] - 'a'] = 1;
                        }
                        else
                        {
                            num = 1;
                        }
                        nd = s[k];
                    }
                }
                if (num == 0)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}        
