using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            bool isTrue = false;
            bool isTrue2 = false;
            if (s1.Contains(s3)) isTrue = true;
            if (s2.Contains(s3)) isTrue2 = true;
            if (isTrue && isTrue2) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}