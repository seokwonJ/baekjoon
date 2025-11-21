using System;
using System.Collections.Generic;

public class Solution {
    
    // 두 단어가 한 개의 알파벳만 다른지 확인하는 헬퍼 함수
    private bool CanConvert(string word1, string word2) {
        int diffCount = 0;
        for (int i = 0; i < word1.Length; i++) {
            if (word1[i] != word2[i]) {
                diffCount++;
            }
        }
        return diffCount == 1;
    }

    public int solution(string begin, string target, string[] words) {
        // 1. target이 words에 없으면 변환 불가능 (예외 #2)
        if (Array.IndexOf(words, target) == -1) {
            return 0;
        }

        // 2. BFS를 위한 큐와 방문 여부 배열 초기화
        // 큐에는 현재 단어와, 그 단어까지 도달하는 데 걸린 단계(횟수)를 저장합니다.
        Queue<(string word, int step)> queue = new Queue<(string, int)>();
        // 모든 단어(words)의 방문 여부를 저장합니다. 
        // begin은 words에 없을 수 있으므로, words만 기준으로 visited 배열을 만듭니다.
        bool[] visited = new bool[words.Length]; 

        queue.Enqueue((begin, 0));

        // 3. BFS 실행
        while (queue.Count > 0) {
            (string currentWord, int currentStep) = queue.Dequeue();

            // 목표 단어에 도달한 경우 (가장 짧은 경로)
            if (currentWord == target) {
                return currentStep;
            }

            // words 배열을 순회하며 다음 변환 가능한 단어를 찾습니다.
            for (int i = 0; i < words.Length; i++) {
                string nextWord = words[i];

                // 아직 방문하지 않았고, 현재 단어와 한 글자만 다른 경우
                if (!visited[i] && CanConvert(currentWord, nextWord)) {
                    visited[i] = true;
                    // 다음 단어와 단계 + 1을 큐에 추가
                    queue.Enqueue((nextWord, currentStep + 1));
                }
            }
        }

        // 큐가 비었는데 target에 도달하지 못한 경우 (변환 불가능)
        return 0;
    }
}