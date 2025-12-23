using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string s = "";
        int ss = 0;
        int num = n;
        while (true) {
            s += num % 3;
            num = num / 3;
            if (num == 0) break;
        }
        int list = s.Length;
        int count = 1;
        while (true) {
           
            int nums = 1;
            for (int i=1;i<count;i++) {
                nums *= 3;
            }
            
            ss += (s[s.Length - count]- '0') * nums;
            
            count++;
             if (list == count-1) break;
        }
        answer = ss;
        return answer;
    }
}