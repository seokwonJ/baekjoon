using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine((2024 + ((8 + 7 * (n-1)) - 1)  / 12) + " " + (((8 + 7 * (n-1)) - 1) % 12 + 1));
        }
    }
}