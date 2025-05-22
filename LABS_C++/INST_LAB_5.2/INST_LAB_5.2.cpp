#include <iostream>
using namespace std;

const unsigned int L_MAX = 100;
int arr[L_MAX][L_MAX];

void MatrixInit(int rows, int cols)
{
    for (size_t i = 0; i < rows; i++)
    {
        for (size_t j = 0; j < cols; j++)
        {
            arr[i][j] = rand() % 10;
        }
    }
}

void Printer(int rows, int cols)
{
    for (size_t i = 0; i < rows; i++)
    {
        for (size_t j = 0; j < cols; j++)
        {
            cout << arr[i][j] << "\t";
        }
        cout << endl;
    }
    for (size_t i = 1; i < cols; i++)
    {
        cout << "--------";
    }
    cout << "--" << endl;
}

int ColSum(int rows, int col)
{
    int sum = 0;
    for (size_t i = 0; i < rows; i++)
    {
        sum += arr[i][col];
    }
    return sum;
}


int main()
{
    setlocale(LC_ALL, "");
    srand(time(NULL));
    
    unsigned int rows, cols;
    cout << "Введите кол-во строк и столбцов (кратно 4): ";
    cin >> rows >> cols;
    cout << endl;
    
    
    MatrixInit(rows, cols);
    Printer(rows, cols);

    for (size_t i = 0; i < cols; i++)
    {
        if (i < cols / 2 || i % 2 == 1)
            cout << ColSum(rows, i) << "\t";
        else
            cout << "0\t";
    }
    system("pause>nul");
}

