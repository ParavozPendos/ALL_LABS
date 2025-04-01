
#include <iostream>
#include <math.h>

using namespace std;

int main()
{
    setlocale(LC_ALL, "");

    // Часть 1
    
    float e1_max_x = 1.;
    float e1_max_y = 1.;
    float e2_min_x = 2.;
    float e2_min_y = 2.;
    float e2_max_x = 3.;
    float e2_max_y = 2.;

    float user_x;
    float user_y;

    cout << "Введите x и y координаты точки: "; cin >> user_x >> user_y;

    if (sqrt(pow(user_x / e1_max_x, 2.) + pow(user_y / e1_max_y, 2.)) <= 1 or 

        (sqrt(pow(user_x / e2_min_x, 2.) + pow(user_y / e2_min_y, 2.)) >= 1 
        and 
        sqrt(pow(user_x / e2_max_x, 2.) + pow(user_y / e2_max_y, 2.)) <= 1)

        ){
        cout << "Точка (" << user_x << ";" << user_y << ") пренадлежит фигуре\n\n";
    }
    else {
        cout << "Точка (" << user_x << ";" << user_y << ") не пренадлежит фигуре\n\n";
    }

    // Часть 2

    unsigned int counter = 0;
    float m, n, p;

    cout << "Введите числа m, n, p: "; cin >> m >> n >> p;

    if (m == floor(m)) {
        counter++;
    }
    if (n == floor(n)) {
        counter++;
    }
    if (p == floor(p)) {
        counter++;
    }

    cout << "Количество целых чисел = " << counter << endl << endl;

    system("pause");
}