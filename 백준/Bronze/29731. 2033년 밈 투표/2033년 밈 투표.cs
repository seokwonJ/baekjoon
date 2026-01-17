using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            string[] ss = new string[7];
            ss[0] = "Never gonna give you up";
            ss[1] = "Never gonna let you down";
            ss[2] = "Never gonna run around and desert you";
            ss[3] = "Never gonna make you cry";
            ss[4] = "Never gonna say goodbye";
            ss[5] = "Never gonna tell a lie and hurt you";
            ss[6] = "Never gonna stop";
            bool isRights = true;
            int n = int.Parse(Console.ReadLine());
            for (int i=0;i < n;i++) {
                string s = Console.ReadLine();
                bool isRight = false;
                for (int j=0;j < 7;j++) {
                    if (ss[j] == s) {
                        isRight = true;
                        break;
                    }
                }
                if (!isRight) isRights = false;
            }
            if (isRights) Console.WriteLine("No");
            else Console.WriteLine("Yes");
        }
    }
}