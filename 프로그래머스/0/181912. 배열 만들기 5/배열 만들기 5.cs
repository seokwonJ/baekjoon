using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        
        for (int i=0; i < intStrs.Length;i++) {
            int num = 0;
            for (int j=s; j < s+l ;j++) {
                num *= 10;
                num += intStrs[i][j] - '0';
            }
            if (num > k){
                li.Add(num);
            }
        }
        
        answer = li.ToArray();
        return answer;
    }
}