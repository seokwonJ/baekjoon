using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        int num = 0;
        for (int i =0;i < my_string.Length;i++) {
            if (!(my_string[i] >= 'A' && my_string[i] <= 'z')) {
                num *= 10;
                num += my_string[i] - '0';
            }
            else {
                answer += num;
                num = 0;
            }
        }
        
        answer += num;
        return answer;
    }
}