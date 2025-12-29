using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        int[] dd = d;
        int budgetNum = 0;
        
        Array.Sort(dd);
        
        for (int i =0;i < dd.Length;i++) {
            if (budgetNum + dd[i] > budget) break;
            budgetNum += dd[i];
            answer++;
        }
        
        return answer;
    }
}