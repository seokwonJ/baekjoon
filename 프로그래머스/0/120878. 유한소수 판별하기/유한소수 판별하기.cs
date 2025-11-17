using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 1;
        int aa = a;
        int bb = b;
        
        while (true) {
            bool noMoreDivid = false;
            for (int i=2;i <= a;i++) {
                if (aa % i == 0 && bb % i == 0) {
                    aa /= i;
                    bb /= i;
                    noMoreDivid = true;
                    break;
                }
            }
            if (!noMoreDivid) break;
        }
        
        
        while (true) {
            if (bb == 1) break;
            if (bb % 2 == 0) bb /= 2;
            else if (bb % 5 == 0) bb /= 5;
            else {
                answer = 2;
                break;
            }
        }
        return answer;
    }
}