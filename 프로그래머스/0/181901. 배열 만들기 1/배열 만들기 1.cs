using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int k) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        for (int i = 1; i*k <= n;i++) {
            li.Add(i*k);
        }
        answer = li.ToArray();
        return answer;
    }
}