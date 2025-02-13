using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        for (int i = 0;i < myString.Length - pat.Length + 1; i++) {
            
            bool allRight = false;
            
            for (int j = 0; j < pat.Length;j++) {
                if(myString[i+j] >= 'A' && myString[i+j] <= 'Z') {
                    if (pat[j] >= 'A' && pat[j] <= 'Z') {
                        if (myString[i+j] != pat[j]) {
                            allRight = true;
                            break;
                        }
                    }
                    else {
                       if (myString[i+j] != (char)(pat[j] - 'a' + 'A')) {
                            allRight = true;
                            break;
                        } 
                    }
                }
                           
                if(myString[i+j] >= 'a' && myString[i+j] <= 'z') {
                    if (pat[j] >= 'a' && pat[j] <= 'z') {
                        if (myString[i+j] != pat[j]) {
                            allRight = true;
                            break;
                        }
                    }
                    else {
                       if (myString[i+j] != (char)(pat[j] - 'A' + 'a')) {
                            allRight = true;
                            break;
                        } 
                    }
                }
            }
            if (!allRight) {
                answer = 1;
                break;
            }
        }
                           
        return answer;
    }
}