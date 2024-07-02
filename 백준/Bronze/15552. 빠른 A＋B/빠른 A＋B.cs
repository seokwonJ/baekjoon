using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string s = Console.ReadLine();
            int a = int.Parse(s);
            for (int i =0; i < a;i++)
            {
                string[] num = Console.ReadLine().Split();
                sb.Append(int.Parse(num[0]) + int.Parse(num[1]) + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}