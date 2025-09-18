using System;

public class Solution {    
    
    public int sol(int index, int[,] computers,int n,bool[] visit) {
        visit[index] = true;
        for (int i = 0; i < n;i++) {
            if (computers[index, i] == 1 && !visit[i]) {
                sol(i,computers,n,visit);
            }
        }
        return 0;
    }
    
    
    public int solution(int n, int[,] computers) {
        int answer = 0;
        bool[] visit = new bool[n];
        
        for (int i=0;i < n;i++) {
            if (!visit[i]) {
                sol(i,computers,n,visit);
                answer++;
            }
        }
        
        return answer;
    }
}