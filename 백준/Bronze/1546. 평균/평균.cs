using System;
using System.Diagnostics.PerformanceData;
using System.Runtime.InteropServices;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            float[] aa = new float[1001];
            float max = 0;
            float avg = 0;
            string[] ss = Console.ReadLine().Split();
            for (int i =0;i < num;i++)
            {
                aa[i] = float.Parse(ss[i]);
                if (aa[i] > max)
                {
                    max = aa[i];
                }
            }
            for (int i=0; i<num;i++)
            {
                avg += aa[i] / max * 100;
            }
            Console.WriteLine(avg/num);
        }
        
    }
}