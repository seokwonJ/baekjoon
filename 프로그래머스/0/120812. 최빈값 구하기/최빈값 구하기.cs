using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        int smallnum=array[0];
        int sam = 0;
        int small = 0;
        for (int i=0;i < array.Length;i++) {
            int count = 0;
            for (int j =i+1;j < array.Length;j++) {
                if (array[i] == array[j]) {
                    count += 1;
                }
            }
            if (count > small) {
                smallnum = array[i];
                sam = 1;
                small = count;
            }
            else if (count == small) {
                sam += 1;
            }
        }
        
        if (sam <= 1) {
            answer = smallnum;
        }
        else {
            answer = -1;
        }
        return answer;
    }
}