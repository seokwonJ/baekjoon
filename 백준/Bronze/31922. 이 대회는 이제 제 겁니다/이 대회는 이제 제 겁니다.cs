using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            string[] s = Console.ReadLine().Split();
            int num1 = int.Parse(s[0]) + int.Parse(s[2]);
            int num2 = int.Parse(s[1]);
            
            if (num1 > num2) Console.WriteLine(num1);
            else Console.WriteLine(num2);
        }
    }
}