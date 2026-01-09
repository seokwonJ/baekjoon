using System;

namespace hello {
    class h {
        static void Main() {
            string[] s1 = Console.ReadLine().Split();
            string[] s2 = Console.ReadLine().Split();
            int[] n1 = Array.ConvertAll(s1,int.Parse);
            int[] n2 = Array.ConvertAll(s2,int.Parse);
            int countGunnar = 0;
            int countEmma = 0;
            
            for (int i=n1[0];i <= n1[1];i++) {
                for (int j = n1[2]; j <= n1[3];j++) {
                    for (int k = n2[0]; k <= n2[1];k++) {
                        for (int l = n2[2]; l <= n2[3];l++) {
                            if (i + j > k + l) countGunnar++;
                            else if (i + j < k + l) countEmma++;
                        }
                    }
                }
            }
            if (countGunnar > countEmma) {
                Console.WriteLine("Gunnar");
            }
            else if(countGunnar < countEmma){
                Console.WriteLine("Emma");
            }
            else {
                Console.WriteLine("Tie");
            }
        }
    }
}