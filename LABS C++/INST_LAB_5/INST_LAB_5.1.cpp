#include <iostream>
#include <ctime>

using namespace std;

int main()
{
    setlocale(LC_ALL, "");

    int i;
    const int N = 100;
    float A[N], B[N / 2] = {0}, C[N / 2] = {0};
    srand(time(NULL));

    for (i = 0; i < N; i++) {
        A[i] = rand() % 100;
        cout << A[i] << " ";
        if (i % 2 == 0)
            B[i / 2] = A[i];
        else
            C[(i - 1) / 2] = A[i];
    }

    cout << "\n------------------------------\n";
    for (i = 0; i < N / 2; i++)
        cout << B[i] << " ";

    cout << "\n------------------------------\n";
    for (i = 0; i < N / 2; i++)
        cout << C[i] << " ";

    system("pause");
}