using System;
using System.Text;

public class Solution {
    public string solution(string rsp) {
        string answer = "";
        StringBuilder str = new StringBuilder("");
        foreach (char c in rsp) {
            switch(c) {
                case '2':
                    str.Append('0');
                    break;
                case '0':
                    str.Append('5');
                    break;
                case '5':
                    str.Append('2');
                    break;
            }
        }
        answer = str.ToString();
        return answer;
    }
}