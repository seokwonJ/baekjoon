using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. 입력 받기 (N이 매우 크므로 long 사용)
        if (!long.TryParse(Console.ReadLine(), out long n) || n == 0)
        {
            Console.WriteLine("NO");
            return;
        }

        List<long> factorials = new List<long>();
        long fact = 1;
        factorials.Add(fact); // 0!
        
        for (int i = 1; i <= 20; i++)
        {
            fact *= i;
            if (fact > 1_000_000_000_000_000_000L) break;
            factorials.Add(fact);
        }

        for (int i = factorials.Count - 1; i >= 0; i--)
        {
            if (n >= factorials[i])
            {
                n -= factorials[i];
            }
        }

        if (n == 0) Console.WriteLine("YES");
        else Console.WriteLine("NO");
    }
}