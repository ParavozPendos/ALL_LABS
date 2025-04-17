#include <iostream>
using namespace std;

const unsigned int L_MAX = 100;
const int MAXINT = 2147483647;
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

void Sort(int row, int cols)
{
    for (int i = 2; i < cols; i++)
    {
        if (matrix[row][i - 1] < matrix[row][i])
        {
            matrix[row][0] = matrix[row][i];
            int j = i - 1;

            while (matrix[row][j] < matrix[row][0])
            {
                matrix[row][j + 1] = matrix[row][j];
                j--;
            }

            matrix[row][j + 1] = matrix[row][0];
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
        Sort(i, cols);
    }

    cout << "Отсортированная матрица" << endl;
    Printer(rows, cols);

    system("pause>nul");
}