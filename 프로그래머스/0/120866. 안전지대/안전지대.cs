using System;

public class Solution {
    public int solution(int[,] board) {
        int answer = 0;
        int nn = board.GetLength(0);
        int mm = board.GetLength(1);
        
        for (int i=0;i < nn;i++) {
            for (int j =0; j < mm;j++) {
                if (board[i,j] == 1) {
                    if (i > 0) {
                        if (j > 0 &&  board[i-1,j-1] != 1) board[i-1,j-1] = 2;
                        if (j < mm - 1 && board[i-1,j+1] != 1) board[i-1,j+1] = 2;
                        if (board[i-1,j] != 1) board[i-1,j] = 2;
                    }
                    if (i < nn - 1) {
                        if (j > 0 &&  board[i+1,j-1] != 1) board[i+1,j-1] = 2;
                        if (j < mm - 1 && board[i+1,j+1] != 1) board[i+1,j+1] = 2;
                        if (board[i+1,j] != 1) board[i+1,j] = 2;
                    }
                    
                    if (j > 0 && board[i,j-1] != 1) board[i,j-1] = 2;
                    if (j < mm - 1 && board[i,j+1] != 1) board[i,j+1] = 2;
                    
                }
            }
        }
        for (int i=0;i < nn;i++) {
            for (int j =0; j < mm;j++) {
               if (board[i,j] == 0) answer++;
            }
        }
        return answer;
    }
}