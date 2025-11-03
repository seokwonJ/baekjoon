using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        for (int i=1;i < Math.Sqrt(n)+1;i++) {
            if (n % i == 0) {
                if (n / i == i) {
                    li.Add(i);
                }
                else {
                    li.Add(n/i);
                    li.Add(i);
                }
            } 
        }
        li.Sort();
        answer = li.ToArray();
        return answer;
    }
}