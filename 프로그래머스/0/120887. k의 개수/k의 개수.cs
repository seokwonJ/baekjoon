using System;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        for (int t = i; t <= j;t++) {
            int e = t;
            while (e != 0) {
                if (e % 10 == k) answer++;
                e /= 10;
            }
        }
        return answer;
    }
}