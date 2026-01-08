using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            double num = 0;
            if (n <= 30) { num = (double)n / 2; }
            else { num = ((double)n * 3 - 90) / 2 + 15; }
            num = Math.Truncate(num*10) * 0.1f;
            Console.WriteLine("{0:F1}", num);
        }
    }
}