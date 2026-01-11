using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            int n;
            int q;
            int count = 0;
            
            string[] s = Console.ReadLine().Split();
            n = int.Parse(s[0]);
            q = int.Parse(s[1]);
            bool[] nn = new bool[10000];
            
            for (int i =0;i < q;i++) {
                int k,w;
                string[] ss = Console.ReadLine().Split();
                k = int.Parse(ss[0]);
                w = int.Parse(ss[1]);
                for (int j = k -1;j < n;j+=w) {
                    nn[j] = true;
                }
            }
            
            for (int i=0;i < n;i++) {
                if (nn[i]) count++;
            }
            Console.WriteLine(n - count);
        }
    }
}