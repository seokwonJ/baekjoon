public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        int index = 0;
        for (int i = 0;i < seoul.Length;i++) {
            if(seoul[i] == "Kim") {
                index = i;
                break;
            }
        }
        
        answer = "김서방은 " + index + "에 있다";
        
        return answer;
    }
}