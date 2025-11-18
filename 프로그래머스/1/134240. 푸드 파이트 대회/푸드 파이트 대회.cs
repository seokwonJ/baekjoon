using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        string firstPlayer = "";
        string secondPlayer = "";
        
        for (int i=1; i < food.Length;i++) {
            for (int j = 0;j < food[i] / 2;j++) {
                firstPlayer = firstPlayer + i.ToString();
                secondPlayer = i.ToString() + secondPlayer; 
            }    
        }
        answer = firstPlayer + "0" + secondPlayer;
        
        return answer;
    }
}