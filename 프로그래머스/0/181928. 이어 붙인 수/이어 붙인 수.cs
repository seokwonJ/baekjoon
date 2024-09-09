using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int oddNumCount = 1;
        int evenNumCount = 1;
        int oddNum =0;
        int evenNum=0;
        
        for (int i = 0; i < num_list.Length;i++) {
            if (num_list[i] % 2 == 1) {
                oddNum *= 10;
                oddNum += num_list[i];

            }
            else {
                evenNum *= 10;
                evenNum += num_list[i] ;
            }
            answer = oddNum + evenNum;
        }
        return answer;
    }
}