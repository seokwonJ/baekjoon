using System;

namespace hello
{
    class h
    {
        static void Main(string[] args)
        {
            bool isUp = false;
            bool isDown = false;

            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int[] a = Array.ConvertAll(s, int.Parse);

            isUp = true;
            int nowNum = a[0];
            int moutainLength = 1;
            int maxLength = 1;
            for (int i = 1; i < n; i++)
            {
                if (moutainLength > maxLength) maxLength = moutainLength;
                if (isUp)
                {
                    if (a[i] > nowNum)
                    {
                        moutainLength++;
                        nowNum = a[i];
                    }
                    else if (a[i] == nowNum)
                    {
                        moutainLength = 1;
                    }
                    else
                    {
                        isUp = false;
                        nowNum = a[i];
                        moutainLength++;
                    }
                }
                else
                {
                    if (a[i] > nowNum)
                    {
                        isUp = true;
                        nowNum = a[i];
                        moutainLength = 2;
                    }
                    else if (a[i] == nowNum)
                    {
                        moutainLength = 1;
                    }
                    else
                    {
                        moutainLength++;
                        nowNum = a[i];
                    }
                }
                if (moutainLength > maxLength) maxLength = moutainLength;
            }
            Console.WriteLine(maxLength);
        }
    }
}