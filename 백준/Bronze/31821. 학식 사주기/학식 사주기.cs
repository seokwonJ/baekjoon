using System;
using System.Collections.Generic;

namespace hello {
    class h {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            List<int> li = new List<int>();
            int totalPrice = 0;
            
            for (int i=0;i < n;i++) {
                int nn = int.Parse(Console.ReadLine());
                li.Add(nn);
            }
            int nnn = int.Parse(Console.ReadLine());
            for (int i=0;i <nnn;i++) {
                int col = int.Parse(Console.ReadLine());
                totalPrice += li[col - 1];
            }
            Console.WriteLine(totalPrice);
        }
    }
}