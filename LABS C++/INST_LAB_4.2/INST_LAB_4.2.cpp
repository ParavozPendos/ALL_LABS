#include <iostream>
using namespace std;

const unsigned int ま = 100;

int matrix1[ま][ま];
int matrix2[ま][ま];

void MatrixInit(int rows, int cols, int matrix[ま][ま])
{
    for (size_t i = 0; i < rows; i++)
    {
        for (size_t j = 0; j < cols; j++)
        {
            matrix[i][j] = rand() % 100;
        }
    }
}

void Printer(int rows, int cols, int matrix[ま][ま])
{
    for (size_t i = 0; i < rows; i++)
    {
        for (size_t j = 0; j < cols; j++)
        {
            cout << matrix[i][j] << "\t";
        }
        cout << endl;
    }
    cout << endl;
}
void ColSwapper(int cols, int rows, int first, int second, int matrix[ま][ま])
{
    first--;
    second--;

    for (size_t i = 0; i < rows; i++)
    {
        swap(matrix[i][first], matrix[i][second]);
    }
}

int main()
{
    setlocale(LC_ALL, "");
    srand(time(NULL));

    unsigned int row1, col1, row2, col2, left1, right1, left2, right2;

    cout << "введите кол-во строк и столбцов 1-й матрицы: ";
    cin >> row1 >> col1;
    cout << "введите кол-во строк и столбцов 2-й матрицы: ";
    cin >> row2 >> col2;

    MatrixInit(row1, col1, matrix1);
    MatrixInit(row2, col2, matrix2);

    Printer(row1, col1, matrix1); 
    Printer(row2, col2, matrix2);

    cout << "Выберете какие столбики в первой матрице вы хотите поменять: ";
    cin >> left1 >> right1;

    ColSwapper(row1, col1, left1, right1, matrix1);
    Printer(row1, col1, matrix1);

    cout << "Выберете какие столбики во второй матрице вы хотите поменять: ";
    cin >> left2 >> right2;

    ColSwapper(row2, col2, left2, right2, matrix2);
    Printer(row2, col2, matrix2);


    system("pause");
}