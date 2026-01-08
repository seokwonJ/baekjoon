using System;
using System.Text;

namespace hello {
    class h {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i =0;i < n;i++) {
                long num = long.Parse(Console.ReadLine());
                long max = 0;
                while (true) {
                    if (num > max) max = num;
                    if (num == 1) break;
                    else if (num % 2 == 0) num /= 2;
                    else if (num % 2 == 1) num = num * 3 + 1;
                }
                sb.AppendLine(max.ToString());
            }
                            Console.WriteLine(sb.ToString());
        }
    }
}