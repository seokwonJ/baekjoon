using System;

namespace hello
{
    class h
    {
        static void Main(string[] args)
        {
            string[] s = new string[4];
            int count = 0;
            s[0] = "ABCD";
            s[1] = "EFGH";
            s[2] = "IJKL";
            s[3] = "MNO.";
            string[] stringInput = new string[4];
            for (int i = 0; i < 4; i++)
            {
                stringInput[i] = Console.ReadLine();
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    bool find = false;
                    if (stringInput[i][j] == '.') continue;

                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            if (stringInput[i][j] ==s[k][l])
                            {
                                find = true;
                                count += Math.Abs(k - i) + Math.Abs(l - j);
                                break;
                            }
                        }
                        if (find) break;
                    }

                }
            }
            Console.WriteLine(count);
        }
    }
}