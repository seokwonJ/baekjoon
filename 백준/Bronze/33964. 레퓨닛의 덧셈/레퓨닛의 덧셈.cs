using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            string[] s = Console.ReadLine().Split();
            int[] num = Array.ConvertAll(s,int.Parse);
            int num1 = 0;
            int num2 = 0;
            for (int i=0;i < num[0];i++) {
                num1 *= 10;
                num1 += 1;
            }
            for (int i=0;i < num[1];i++) {
                num2 *= 10;
                num2 += 1;
            }
            Console.WriteLine(num1 + num2);
        }
    }
}