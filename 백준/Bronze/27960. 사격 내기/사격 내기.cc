#include <cstdio>
#include <math.h>

using namespace std;

int ScoreBoard[10] = {0,};

int main()
{
    int A, B;
    int sum = 0;
    scanf("%d %d", &A, &B);

    for (int i = 9; i >= 0; i--)
    {
        if (A >= pow(2, i))
        {
            A -= pow(2, i);
            ScoreBoard[i]++;
        }
        if (B >= pow(2, i))
        {
            B -= pow(2, i);
            ScoreBoard[i]++;
        }
    }

    for (int j = 0; j <= 9; j++)
    {
        if (ScoreBoard[j] == 1)
            sum += pow(2, j);
    }
    printf("%d", sum);
    return 0;
}