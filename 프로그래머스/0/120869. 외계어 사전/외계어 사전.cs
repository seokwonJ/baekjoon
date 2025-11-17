using System;

public class Solution {
    public int solution(string[] spell, string[] dic) {
        int answer = 0;
        int count = 0;
        
        for (int i =0;i < dic.Length;i++) {
            bool allFind = true;
            if (dic[i].Length != spell.Length) continue;
            for (int j = 0;j < spell.Length;j++) {
                if(!(dic[i].IndexOf(spell[j]) >= 0)) {
                    allFind = false;
                    continue;
                }
            }
            if (allFind) return 1;
        }
        answer = 2;
        return answer;
    }
}