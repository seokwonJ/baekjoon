using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = 0;
        int index = num.ToString().IndexOf(k.ToString()) + 1;
        answer = index == 0 ? -1 : index;
        
        return answer;
    }
}