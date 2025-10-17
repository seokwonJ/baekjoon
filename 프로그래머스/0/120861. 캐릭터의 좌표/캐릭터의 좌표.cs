using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
        int[] answer = new int[] {0, 0};
        
        for (int i=0;i < keyinput.Length;i++) {
            if (keyinput[i] == "left" && answer[0] > board[0] / 2 * -1) {
                 answer[0] -= 1;
            }
            else if (keyinput[i] == "right" && answer[0] < board[0] / 2) {
                answer[0] += 1;
            }
            else if (keyinput[i] == "up" && answer[1] < board[1] / 2) {
                 answer[1] += 1;
            }
            else if (keyinput[i] == "down" && answer[1] > board[1] / 2 * -1) {
                answer[1] -= 1;
            }
        }

        return answer;
    }
}