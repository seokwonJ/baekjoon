using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int Enum = 0;
        int Onum = 0;
        for (int i = 0; i < num_list.Length;i++) {
            if (i % 2 == 0) {
                Enum += num_list[i];
            }
            else {
                Onum += num_list[i];
            }
        }
        if (Enum > Onum) {
            answer = Enum;
        }
        else {
            answer = Onum;
        }
        return answer;
    }
}