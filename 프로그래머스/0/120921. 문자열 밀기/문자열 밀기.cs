using System;

public class Solution {
    public int solution(string A, string B) {
        for (int i = 0; i < A.Length; i++) {
            bool match = true;
            for (int j = 0; j < A.Length; j++) {
                if (A[j] != B[(i + j) % B.Length]) {
                    match = false;
                    break;
                }
            }
            if (match) {
                return i; // 오른쪽으로 i번 밀면 B와 같음
            }
        }
        return -1;
    }
}