using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int totalArea = brown + yellow;
        
        for (int H = 3; H <= Math.Sqrt(totalArea); H++) {
            
            if (totalArea % H == 0) {
                
                int W = totalArea / H;
                
                if ((W - 2) * (H - 2) == yellow) {
                    
                    return new int[] { W, H };
                }
            }
        }
        
        return new int[] { 0, 0 };
    }
}