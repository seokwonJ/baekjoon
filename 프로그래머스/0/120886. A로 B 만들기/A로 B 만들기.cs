using System;

public class Solution {
    public int solution(string before, string after) {
        int answer = 1;
        for (int i =0;i < before.Length;i++) {
            int find = 0;
            int find2 = 0;
            for (int j = 0;j < after.Length;j++) {
                if (before[i] == after[j]) {
                    find += 1;
                } 
            }
            if (find >= 1) {
                for (int j = 0;j < before.Length;j++) {
                    if (before[j] == before[i]) {
                        find2 += 1;
                    } 
                }
            }
            else{
                answer = 0;
            }
            if (find != find2) {
                answer = 0;
                break;
            }
        }
        return answer;
    }
}