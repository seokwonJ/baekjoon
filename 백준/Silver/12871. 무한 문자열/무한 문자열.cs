using System;

namespace hello {
    class h {
        static void Main (string[] args) {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            
            string ss1 = "";
            string ss2 = "";
            
            for (int i=0;i < 300;i++) {
                ss1 += s1;
                ss2 += s2;
            }
            
            bool isRight = false;
            
            for (int i=0;i < 300;i++) {
                if(ss1[i] != ss2[i]) {
                    isRight = true;
                }
            }
            
            if (!isRight) Console.WriteLine(1);
            else Console.WriteLine(0);
            
            
        }
    }
}