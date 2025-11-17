using System;

public class Solution {
    public string solution(string[] id_pw, string[,] db) {
        string answer = "";
        bool[] isLogin = new bool[3];

        for (int i=0;i < db.GetLength(0);i++) {
            if (db[i,0] == id_pw[0] && db[i,1] == id_pw[1]) isLogin[2] = true;
            else if (db[i,0] == id_pw[0] && db[i,1] != id_pw[1]) isLogin[1] = true;
            else isLogin[0] = true;
        }
        
        if (isLogin[2]) answer = "login";
        else if (isLogin[1]) answer = "wrong pw";
        else answer = "fail";
        
        return answer;
    }
}