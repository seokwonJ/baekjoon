using System;

namespace hello{
    class h {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            
            int min = 1000000001;
            int max = -1000000001;
            
            for (int i=0;i < n;i++) {
                string[] num = Console.ReadLine().Split();
                int[] xy = Array.ConvertAll(num, int.Parse);
                if (xy[1] < min) min = xy[1];
                if (xy[1] > max) max = xy[1];
            }
            Console.WriteLine(max - min);
        }
    }
}