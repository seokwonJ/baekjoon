using System;

public class Solution {
    public string solution(string my_string, int[] indices) {
        string answer = "";
        char[] chars = my_string.ToCharArray();

        
        for (int i =0;i < indices.Length;i++) {
            chars[indices[i]] = ' ';
        }
        for (int i =0;i <  my_string.Length;i++){
            if(chars[i] != ' ') answer += my_string[i];
        }
        return answer;
    }
}