#include <iostream>
using namespace std;

const unsigned int L_MAX = 100;
int matrix[L_MAX][L_MAX + 1];

void MatrixInit(int rows, int cols)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 1; j < cols; j++)
        {
            matrix[i][j] = rand() % 20;
        }
    }
}

void Printer(int rows, int cols)
{
    for (int i = 0; i < cols; i++)
    {
        cout << "--------";
    }
    cout << endl;

    for (int i = 0; i < rows; i++)
    {
        cout << "|\t";
        for (int j = 1; j < cols; j++)
        {
            cout << matrix[i][j] << "\t";
        }
        cout << "|" << endl;
    }

    for (int i = 0; i < cols; i++)
    {
        cout << "--------";
    }
    cout << endl << endl;

}

void Sort(int size, int arr[])
{
    for (int i = 2; i < size; i++)
    {
        if (arr[i - 1] < arr[i])
        {
            arr[0] = arr[i];
            int j = i - 1;

            while (arr[j] < arr[0])
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = arr[0];
        }
    }
}


int main()
{
    setlocale(LC_ALL, "");
    srand(time(NULL));

    unsigned int rows, cols;

    cout << "Введите кол-во строк и столбцов: ";
    cin >> rows >> cols;
    cout << endl;

    cols++; //для барьера

    MatrixInit(rows, cols);
    cout << "Исходная матрица" << endl;
    Printer(rows, cols);

    for (int i = 0; i < rows; i++)
    {
        Sort(cols, matrix[i]);
    }

    cout << "Отсортированная матрица" << endl;
    Printer(rows, cols);

    system("pause>nul");
}