using System;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
        int x = dots[0,0];
        int y = dots[0,1];
        int xx = 0;
        int yy = 0;
        for (int i=0;i < 4;i++) {
            if (x != dots[i,0] && xx == 0) {
                xx = Math.Abs(x - dots[i,0]);
            }
            if (y != dots[i,1] && yy == 0) {
                yy = Math.Abs(y - dots[i,1]);
            }
        }
        answer = xx * yy;
        return answer;
    }
}