using System;

public class Solution {
    public int solution(string[] order) {
        int answer = 0;
        for (int i = 0; i < order.Length;i++) {
            if (order[i] == "iceamericano" || order[i] == "americanoice" || order[i] == "hotamericano"|| order[i] == "americanohot" || order[i] == "americano"|| order[i] == "anything") {
                answer += 4500;
            }
                        if (order[i] == "icecafelatte" || order[i] == "cafelatteice" || order[i] == "hotcafelatte"|| order[i] == "cafelattehot" || order[i] == "cafelatte") {
                answer += 5000;
            }
        }
        return answer;
    }
}