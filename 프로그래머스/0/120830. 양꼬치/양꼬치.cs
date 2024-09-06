using System;

public class Solution {
    public int solution(int n, int k) {
        int answer = 0;
        if (k - n/10 < 0) {
            k=0;
        }
        else {
           k = k - n/10;
        }
        answer = n * 12000 + k* 2000;
        return answer;
    }
}