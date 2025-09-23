using System;
using System.Linq;
public class Solution {
    public int solution(int[] sides)
        {
            int answer = 0;
            int max = sides.Max();
            int min = sides.Min();

            for (int i = 1; i < max + min; i++)
            {
                if (max < i + min)
                {
                    answer++;
                }
            }
            return answer;
        }
}
