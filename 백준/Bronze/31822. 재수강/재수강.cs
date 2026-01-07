using System;

namespace hello{
    class h {
        static void Main(string[] args) {
            string s = Console.ReadLine();
            int result = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i=0;i < n;i++) {
                string input = Console.ReadLine();
                bool isSame = true;
                for (int j = 0;j < 5;j++) {
                    if(s[j] != input[j]) {
                        isSame = false;
                        break;
                    }
                }
                if (isSame) result++;
            }
            Console.WriteLine(result);
        }
    }
}