using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine());
            int[] aaa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] aa = new int[5] {0,0,0,0,0};
            
            for (int i=0;i < a;i++) {
                aa[i] = aaa[i];
            }
            long num = 0;
            if (aa[0] > aa[2]) num += (aa[0] - aa[2]) * 508;
            else num += (aa[2] - aa[0]) * 108;
            if (aa[1] > aa[3]) num += (aa[1] - aa[3]) * 212;
            else num += (aa[3] - aa[1]) * 305;
            if (a == 5) num += aa[4] * 707;
            num *= 4763;
            Console.WriteLine(num);
        }
    }
}