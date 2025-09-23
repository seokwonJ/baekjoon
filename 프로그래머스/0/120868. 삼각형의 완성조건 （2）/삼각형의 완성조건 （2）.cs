using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        int max = 0;
        int min =0;
        if (sides[0] > sides[1])  {
            max = sides[0];
            min = sides[1];
        }
        else {
            max = sides[1];
            min = sides[0];
        } 
        
        for (int i =1;i < max;i++) {
            if(min + i > max) answer++;
        }
        
        for (int i =max;i < int.MaxValue;i++) {
            if(min + max > i) answer++;
            else break;
        }
        return answer;
    }
}