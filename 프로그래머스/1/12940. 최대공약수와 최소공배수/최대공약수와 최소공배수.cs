public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[] {};
        
        int nn = n;
        int mm = m;
        
        if (n < m) {
        }
        else {
            nn = m;
            mm = n;
        }
        
        int num = 1;
        
        while (true) {
            bool isPass = false;
            for (int i = 2;i < mm;i++) {
                if (nn % i == 0 && mm % i == 0) {
                    nn /= i;
                    mm /= i;
                    num *= i;
                    isPass = true;
                }
            }
            if (!isPass) break;
        }
        
        answer = new int[2] {num, num * nn * mm};
        
        return answer;
    }
}