using System;
using System.Collections.Generic;


public class Solution {
    public int solution(int[] priorities, int location) {
        int num = 0;
        int count = 0;
        int answer = 0;
        
        while(count != priorities.Length){
            int priority = 0;
            int index = 0;
            int nextIndex = num;
            index = num;
            count++;
            
            priority = priorities[index];
            
            while(true){
                if (priority < priorities[index] && priorities[index] != -1) {
                    priority = priorities[index];
                    nextIndex = index;
                }
                index = (index+1) % priorities.Length;
                if (index == num)  {
                    priorities[nextIndex] = -1;
                    break;
                }
            }
            
            num = nextIndex;
            if (num == location) answer = count;
        }
        
        return answer;
    }
}