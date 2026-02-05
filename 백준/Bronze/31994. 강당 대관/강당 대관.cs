using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            int maxNum = 0;
            string name = "";
            for (int i =0;i < 7;i++){
                string[] aa = Console.ReadLine().Split();
                if (int.Parse(aa[1]) >maxNum) {
                    maxNum = int.Parse(aa[1]);
                    name = aa[0];
                }
            }
            Console.WriteLine(name);
        }
    }
}