using System;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int[] al = new int[26];

            for (int i = 0; i < 26; i++)
            {
                al[i] = -1;
            }
            for (int i=0; i < s.Length;i++)
            {
               
                if(al[s[i] -'a'] == -1)
                {
                    al[s[i] - 'a'] = i;
                }
            }
            
            for (int i =0; i < 26;i++)
            {
                Console.Write(al[i] + " ");
            }
        }
    }
}