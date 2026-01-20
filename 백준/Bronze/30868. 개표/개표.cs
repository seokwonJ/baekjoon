using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            
            for (int i=0;i < n;i++) {
                int nn = int.Parse(Console.ReadLine());
                
                for (int j=0;j < nn / 5;j++) {
                    Console.Write("++++ ");
                }
                for (int j=0;j < nn % 5;j++) {
                    Console.Write("|");
                }
                Console.WriteLine("");
            }
        }
    }
}