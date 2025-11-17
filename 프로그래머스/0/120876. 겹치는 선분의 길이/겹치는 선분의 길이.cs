using System;

public class Solution {
    public int solution(int[,] lines) {
        int answer = 0;
        
        int[] b = new int[201];
        for (int i = 0; i < lines.GetLength(0);i++) {
            for (int j = lines[i,0] + 100;j < lines[i,1] + 100;j++) {
                b[j] += 1;
            }
        }
        
        for (int i=0; i < 201;i++) {
            if (b[i] > 1) answer += 1;
        }

        return answer;
    }
}