using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] a= s.ToCharArray();
        Array.Sort(a);
        Array.Reverse(a);
        answer = new String(a);
        return answer;
    }
}