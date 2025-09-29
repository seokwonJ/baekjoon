using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        int num = order;
        while (num != 0) {
            if ((num % 10) != 0 && (num % 10) % 3 == 0) answer += 1;
            num /= 10;
        }
        return answer;
    }
}