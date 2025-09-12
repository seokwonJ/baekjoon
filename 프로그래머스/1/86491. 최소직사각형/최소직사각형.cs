using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] sizes) {
        
        int answer = 0;
        int w=0, h=0;
        
        for (int i=0;i < sizes.GetLength(0);i++) {
            
            int temp = 0;
            
            if (sizes[i,0] < sizes[i,1] ) {
                temp = sizes[i,0];
                sizes[i,0] = sizes[i,1];
                sizes[i,1] = temp;
            }
            
            if (sizes[i,0] > w) {
                w = sizes[i,0];
            }
            if (sizes[i,1] > h) {
                h = sizes[i,1];
            }
        }
    
        answer = w * h;
        
        return answer;
    }
}