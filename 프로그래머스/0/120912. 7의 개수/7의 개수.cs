using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        
        foreach(int num in array) {
            int nnum = num;
            while(true) {
                if(nnum % 10 == 7) answer += 1;
                nnum /= 10;
                if (nnum == 0) break;
            }
        }
        
        return answer;
    }
}