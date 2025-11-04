using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        int num1 = 0;
        int num2 = 0;
        char ch = ',';
        
        for (int i= 0;i < my_string.Length;i++) {
            if (my_string[i] >= '0' && my_string[i] <= '9') {
                if (ch == ',') {
                    num1 *= 10;
                    num1 += my_string[i] - '0';
                }
                else {
                    num2 *= 10;
                    num2 += my_string[i] - '0';
                }
            }
            else if (my_string[i] == '+' || my_string[i] == '-') {
                if (num2 != 0) {
                    if (ch == '+') num1 += num2;
                    else num1 -= num2;
                    num2 = 0;
                }
                ch = my_string[i];
            }
        }
        
         if (ch == '+') answer = num1 + num2;
        else answer= num1 - num2;
        
        return answer;
    }
}