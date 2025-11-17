using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] quiz) {
        string[] answer = new string[] {};
        List<string> li = new List<string>();
        for (int i =0;i < quiz.GetLength(0);i++) {
            int num = 0;
            int num1 = 0;
            int num2 = 0;
            bool minus = false;

            int totalNum1;
            int totalNum2;

            int index = 0;
            while(true) {
                if (quiz[i][index] == ' ') {
                    if (minus) num *= -1;
                    minus = false;
                    index++;
                    num1 = num;
                    num = 0;
                    break;
                }
                if (quiz[i][index] == '-') {
                    minus = true;
                    index++;
                    continue;
                }
                num *= 10;
                num += (quiz[i][index] - '0');
                index++;
            }
            while(true) {
                if (quiz[i][index] == ' ') {
                    index++;
                    break;
                }
                if (quiz[i][index] == '-') minus = true;
                index++;
            }
            while(true) {
                if (quiz[i][index] == ' ') {
                    if (minus) num *= -1;
                    minus = false;
                    index+=3;
                    num2 = num;
                    totalNum1 = num1 + num2;
                    num = 0;
                    break;
                }
                if (quiz[i][index] == '-') {
                    if (minus) minus = false;
                    else minus = true;         
                    index++;
                }
                num *= 10;
                num += (quiz[i][index] - '0');
                index++;
            }
            while(true) {
                if (quiz[i].Length == index) {
                    if (minus) num *= -1;
                    minus = false;
                    index++;
                    totalNum2 = num;
                    num = 0;
                    break;
                }
                if (quiz[i][index] == '-') {
                    minus = true;
                    index++;
                    continue;
                }
                num *= 10;
                num += (quiz[i][index] - '0');
                index++;
            }
            if (totalNum1 == totalNum2) li.Add("O");
            else li.Add("X");
        }
        
        
        answer = li.ToArray();
        return answer;
    }
}