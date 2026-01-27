using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int num = 0;
            if (s[1] == "miss") num = 0;
            else if (s[1] == "bad") num = 200 * n;
            else if (s[1] == "cool") num = 400 * n;
            else if (s[1] == "great") num = 600 * n;
            else if (s[1] == "perfect") num = 1000 * n;
            
            Console.WriteLine(num);
        }
    }
}