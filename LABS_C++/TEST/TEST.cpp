#include <iostream>
#include <ctime>

int A[100][100];

void Print(int N)
{
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            std::cout << A[i][j] << "\t";
        }
        std::cout << std::endl;
    }
    std::cout << std::endl;
}


int main() {
    srand(time(NULL));
    setlocale(LC_ALL, "");

    int N;
    std::cout << "Введите число: ";
    std::cin >> N;

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            A[i][j] = 1 + rand() % 20;
        }
    }

    std::cout << "Исходная матрица:" << std::endl;
    Print(N);

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            if (j >= i) continue;
            int temp = A[i][j];
            A[i][j] = A[j][i];
            A[j][i] = temp;
        }
    }

    Print(N);

    system("pause>nul");
}