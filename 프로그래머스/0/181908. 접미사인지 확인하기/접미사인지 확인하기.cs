using System;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        int answer = 1;
        int k = 0;
        if (my_string.Length < is_suffix.Length) return 0;
        for (int i = my_string.Length-1;i>= my_string.Length - is_suffix.Length;i--) {
            
            if (my_string[i] != is_suffix[is_suffix.Length-1-k]) {
                answer = 0;
                break;
            }
            k++;
        }
        return answer;
    }
}