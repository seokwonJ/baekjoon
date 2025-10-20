using System;

public class Solution {
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands) {
        
        string answer = "";
        int video_lenN = StringToNum(video_len);
        int posN = StringToNum(pos);
        int op_startN = StringToNum(op_start);
        int op_endN = StringToNum(op_end);
        
        for (int i=0;i<commands.Length;i++) {
            if (commands[i] == "prev") {
                if(posN - 10 <= 0) {
                    posN = 0;
                }
                else if (posN - 10 <= op_startN) {
                    posN = op_startN;
                }
                else if (posN >= op_startN && posN <= op_endN) {
                    posN = op_endN;
                }

                else {
                    posN -= 10;
                }
            }
            else if (commands[i] == "next") {
                if (posN >= op_startN && posN <= op_endN) {
                    posN = op_endN + 10;
                }
                else if (posN + 10 >= op_startN && posN + 10 <= op_endN) {
                    posN = op_endN;
                }
                else {
                    posN += 10;
                }
                if (posN >= video_lenN) {
                    posN = video_lenN;
                }
            }
            
        }
        answer = SecondsToTime(posN);
        
        return answer;
    }
    
    public int StringToNum(string time) {
        int num = 0;
        num = (time[0]-'0') * 600 + (time[1] - '0') * 60 + (time[3] - '0') * 10 + (time[4] - '0');
        return num;
    }
    public string SecondsToTime(int time) {
        int num = time;
        string numToString = "";
        numToString += (num / 600).ToString();
        num -= (num / 600) * 600;
        
        numToString += (num / 60).ToString();
        num -= (num / 60) * 60;
        
        numToString += ":";
        
        numToString += (num / 10).ToString();
        num -= (num / 10) * 10;
        
        numToString += (num % 10).ToString();
        
        return numToString;
    }
}