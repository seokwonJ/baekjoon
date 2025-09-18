using System;
using System.Collections.Generic;

class Solution {
    
    public int solution(int[,] maps) {
        int answer = 0;
    
        Queue<(int,int,int)> qu = new Queue<(int, int,int)>();
        
        qu.Enqueue((0,0,0));
        
        int n = maps.GetLength(0);
        int m = maps.GetLength(1);
        bool[,] visited = new bool[n, m];
        
        visited[0,0] = true;
        
        while (qu.Count > 0) {
            
            var (x, y, dist) = qu.Dequeue();
            if (x == n - 1 && y == m - 1) return dist+1;
            
            int[] row = {1,-1,0,0};
            int[] col = {0,0,1,-1};
            
            for (int i =0;i < 4;i++) {
                int rr = x+row[i];
                int cc = y+col[i];
                if ((rr >= 0 && rr <= n - 1 && cc >= 0 && cc <= m-1) && maps[rr,cc] == 1 && !visited[rr,cc]) {
                    qu.Enqueue((rr,cc,dist+1));
                    visited[rr,cc] = true;
                }
            }
        }
        
        return -1;
    }
}