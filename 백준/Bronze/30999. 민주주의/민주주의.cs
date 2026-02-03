using System;

namespace hello {
    class h {
        static void Main (string[] args) {
            string[] s = Console.ReadLine().Split();
            int count = 0;
            for (int i =0;i < int.Parse(s[0]);i++) {
                string ss = Console.ReadLine();
                int countt = 0;
                for (int j=0;j < ss.Length;j++) {
                    if (ss[j] == 'O') countt++;
                    else countt--;
                }
                if (countt >= 0) count++;
            }
            Console.WriteLine(count);
        }
    }
}