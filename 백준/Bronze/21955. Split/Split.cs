using System;

namespace hello {
    class h {
        static void Main(string[] args){
            string s = Console.ReadLine();
            string s1 = "";

            for (int i=0;i < s.Length;i++) {
                if (i == s.Length /2) s1 += " ";
                s1+=s[i];
            }
            Console.WriteLine(s1);
        }
    }
}