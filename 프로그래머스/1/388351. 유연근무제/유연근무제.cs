using System;

public class Solution {
    public int solution(int[] schedules, int[,] timelogs, int startday) {
        int answer = 0;
        
        for (int i=0;i<schedules.Length;i++) {
            bool isGetEvent = true;
            int dayCount= startday;
            for (int j = 0;j < 7;j++) {
                if (ReturnClockNum(schedules[i]) < timelogs[i,j] && dayCount < 6) {
                    isGetEvent = false;
                    break;
                }
                dayCount++;
                if (dayCount == 8) {
                    dayCount = 1;
                }
            }
            if (isGetEvent) answer++;
        }
        
        return answer;
    }
    
    public int ReturnClockNum(int num) {
        int numm = num+10;
        int realNum = numm;
        if (numm % 100 > 59) {
            realNum = (numm / 100) * 100 + 100 + numm % 10;
        }
        
        if (realNum /100 == 24) {
            realNum = realNum % 100;
        }
    
        
        return realNum;
    }
}