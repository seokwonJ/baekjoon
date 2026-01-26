using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            string s = Console.ReadLine();
            string ss = Console.ReadLine();
            int oddNum = 0;
            int evenNum = 0;
            
            for (int i=0;i < ss.Length;i++) {
                if ((ss[i] -'0') % 2 == 0) evenNum++;
                else oddNum++;
            }
            if (oddNum > evenNum) Console.WriteLine(1);
            else if (oddNum < evenNum) Console.WriteLine(0);
            else Console.WriteLine(-1);
        }
    }
}