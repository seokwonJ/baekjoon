using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            if (s1.Contains(s3) && s2.Contains(s3)) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}