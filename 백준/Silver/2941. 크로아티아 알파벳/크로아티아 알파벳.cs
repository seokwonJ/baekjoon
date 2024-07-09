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
            int i = 0;
            int count = 0;
            while (true)
            {
                if (s[i] == 'c')
                {
                    if (i < s.Length-1)
                    {
                        if (s[i + 1] == '=')
                        {
                            i += 1;
                            count += 1;
                        }
                        else if (s[i + 1] == '-')
                        {
                            i += 1;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }
                    else
                    {
                        count += 1;
                    }
                }
                else if (s[i] == 'd')
                {

                    if (i < s.Length - 1 && s[i + 1] == 'z')
                    {

                        if (i < s.Length-2 && s[i + 2] == '=')
                        {
                            i += 2;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }
                    else if (i < s.Length - 1 &&  s[i+1] == '-')
                    {
                        i += 1;
                        count += 1;
                    }
                    else
                    {
                        count += 1;
                    }
                }
                else if (s[i] == 'l')
                {
                    
                    if (i < s.Length-1&&s[i+1] == 'j')
                    {
                        i += 1;
                        count += 1;
                    }
                    else
                    {
                        count += 1;
                    }
                }
                else if (i < s.Length-1 && s[i] == 'n')
                {
                    if (s[i+1] == 'j')
                    {
                        i += 1;
                        count += 1;
                    }
                    else
                    {
                        count += 1;
                    }
                }
                else if (i < s.Length - 1 && s[i] == 's')
                {
                    if (s[i+1] == '=')
                    {
                        i += 1;
                        count += 1;
                    }
                    else
                    {
                        count += 1;
                    }
                }
                else if (i < s.Length - 1 && s[i] == 'z')
                {
                    if (s[i + 1] == '=')
                    {
                        i += 1;
                        count += 1;
                    }
                    else
                    {
                        count += 1;
                    }
            
                }
                else
                {
                    count += 1;
                }
                if (i == s.Length-1)
                {
                    break;
                }
                else
                {
                    i += 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}        