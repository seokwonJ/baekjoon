using System;

namespace hello
{
    class h
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                int s = int.Parse(Console.ReadLine());
                string[] ss = Console.ReadLine().Split();
                int[] ii = Array.ConvertAll(ss, int.Parse);
                string[] ss2 = Console.ReadLine().Split();
                int[] ii2 = Array.ConvertAll(ss2, int.Parse);
                for (int l = 0; l < s; l++)
                {
                    for (int j = 0; j < s; j++)
                    {
                        if (ii[l] + 1000 == ii2[j])
                        {
                            count++;
                            break;
                        }
                    }
                }
                Console.WriteLine(count/2);
            }
        }
    }
}