using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        int[] answer = new int[] {};
        
        int[] student1 = new int[] {1,2,3,4,5};
        int[] student2 = new int[] {2,1,2,3,2,4,2,5};
        int[] student3 = new int[] {3,3,1,1,2,2,4,4,5,5};
        int[] score = new int[] {0,0,0};
        int max = 0;
        List<int> student = new List<int>();
        
        for (int i = 0; i < answers.Length;i++) {
            if (student1[i % student1.Length] == answers[i]) score[0]++;
            if (student2[i % student2.Length] == answers[i]) score[1]++;
            if (student3[i % student3.Length] == answers[i]) score[2]++;
        }
        
        for (int i = 0; i < 3; i++) {
            if (score [i] >= max) {
                max = score[i];        
            } 
        }
        
        for (int i = 0; i < 3; i++) {
            if (score [i] == max) {
                student.Add(i+1);
            } 
        }
        
        
        answer = student.ToArray();
        
        return answer;
    }
}