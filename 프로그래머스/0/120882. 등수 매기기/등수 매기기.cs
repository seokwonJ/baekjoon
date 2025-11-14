using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[,] score) {
        int[] answer = new int[] {};
        List<double> li = new List<double>();
        List<int> ranking = new List<int>();
        
        for (int i=0;i < score.GetLength(0);i++) {
            double scoreMiddle = (score[i,0] + score[i,1]) / 2.0;
            li.Add(scoreMiddle);
        }
        
        for (int i=0;i < li.Count;i++) {
            int rank = 1;
            for (int j = 0; j < li.Count;j++) {
                if (li[i] < li[j]) rank++;
            }
            ranking.Add(rank);
        }
        
        answer = ranking.ToArray();
        
        return answer;
    }
}