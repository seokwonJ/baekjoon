using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            string[] s = Console.ReadLine().Split('-');
            int[] days = Array.ConvertAll(s,int.Parse);
            int cycle = int.Parse(Console.ReadLine());
            
            for (int i=0;i < cycle;i++) {
                days[2]++;
                if (days[2] > 30) {
                    days[1] += 1;
                    days[2] = 1;
                }
                if (days[1] > 12) {
                    days[0] += 1;
                    days[1] = 1;
                }   
            }
            Console.Write("{0:D4}-{1:D2}-{2:D2}",days[0],days[1],days[2]);
        }
    }
}