using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            
            if (num1 > num2) num1 = num2;
            Console.WriteLine(num1 * 50);
        }
    }
}