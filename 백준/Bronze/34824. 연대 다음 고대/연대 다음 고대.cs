using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int isYonsei = 0;
            for (int i=0;i < n;i++) {
                string s = Console.ReadLine();
                if (isYonsei == 0) {
                                    if (s == "yonsei") isYonsei = 1;
                else if (s == "korea") isYonsei = 2;
                }

            }
            if (isYonsei == 1) Console.WriteLine("Yonsei Won!");
            else Console.WriteLine("Yonsei Lost...");
        }
    }
}