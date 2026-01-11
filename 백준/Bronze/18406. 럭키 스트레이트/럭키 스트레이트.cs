using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            string s = Console.ReadLine();
            int num1 = 0;
            int num2 = 0;
            for (int i =0;i < s.Length/2;i++) {
                num1 += s[i] - '0';
            }
            for (int i = s.Length/2;i < s.Length;i++) {
                num2 += s[i] - '0';
            }
            if (num1 == num2) Console.WriteLine("LUCKY");
            else Console.WriteLine("READY");
        }
    }
}