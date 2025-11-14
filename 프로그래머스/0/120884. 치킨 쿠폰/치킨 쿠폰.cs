using System;

public class Solution {
    public int solution(int chicken) {
        int answer = 0;
        
        while (true) {
            if (chicken >= 10) {
                chicken -= 10;
                chicken++;
                answer++;
            }
            else {
                break;
            }
        }
        return answer;
    }
}