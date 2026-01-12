using System;
using System.Collections.Generic;

namespace hello
{
    class h
    {
        static void Main(string[] args)
        {
            string sL = "LOVE";
            string s = Console.ReadLine();
            int[] alphaNum = new int[26];

            for (int l = 0; l < sL.Length; l++)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (sL[l] == s[i])   alphaNum[sL[l] - 'A']++;
                }
            }

            int n = int.Parse(Console.ReadLine());
            string win = "";
            int winPercent = 0;

            List<string> sss = new List<string>();

            for (int i = 0; i < n; i++)
            {
                int[] alphaN = new int[26];

                string ss = Console.ReadLine();

                for (int j = 0; j < sL.Length; j++)
                {

                    alphaN[sL[j] - 'A'] += alphaNum[sL[j] - 'A'];

                    for (int k = 0; k < ss.Length; k++)
                    {
                        if (sL[j] == ss[k]) alphaN[ss[k] - 'A']++;
                    }
                }
                int percent = 1;
                for (int k = 0; k < sL.Length; k++)
                {
                    for (int j = k + 1; j < sL.Length; j++)
                    {
                        percent *= (alphaN[sL[k] - 'A'] + alphaN[sL[j] - 'A']);
                    }
                }
                percent %= 100;
                if (percent > winPercent)
                {
                    sss = new List<string>();
                    sss.Add(ss);
                    winPercent = percent;
                }
                else if (percent == winPercent)
                {
                    win = ss;
                    sss.Add(ss);
                }
            }
            sss.Sort();

            Console.WriteLine(sss[0]);
        }
    }
}