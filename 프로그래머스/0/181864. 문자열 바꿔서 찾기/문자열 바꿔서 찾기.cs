using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        for (int i=0;i < myString.Length - pat.Length+1;i++) {
            if (myString[i] != pat[0]) {
                int k = 0;
                for (int j =0; j<pat.Length;j++) {
                    if(myString[i + j] == pat[j]) {
                        k = 1;
                        break;
                    }
                }
                if (k==0) {
                    answer = 1;
                    break;
                }
            }  
        }
        return answer;
    }
}