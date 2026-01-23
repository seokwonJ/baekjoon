using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i=1;i <= n;i++) {
                int jj = i;
                int maxNum = 1;
                while(true) {
                    bool isMultiple = false;
                    for (int m = 2;m < jj;m++) {
                        if (jj % m == 0) {
                            isMultiple = true;
                            jj /= m;
                            if (maxNum < m) maxNum = m;
                            break;
                        }
                    }
                    if (!isMultiple) {
                        if (maxNum < jj) maxNum = jj;
                        break;
                    }
                }
                if (maxNum <= s) count++;
            }
            Console.WriteLine(count);
        }
    }
}