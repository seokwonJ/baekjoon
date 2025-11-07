using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        
        for (int i = -1000;i <= total;i++) {
            int sum = 0;
            for (int j = i;j < i+num;j++) {
                sum += j;
            }
            if (sum == total) {
                for (int k = i;k < i+num;k++) {
                    li.Add(k);
                }
            }
        }
        answer = li.ToArray();
        return answer;
        }
    }
