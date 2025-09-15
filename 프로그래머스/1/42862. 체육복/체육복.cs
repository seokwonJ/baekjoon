using System;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        int num = n;
        
        Array.Sort(lost);
        Array.Sort(reserve);
        
        for (int i = 0;i < lost.Length; i++) {
            for (int j = 0;j < reserve.Length;j++) {
                if (lost[i] == reserve[j]) {
                    lost[i] = -1;
                    reserve[j] = -10;
                    break;
                }
            }
        }
        
        for (int i=0;i < lost.Length;i++) {
            int index = lost[i];
            bool canBorrow = false;
            
            if (lost[i] == -1) continue;
            
            for (int j = 0;j < reserve.Length;j++) {
                if(lost[i] - 1 == reserve[j])  {
                    canBorrow = true;
                    reserve[j] = -10;
                    break;
                }
                else if (lost[i] + 1 == reserve[j]) {
                    canBorrow = true;
                    reserve[j] = -10;
                    break;
                }
            }
            if (!canBorrow) num -= 1;
        }
        
        answer = num;
        
        return answer;
    }
}