using System;

public class Solution {
    public int[,] solution(int n) {
        int[,] answer = new int[,] {{}};
        answer = new int[n,n];
        
        int count = 1;
        int row = 1;
        int col = 0;
        int nowRow=0;
        int nowCol=0;
        
        while (true) {
            if (row == 1 && col == 0) {
                if (nowRow < n && answer[nowCol,nowRow] == 0) {
                    answer[nowCol,nowRow] = count;
                    nowRow += 1;
                    count += 1;
                }
                else {
                    nowRow -=1;
                    row = 0;
                    col = 1;
                    nowCol += 1;
                }
            }
            else if (row == 0 && col == 1) {
                if (nowCol < n && answer[nowCol,nowRow] == 0) {
                    answer[nowCol,nowRow] = count;
                    nowCol += 1;
                    count += 1;
                }
                else {
                    nowCol -=1;
                    row = -1;
                    col = 0;
                    nowRow -= 1;
                }
            }
            else if (row == -1 && col == 0) {
                if (nowRow >= 0 && answer[nowCol,nowRow] == 0) {
                    answer[nowCol,nowRow] = count;
                    nowRow -= 1;
                    count += 1;
                }
                else {
                    nowRow +=1;
                    row = 0;
                    col = -1;
                    nowCol += -1;
                }
            }
            else if(row == 0 && col == -1) {
                if (nowCol >= 0 && answer[nowCol,nowRow] == 0) {
                    answer[nowCol,nowRow] = count;
                    nowCol += -1;
                    count += 1;
                }
                else {
                    nowCol +=1;
                    row = 1;
                    col = 0;
                    nowRow += 1;
                }
            }
            if(count > n*n) break;
            
        }
        
        
        return answer;
    }
}