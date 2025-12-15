public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        int count = 0;
        int m = a;
        int d = b;
        int nowM = 1;
        int nowD = 1;
        
        
        while (true) {
            if (nowM == m && nowD == d) break;
            if (nowM == 1 || nowM == 3 || nowM == 5 || nowM == 7 || nowM == 8 || nowM == 10 || nowM == 12) {
                if (nowD==31) {
                    nowM += 1;
                    nowD = 1;
                }
                else {
                    nowD += 1;
                }
            }
            else if (nowM == 4 || nowM == 6 || nowM == 9 || nowM == 11) {
                if (nowD==30) {
                    nowM += 1;
                    nowD = 1;
                }
                else {
                    nowD += 1;
                }
            }
            else if (nowM == 2) {
                if (nowD==29) {
                    nowM += 1;
                    nowD = 1;
                }
                else {
                    nowD += 1;
                }
            }
            else {
                nowD+=1;
            }
            count += 1;
            
        }
        int num = count % 7;
        if (num == 0) answer = "FRI";
        else if (num == 1) answer = "SAT";
        else if (num == 2) answer = "SUN";
        else if (num == 3) answer = "MON";
        else if (num == 4) answer = "TUE";
        else if (num == 5) answer = "WED";
        else if (num == 6) answer = "THU";
        
        return answer;
    }
}