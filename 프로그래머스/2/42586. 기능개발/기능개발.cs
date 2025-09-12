using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
            
        int count = 0;
        
        while(count < progresses.Length) {
             for (int i=0;i < progresses.Length;i++) {
                if (progresses[i] != -1)
                {
                    progresses[i] += speeds[i];
                }
             }
            for (int i=progresses.Length - 1;i >= 0;i--) {
                if (progresses[i] != -1)
                {
                    if (progresses[i] >= 100) {
                        bool pre = false;
                        for (int j = 0; j < i;j++) {
                            if (!(progresses[j] == -1 || progresses[j] >= 100)) {
                                pre = true;
                            }
                        }
                        if (!pre) {
                            int totalCount = 0;
                            for (int j = 0; j <= i;j++) {
                                if (progresses[j] >= 100) {
                                    progresses[j] = -1;
                                    totalCount += 1;
                                }
                            }
                            li.Add(totalCount);
                            count += totalCount;
                        }
                    }
                }
            }
        }
        
        answer = li.ToArray();
        
        return answer;
    }
}