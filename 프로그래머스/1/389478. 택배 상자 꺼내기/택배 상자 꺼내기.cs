using System;

public class Solution {
    public int solution(int n, int w, int num) {
        int answer = 0;
        int start = 0;
        int up = 0;
        int count = 0;
        int ww = w;
        int nowCount = 0;
        int numm = num;
        bool find = false;
        
        while (true) {
            start +=1;
            count += 1;
            if (start == numm) {
                answer += 1;
                
                if (!find) {
                    nowCount = count;
                    find = true;
                }
                
                numm += 2 * (w-count) + 1;
            }
            if (count == w) {
                up+=1;
                count = 0;
            }
            if (start == n) break;
        }
        
        
        return answer;
    }
}