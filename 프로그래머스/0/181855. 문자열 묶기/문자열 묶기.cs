using System;

public class Solution {
    public int solution(string[] strArr) {
        int maxNum = 0;
        for (int i = 0; i <= 30;i++) {
            int num = 0;
            for (int j = 0; j < strArr.Length;j++) {
                if (i == strArr[j].Length) {
                    num += 1;
                }
            }
            if (num > maxNum) {
                maxNum = num;
            }
        }
        
        return maxNum;
    }
}