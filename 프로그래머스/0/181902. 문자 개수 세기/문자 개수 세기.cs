using System;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[] {};
        int[] alphabetCount = new int[52];
        for (int i = 0;i < my_string.Length; i++) {
            if(my_string[i] >= 'A' && my_string[i] <= 'Z'){
                alphabetCount[my_string[i] - 'A'] += 1;
            }
            else {
                alphabetCount[26 + my_string[i] - 'a'] += 1;
            }
        }
        answer = alphabetCount;
        return answer;
    }
}