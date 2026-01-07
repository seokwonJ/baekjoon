using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            for (int i =0;i < n;i++) {
                string[] s = Console.ReadLine().Split();
                int[] lines = Array.ConvertAll(s,int.Parse);
                int answer = 0;
                if (lines[0] < 12 || lines[1] < 4) answer = -1;
                else answer = 12 * lines[1] - (lines[1] - 4);
                Console.WriteLine(answer);
            }
        }
    }
}