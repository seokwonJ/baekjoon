using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        for (int i=0; i <= n;i++) {
            if (i%2 == 1) {
                li.Add(i);
            }
        }
        answer = li.ToArray();
        return answer;
    }
}