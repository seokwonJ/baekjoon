#include <vector>
#include <iostream>

using namespace std;

vector<int> solution(vector<int> arr) 
{
    vector<int> answer;
    answer.reserve(arr.size()); // 대량 입력 대비

    for (int x : arr) {
        if (answer.empty() || answer.back() != x) {
            answer.push_back(x);
        }
        // 같으면 건너뜀(연속 중복 제거)
    }
    return answer;
}