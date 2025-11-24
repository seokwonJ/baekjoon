using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "";
        
        int indexCards1 = 0;
        int indexCards2 = 0;
        int nowIndex = 0;
        int totalIndex = goal.Length;
        while (true) {
            if (nowIndex == totalIndex) break;
            
            if (cards1.Length > indexCards1 && goal[nowIndex]==cards1[indexCards1]) {
                indexCards1++;
                nowIndex++;
            }
            else if (cards2.Length > indexCards2 && goal[nowIndex]== cards2[indexCards2]) {
                indexCards2++;
                nowIndex++;
            }
            else {
                return "No";
            }            
        }
        
        return "Yes";
    }
}