using System;
using System.Collections.Generic;

public class Solution {
    public int returnIndex(string[] players,string s) {
        for (int i =0; i < players.Length;i++) {
            if (players[i] == s) return i;
        }
        return 0;
    }
    
    public string[] solution(string[] players, string[] callings) {
        string[] answer = new string[] {};
        Dictionary<string,int> playerDic = new Dictionary<string,int>();
        
        for (int i=0;i < players.Length;i++) {
            playerDic.Add(players[i],i);
        }
        
        for(int i = 0; i < callings.Length;i++) {
            int index = playerDic[callings[i]];
            playerDic[callings[i]] -= 1;
            playerDic[players[index-1]] +=1;
            string tmp = players[index-1];
            players[index-1] = players[index];
            players[index] = tmp;
        }
        
        
        answer = players;
        return answer;
    }
}