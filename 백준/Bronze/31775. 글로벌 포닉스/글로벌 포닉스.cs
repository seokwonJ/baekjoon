using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            bool[] ii = new bool[3];
            for (int i=0;i < 3;i++) {
                 string s1 = Console.ReadLine();
                if (s1[0] == 'k') ii[0] = true;
                if (s1[0] == 'p') ii[1] = true;
                if (s1[0] == 'l') ii[2] = true;
            }
            if (ii[0] == true && ii[1] == true && ii[2] == true) Console.WriteLine("GLOBAL");
            else Console.WriteLine("PONIX");
        }
    }
}
