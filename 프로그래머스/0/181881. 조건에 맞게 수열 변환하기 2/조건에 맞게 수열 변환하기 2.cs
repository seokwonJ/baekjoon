using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr) {
        int answer = 0;
        int[] prevArr = new int[arr.Length];
        int[] nowArr = arr.ToArray();
        while(true) {
            bool isSame = true;
            for (int i=0;i < arr.Length;i++) {
                if (nowArr[i] != prevArr[i]) {
                    isSame = false;
                    break;
                }
            }
            prevArr = nowArr.ToArray();
            
            if(!isSame) {
                answer +=1;
                for (int i=0;i < nowArr.Length;i++) {
                    if(nowArr[i] >= 50 && nowArr[i] % 2 == 0) {
                        nowArr[i] = nowArr[i] / 2; 
                    } 
                    else if(nowArr[i] < 50 && nowArr[i] % 2 == 1) {
                        nowArr[i] = nowArr[i] * 2 + 1;
                    }
                }    
            }
            else {
                break;
            }
        }
        return answer-1;
    }
}