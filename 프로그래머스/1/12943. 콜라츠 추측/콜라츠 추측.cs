public class Solution {
    public int solution(int num) {
        int answer = 0;
        long numSum = num;
        if (num==1) return 0; 
        while(true) {
            answer++;
            if (numSum % 2 == 0) numSum /= 2;
            else if (numSum % 2 == 1){
                numSum = numSum * 3 + 1;
            }
            if (numSum == 1) break;
            if (answer >= 500) return -1;
        }
        return answer;
    }
}