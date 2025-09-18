using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        for (int i=0;i < n;i++) {
            answer++;
            while (true) {
                
            
            if (answer % 3 == 0) {
                answer++;
                continue;
            }
             
            int nn = answer;
            bool three = false;
            while(nn != 0) {
               if(nn % 10 == 3)  {
                   three = true;
                    break;
                }
                    nn /= 10;    
            }
            if (three)  {
                answer++;
                continue;
            }
                break;
            }
        }
        return answer;
    }
}