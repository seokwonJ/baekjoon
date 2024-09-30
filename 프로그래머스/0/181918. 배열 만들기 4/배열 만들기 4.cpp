#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> arr) {
    vector<int> stk;
    int i = 0;
    while (true) {
        if (i == arr.size()) {
            break;
        }
        if (stk.empty()) {
            stk.push_back(arr[i]);
            i += 1;
        }
        else if (stk.back() < arr[i]) {
            stk.push_back(arr[i]);
            i += 1;
        }
        else {
            stk.pop_back();
        }
        
    }
    return stk;
}