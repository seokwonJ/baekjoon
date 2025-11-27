public class Solution {
    public string solution(int num) {
        string answer = "";
        if (num % 2 == 1 || num % 2 == -1) return "Odd";
        else if(num % 2 == 0) return "Even";
        else return "NO";
    }
}