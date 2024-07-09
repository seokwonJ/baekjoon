using System;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            float num = 0;
            float eneum = 0;
            for (int i = 0; i < 20; i++)
            {
                string[] s = Console.ReadLine().Split();
                float nn;
                if (s[2]== "A+")
                {
                    num += float.Parse(s[1]) * 4.5f;
                    eneum += float.Parse(s[1]);
                }
                else if (s[2] == "A0")
                {
                    num += float.Parse(s[1]) * 4.0f;
                    eneum += float.Parse(s[1]);
                }
                else if (s[2] == "B+")
                {
                    num += float.Parse(s[1]) * 3.5f;
                    eneum += float.Parse(s[1]);
                }
                else if (s[2] == "B0")
                {
                    num += float.Parse(s[1]) * 3.0f;
                    eneum += float.Parse(s[1]);
                }
                else if (s[2] == "C+")
                {
                    num += float.Parse(s[1]) * 2.5f;
                    eneum += float.Parse(s[1]);
                }
                else if (s[2] == "C0")
                {
                    num += float.Parse(s[1]) * 2.0f;
                    eneum += float.Parse(s[1]);
                }
                else if (s[2] == "D+")
                {
                    num += float.Parse(s[1]) * 1.5f;
                    eneum += float.Parse(s[1]);
                }
                else if (s[2] == "D0")
                {
                    num += float.Parse(s[1]) * 1.0f;
                    eneum += float.Parse(s[1]);
                }
                else if (s[2] == "F")
                {
                    num += float.Parse(s[1]) * 0f;
                    eneum += float.Parse(s[1]);
                }
                else if (s[2] == "P")
                {

                }
            }
            Console.WriteLine(num / eneum);
        }
    }
}        
