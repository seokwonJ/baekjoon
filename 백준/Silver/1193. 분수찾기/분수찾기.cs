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
            int num = 0, num1 = 0,count=0;
            int leftnum , rightnum;
            int input = int.Parse(Console.ReadLine());
            int numb = 0;
            while (true)
            {

                num += 1;
                if (num % 2 == 0)
                {
                    leftnum = 1;
                    rightnum = num;
                }
                else
                {
                    leftnum = num;
                    rightnum = 1;
                }


                for (int i =1; i <= num;i++)
                {   count += 1;
                    if (count == input)
                    {
                        numb = 1;
                        break;
                    }
                    if (num % 2 == 0)
                    {
                        leftnum += 1;
                        rightnum -= 1;
                    }
                    else
                    {
                        leftnum -= 1;
                        rightnum += 1;
                    }
                }

                if (numb == 1)
                {
                    break;
                }
            }
            Console.WriteLine(leftnum + "/" + rightnum);
        }
    }
}        