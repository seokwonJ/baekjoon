using System;

namespace hello {
    class h {
        static void Main (string[] args) {
            int num = 0;
            for (int i =0;i < 15;i++) {
                string s = Console.ReadLine();
                for (int j = 0; j < s.Length;j++) {
                    if (s[j] == 'w') num = 1;
                    else if (s[j] == 'b') num = 2;
                    else if (s[j] == 'g') num = 3;
                }
            }
            if (num == 1) Console.WriteLine("chunbae");
            else if (num == 2) Console.WriteLine("nabi");
            else if (num == 3) Console.WriteLine("yeongcheol");
        }
    }
}