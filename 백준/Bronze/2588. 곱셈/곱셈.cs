using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int ss = int.Parse(s1);
            int sss = int.Parse(s2);
            int ssss = 0;
            ssss += ss * (sss % 10);
            ssss += ss * ((sss / 10) % 10) * 10;
            ssss += ss * (sss / 100) * 100;
            Console.WriteLine(ss * (sss % 10));
            Console.WriteLine(ss * ((sss/10)%10));
            Console.WriteLine(ss * (sss / 100));
            Console.WriteLine(ssss);
        }
    }
}