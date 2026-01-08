using System;

namespace hello {
    class h {
        static void Main (string[] args) {
            int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string s11 = Console.ReadLine();
    string s22 = Console.ReadLine();
    char[] s1 = s11.ToCharArray();
    char[] s2 = s22.ToCharArray();

    int count = 0;

    if (s1.Length == 0) count = s2.Length;
    else if (s2.Length == 0) count = s1.Length;
    else
    {
        for (int j = 0; j < s1.Length; j++)
        {
            bool isFindSameWord = false;
            for (int k = 0; k < s2.Length; k++)
            {
                if (s1[j] == s2[k])
                {
                    s2[k] = '*';
                    s1[j] = '*';
                    isFindSameWord = true;
                    break;
                }
            }
            if (!isFindSameWord) count++;
        }
        for (int j = 0; j < s2.Length; j++)
        {
            bool isFindSameWord = false;
            if (s2[j] == '*') continue;
            for (int k = 0; k < s1.Length; k++)
            {
                if (s2[j] == s1[k])
                {
                    isFindSameWord = true;
                    break;
                }
            }
            if (!isFindSameWord) count++;
        }
    }

    Console.WriteLine("Case #" + (i + 1) + ": " + count);
}
        }
    }
}