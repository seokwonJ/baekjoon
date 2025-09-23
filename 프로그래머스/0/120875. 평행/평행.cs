using System;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
        bool isTrue = false;
        
        // a b c d
        if (Math.Abs((dots[1,1] - dots[0,1]) * (dots[3,0] - dots[2,0])) == Math.Abs((dots[3,1] - dots[2,1])  * (dots[1,0] - dots[0,0]))) isTrue = true;
        // a c b d
        if (Math.Abs((dots[2,1] - dots[0,1]) * (dots[3,0] - dots[1,0])) == Math.Abs((dots[3,1] - dots[1,1]) * (dots[2,0] - dots[0,0]))) isTrue = true;
        // a c d b
        if (Math.Abs((dots[3,1] - dots[0,1]) * (dots[2,0] - dots[1,0])) == Math.Abs((dots[2,1] - dots[1,1]) * (dots[3,0] - dots[0,0]))) isTrue = true;
        
        if (isTrue) answer = 1;
        return answer;
    }
}