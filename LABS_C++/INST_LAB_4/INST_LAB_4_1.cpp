#include <iostream>
#include <cmath>
using namespace std;

int SmallestOddDivisor(int value) 
{
    bool isEven = value % 2 == 0;
    int smallest = 3;

    if (value == 1)
    {
        return 0;
    }
    while (smallest < value)
    {
        if (value % smallest == 0)
        {
            return smallest;
        }
        smallest += 2;
    }
    if (!isEven)
    {
        cout << "Это простое число!\n";
        return value;
    }
    else
        return 0;
}

int main() {
    setlocale(LC_ALL, "");
    int n;
    cout << "Введите натуральное число n: ";
    cin >> n;

    int k = SmallestOddDivisor(n);

    if (k == 0) 
    {
        cout << "Нет нечётных делителей" << endl;
    }
    else 
    {
        cout << "Наименьший нечётный делитель: " << k << endl;
    }

    system("pause>nul");
    return 0;
}