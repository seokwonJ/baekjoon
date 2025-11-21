using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] operations) {
        
        // Key: 숫자 값 (자동 오름차순 정렬), Value: 해당 숫자의 개수
        SortedDictionary<int, int> doubleEndedQueue = new SortedDictionary<int, int>();

        foreach (string op in operations) {
            string[] parts = op.Split(' ');
            char command = parts[0][0]; // 명령어 (I, D)
            int data = int.Parse(parts[1]); // 숫자 데이터 (N, 1, -1)

            if (command == 'I') {
                // 큐에 숫자 삽입
                if (doubleEndedQueue.ContainsKey(data)) {
                    doubleEndedQueue[data]++;
                } else {
                    doubleEndedQueue.Add(data, 1);
                }
            } else if (command == 'D') {
                // 삭제 연산
                
                // 1. 빈 큐에 삭제 명령이 주어질 경우 무시
                if (doubleEndedQueue.Count == 0) {
                    continue;
                }
                
                int keyToDelete = 0;

                if (data == 1) {
                    // 최댓값 삭제 (SortedDictionary의 마지막 키)
                    keyToDelete = doubleEndedQueue.Keys.Last();
                } else if (data == -1) {
                    // 최솟값 삭제 (SortedDictionary의 첫 번째 키)
                    keyToDelete = doubleEndedQueue.Keys.First();
                }
                
                // 2. 해당 키의 개수(Value) 감소
                doubleEndedQueue[keyToDelete]--;

                // 3. 개수가 0이 되면 맵에서 완전히 삭제
                if (doubleEndedQueue[keyToDelete] == 0) {
                    doubleEndedQueue.Remove(keyToDelete);
                }
            }
        }

        // 4. 모든 연산을 처리한 후 최종 결과 반환
        if (doubleEndedQueue.Count == 0) {
            return new int[] { 0, 0 };
        } else {
            int maxValue = doubleEndedQueue.Keys.Last();  // 최댓값
            int minValue = doubleEndedQueue.Keys.First(); // 최솟값
            return new int[] { maxValue, minValue };
        }
    }
}