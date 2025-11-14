using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] ss = new string[4] {"aya", "ye", "woo", "ma"};
        
        for (int i=0;i < babbling.Length;i++) {
            int count = babbling[i].Length;
            for (int j =0; j < 4;j++) {
                if (babbling[i].IndexOf(ss[j]) != -1) count -= ss[j].Length;
            }
            if (count == 0) answer += 1;
        }
        return answer;
    }
}