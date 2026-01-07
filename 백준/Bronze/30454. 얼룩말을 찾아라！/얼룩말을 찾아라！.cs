using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            string[] s = Console.ReadLine().Split();
            int[] n = Array.ConvertAll(s,int.Parse);
            
            int maxLineCount = 0;
            int answer = 0;
            
            for (int i=0;i < n[0];i++) {
                string horse = Console.ReadLine();
                int lineCount = 0;
                bool isBlack = false;
                for (int j=0;j < n[1];j++) {
                    if (horse[j] == '1') {
                        if(!isBlack) lineCount++;
                        isBlack = true;
                    }
                    else {
                        isBlack = false;
                    }
                }
                if (maxLineCount < lineCount) {
                    maxLineCount = lineCount;
                    answer = 1;
                }
                else if (maxLineCount == lineCount) answer++;
            }
            
            Console.WriteLine(maxLineCount + " " + answer);
        }
    }
}