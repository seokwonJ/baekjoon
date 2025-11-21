using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    
    private struct Job {
        public int requestTime; // 요청 시각 (s)
        public int duration;    // 소요 시간 (l)
    }

    // 🚨 수정: 입력 배열 타입을 int[,]로 변경했습니다.
    public int solution(int[,] jobs) {
        
        // 1. Jobs를 Job 구조체 리스트로 변환 및 요청 시각(requestTime) 기준으로 정렬
        int jobCount = jobs.GetLength(0);
        List<Job> jobList = new List<Job>();

        for (int i = 0; i < jobCount; i++) {
            jobList.Add(new Job { 
                requestTime = jobs[i, 0], 
                duration = jobs[i, 1] 
            });
        }
        
        // 요청 시각이 빠른 순으로 정렬
        jobList = jobList.OrderBy(j => j.requestTime).ToList();

        int N = jobList.Count;
        
        // 🚨 PriorityQueue 대안: 처리 가능한 작업을 저장할 List
        // 이 List는 처리 가능한 작업들 중 소요 시간이 가장 짧은 것을 찾기 위해 사용됩니다.
        List<Job> availableJobs = new List<Job>(); 

        long totalTurnaroundTime = 0; 
        int currentTime = 0;          
        int jobIndex = 0;             
        int processedCount = 0;

        // 2. 시뮬레이션 루프: 모든 작업을 처리할 때까지 반복
        while (processedCount < N) {
            
            // 2-1. 현재 시점(currentTime) 이전에 요청된 모든 작업을 Available Jobs 리스트에 삽입
            while (jobIndex < N && jobList[jobIndex].requestTime <= currentTime) {
                availableJobs.Add(jobList[jobIndex]);
                jobIndex++;
            }

            // 2-2. 작업 선택 및 처리
            if (availableJobs.Count > 0) {
                
                // 🚨 PriorityQueue 대안: availableJobs 중에서 소요 시간이 가장 짧은 Job을 찾습니다.
                // LINQ를 사용하여 가장 짧은 duration을 가진 요소를 찾고, 같을 경우 요청 시각이 빠른 것을 찾습니다.
                Job currentJob = availableJobs
                                .OrderBy(j => j.duration)
                                .ThenBy(j => j.requestTime) // 소요 시간이 같으면 요청 시각이 빠른 것
                                .First();

                availableJobs.Remove(currentJob); // 찾은 Job 제거

                // 작업 시작 시각: 현재 시각
                int startTime = currentTime;
                // 작업 종료 시각
                int endTime = startTime + currentJob.duration;

                // 반환 시간 = 종료 시각 - 요청 시각
                int turnaroundTime = endTime - currentJob.requestTime;

                // 결과 업데이트
                totalTurnaroundTime += turnaroundTime;
                currentTime = endTime; 
                processedCount++;
            } 
            else {
                // Available Jobs가 비었고, 아직 처리할 작업이 남아있다면:
                // 다음 작업 요청 시점까지 시간을 건너뜁니다.
                if (jobIndex < N) {
                    currentTime = jobList[jobIndex].requestTime;
                }
                else
                {
                    // 모든 작업이 처리되었으므로 루프 종료
                    break;
                }
            }
        }

        // 3. 결과 반환: 평균 반환 시간의 정수 부분
        return (int)(totalTurnaroundTime / N);
    }
}