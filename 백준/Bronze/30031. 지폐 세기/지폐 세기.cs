using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            int num = 0;
            int n = int.Parse(Console.ReadLine());
            
            for (int i =0;i < n;i++) {
                string[] s = Console.ReadLine().Split();
                if (s[0] == "136") num += 1000;
                if (s[0] == "142") num += 5000;
                if (s[0] == "148") num += 10000;
                if (s[0] == "154") num += 50000;
            }
            Console.WriteLine(num);
        }
    }
}