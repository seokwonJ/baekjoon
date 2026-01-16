using System;

namespace hello
{
    class h
    {
        static void Main(string[] args)
        {
            int[] aa = new int[100];
            int[] sss = new int[10];
            int n = int.Parse(Console.ReadLine());
            string[] aaa = Console.ReadLine().Split();
            aa = Array.ConvertAll(aaa, int.Parse);

            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (aa[j] > aa[i]) count++;

                }
                if (count < 4) sss[0]++;
                else if (count < 11) sss[1]++;
                else if (count < 23) sss[2]++;
                else if (count < 40) sss[3]++;
                else if (count < 60) sss[4]++;
                else if (count < 77) sss[5]++;
                else if (count < 89) sss[6]++;
                else if (count < 96) sss[7]++;
                else if (count < 100) sss[8]++;
            }

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(sss[i]);
            }
            Console.Write(sss[8]);
        }
    }
}
