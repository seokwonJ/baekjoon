using System;

public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        int answer = 0;
        int max = 1;
        int count = 0;
        
         while (true) {
             bool up = false;
             for (int j=0;j < rank.Length;j++) {
                 if (rank[j] == max && attendance[j]) {
                     if (count == 0) {
                         answer += j * 10000;
                     }
                     else if (count == 1) {
                         answer += j * 100;
                     }
                     else if (count == 2) {
                         answer += j;
                     }
                     count += 1;
                     max += 1;
                     up = true;
                     break;
                 }
             }  
             if (!up) {
                 max += 1;
             }
             if (count == 3) break;
         }
        
        
        return answer;
    }
}