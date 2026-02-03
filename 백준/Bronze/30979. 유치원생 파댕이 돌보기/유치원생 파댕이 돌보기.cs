using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            string s = Console.ReadLine();
            string ss = Console.ReadLine();
            string[] sss = Console.ReadLine().Split();
            int num = 0;
            for (int i=0; i < int.Parse(ss);i++) {
                num += int.Parse(sss[i]);
            }
            if (int.Parse(s) > num) Console.WriteLine("Padaeng_i Cry");
            else Console.WriteLine("Padaeng_i Happy");
        }
    }
}