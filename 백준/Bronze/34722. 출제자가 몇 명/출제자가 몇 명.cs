using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i=0;i < n;i++) {
                string[] s = Console.ReadLine().Split();
                if (int.Parse(s[0]) >= 1000) count++;
                else if (int.Parse(s[1]) >= 1600) count++;
                else if (int.Parse(s[2]) >= 1500) count++;
                else if (int.Parse(s[3]) <= 30 && int.Parse(s[3]) != -1) count++;
            }
            Console.WriteLine(count);
        }
    }
}