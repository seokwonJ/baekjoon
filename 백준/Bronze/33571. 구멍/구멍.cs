using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        if (s == null) return;

        int count = 0;

        foreach (char c in s)
        {
            // 구멍이 2개인 경우 (대문자 B만 해당)
            if (c == 'B')
            {
                count += 2;
            }
            // 구멍이 1개인 경우
            // 대문자: A, D, O, P, Q, R
            // 소문자: a, b, d, e, g, o, p, q (b도 1개로 포함!)
            // 특수문자: @
            else if ("ADOPQRabdegopq@".IndexOf(c) >= 0)
            {
                count += 1;
            }
            // 나머지는 0개 (C, c, f, i, j, k, l, m, n, s, t, u, v, w, x, y, z 등)
        }

        Console.WriteLine(count);
    }
}