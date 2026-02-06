using System;

namespace hello
{
    class h
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] argss = Console.ReadLine().Split();
            long now = 0;
            long total = 0;
            for (int i = 0; i < n; i++)
            {
                if (argss[i] == "0") --now;
                else if (argss[i] == "1") ++now;
                total += now;
            }
            Console.WriteLine(total);
        }
    }
}