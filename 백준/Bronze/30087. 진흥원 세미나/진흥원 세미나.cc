#include <iostream>
#include <string.h>

using namespace std;

int main()
{
    int num;
    string n;
    cin >> num;
    for (int i = 0; i < num; i++) {
        cin >> n;;
        if (n == "Algorithm") {
            cout << "204";
        }
        if (n == "DataAnalysis") {
            cout << "207";
        }
        if (n == "ArtificialIntelligence") {
            cout << "302";
        }
        if (n == "CyberSecurity") {
            cout << "B101";
        }
        if (n == "Network") {
            cout << "303";
        }
        if (n == "Startup") {
            cout << "501";
        }
        if (n == "TestStrategy") {
            cout << "105";
        }
        cout << "\n";
    }
    return 0;
}