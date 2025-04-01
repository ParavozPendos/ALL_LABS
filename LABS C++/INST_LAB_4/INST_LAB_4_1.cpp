#include <iostream>
#include <cmath>
#include <ctime>
using namespace std;

unsigned int SmallestDevider(int value)
{
    int smalest = 3;
    while (value % smalest != 0 || smalest % 2 !=1)
    {
        smalest++;
    }
    if (smalest == value)
    {
        cout << endl << "Простое число! ";
    }
    
    return smalest;
}


int main()
{
    setlocale(LC_ALL, "");
    int num;

    cout << "Введите число: ";
    cin >> num;

    num = SmallestDevider(num);

    cout << endl << "Наименьшее нечетное натуральное число: " << num;

    system("pause>nul");
}