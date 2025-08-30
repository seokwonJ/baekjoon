using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        for(int i = 0; i < myString.Length;i++) {
            bool okay = false;
            if (myString[i] == pat[0] && pat.Length <= myString.Length - i) {
                okay = true;
                for(int j = 0; j < pat.Length;j++) {
                    if (myString[i+j] != pat[j]) {
                        okay = false;
                        break;
                    }
                }
            }
            if (okay) answer += 1;
        }
        return answer;
    }
}