using System;

public class Solution {
    
    private int _counts=0;
    private bool _find=false;
    
    public void DFS(bool[] visited, string target, string nowString,string word) {
        if (word == nowString) _find = true;
        if (_find) return;
        _counts++;
        if (nowString.Length == 5) return;
        
        for (int i=0;i < target.Length;i++) {
            visited[i] = true;
            DFS(visited,target,nowString+target[i],word);
            visited[i] = false;
        }
    }
    
    
    public int solution(string word) {
        int answer = 0;
        bool[] visited = new bool[5];
        string target = "AEIOU";
        
        DFS(visited, target,"", word);
        
        answer = _counts;
        return answer;
    }
}