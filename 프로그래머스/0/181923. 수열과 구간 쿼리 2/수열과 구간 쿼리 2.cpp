#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> arr, vector<vector<int>> queries) {
    vector<int> answer;
    for (int i=0;i < queries.size();i++) {
        int tmp;
        int diff = 0;
        for (int j = queries[i][0]; j <= queries[i][1];j++) {
            if (diff == 0) {
                tmp = queries[i][2];                
            }

            if (tmp == queries[i][2] && arr[j] > tmp) {
                tmp = arr[j];
                diff = 1;
            }
            else if (tmp != queries[i][2] && arr[j] > queries[i][2] && arr[j] < tmp) {
                tmp = arr[j];
            }
        }
        if (tmp == queries[i][2]) {
            answer.push_back(-1);
        }
        else {
            answer.push_back(tmp);
        }
    }
    return answer;
}