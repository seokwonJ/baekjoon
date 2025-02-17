using System;

public class Solution {
    public int solution(string binomial) {
        int answer = 0;
        int order = 0;
        int num1=0,num2=0;
        char cal = ' ';
        for (int i=0; i < binomial.Length;i++){
            if (binomial[i] == ' ') {
                order += 1;
            }
            else if (order == 0) {
                num1 *= 10;
                num1 += binomial[i] - '0';
            }
            else if (order == 1) {
                cal = binomial[i];
            }
            else if (order == 2) {
                num2 *= 10;
                num2 += binomial[i] - '0';
            }
        }
        if (cal == '+') {
            answer = num1 + num2;
        }
        else if (cal == '-') {
            answer = num1 - num2;
        }
        else if (cal == '*') {
            answer = num1 * num2;
        }
        return answer;
    }
}