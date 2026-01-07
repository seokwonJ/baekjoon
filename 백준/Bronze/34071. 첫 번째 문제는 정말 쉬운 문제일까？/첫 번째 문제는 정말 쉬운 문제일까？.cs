using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int firstNum = int.Parse(Console.ReadLine());
            int minNum = firstNum;
            int maxNum = firstNum;
            string answer;
            for (int i =0;i < n-1;i++) {
                int score = int.Parse(Console.ReadLine());
                if (score < minNum) minNum = score;
                if (score > maxNum) maxNum = score;
            }
            if (firstNum == minNum) answer = "ez";
            else if (firstNum == maxNum) answer = "hard";
            else answer = "?";
            
            Console.WriteLine(answer);
        }
    }
}