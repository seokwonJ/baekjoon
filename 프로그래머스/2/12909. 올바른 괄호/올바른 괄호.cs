using System;
using System.Collections;

public class Solution {
    public bool solution(string s) {
        bool answer = true;
        
        Stack stack = new Stack();
        
        for (int i = 0; i < s.Length;i++) {
            if (s[i] == '(') stack.Push('(');
            else {
                if (stack.Count == 0) {
                    answer = false;
                    break;
                }
                else if ((char)stack.Peek() != '(') {
                    answer = false;
                    break;
                }
                else{
                    stack.Pop();
                }
            }
        }
        if (stack.Count != 0) answer = false;
        return answer;
    }
}