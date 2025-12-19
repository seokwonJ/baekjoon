using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2] {0,0};
        int count_winNums = 0;
        int zero_Nums = 0;
        for (int i=0;i < lottos.Length;i++) {
            if (lottos[i] == 0) zero_Nums++;
            for (int j = 0; j < win_nums.Length;j++) {
                if (lottos[i] == win_nums[j]) count_winNums++;
            }
        }
        
        
        
        answer[0] = 7 - (count_winNums + zero_Nums);
        answer[1] = 7 - count_winNums;
        
        if (answer[0] >= 6) answer[0] = 6;
        if (answer[1] >= 6) answer[1] = 6;
        
        return answer;
    }
}