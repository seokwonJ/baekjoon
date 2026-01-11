using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            int count = 1;
            while(true) {
                string s = Console.ReadLine();
                count++;
                string answer = "";
                if (s == "Was it a cat I saw?") break;
                for (int i = 0;i < s.Length;i+=count) {
                    answer += s[i];
                }
                Console.WriteLine(answer);
            }
        }
    }
}