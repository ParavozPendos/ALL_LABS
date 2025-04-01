#include <iostream>
#include <math.h>

using namespace std;

int main()
{

    setlocale(LC_ALL, "");

    long int i;
    long int a, n, num, counter = 0;

    cout << "Введите 2 числа через пробел, а - искомое число, n - колличество случайных чисел в диапозоне от 0 до 99: "; 
    cin >> a >> n;
    cout << endl;
    
    for (i = 1; i < n+1; i++) {
        num = rand() % (100);
        cout << num << " ";
        if (a == num) {
            cout << "\nВ последовальности есть число " << a << " и оно идет " << i << "м по списку\n\n";
            counter++;
        }
    }

    if (counter == 0)
        cout << "Числа " << a << " не нашлось в последовальности из " << n << " числел\n\n";

    system("pause");
}



