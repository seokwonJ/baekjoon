using System;

namespace hello
{
    class h
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string s = Console.ReadLine();
                if (s == "-1 -1 -1 -1") break;
                string[] ss = s.Split();
                long[] num = Array.ConvertAll(ss, long.Parse);
                double personNow = num[0] * num[2] + num[3];
                double forPersonNow = 0;
                double totalPlayCount = 1;
                totalPlayCount *= num[1] * (num[1] - 1) / 2;
                totalPlayCount *= num[0];

                double powNum = Math.Pow(2, 65);

                for (double i = 1; i <= powNum; i *= 2)
                {
                    if (i >= personNow)
                    {
                        forPersonNow = i;
                        break;
                    }
                }
                for (double i = forPersonNow / 2; i >= 1; i /= 2)
                {
                    totalPlayCount += i;
                }
                forPersonNow = forPersonNow - personNow;

                Console.WriteLine(num[0] + "*" + num[2] + "/" + num[1] + "+" + num[3] + "=" + totalPlayCount + "+" + forPersonNow);
            }
        }
    }
}