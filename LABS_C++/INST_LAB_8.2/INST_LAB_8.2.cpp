#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>
#include <Windows.h>
#include <random>
using namespace std;

void main()
{
    setlocale(LC_ALL, "");
    srand(time(NULL));

    fstream f, g;
    string fpath = "f.dat";
    string gpath = "g.dat";

    int count, temp, sum, t1, t2;

    cout << "Введите количество целых числел: ";
    cin >> count;
    cout << endl;

    f.open(fpath, ios::in | ios::out |ios::binary | ios::trunc);
    g.open(gpath, ios::in | ios::out | ios::binary | ios::trunc);

    if (!f.is_open()) cout << "Файл \"f\" не удалось открыть\n";
    else
    {
        cout << "Открытие файла \"f\" успешно!\n\n";

        for (int i = 0; i < count; i++)
        {
            temp = rand() % 20;
            f.write(reinterpret_cast<char*>(&temp), sizeof(int));
        }

        // для человеческого отображения данных
        f.seekg(0, ios::beg);
        for(int i = 0; i < count; i++)
        {
            f.read(reinterpret_cast<char*>(&temp), sizeof(int));
            cout << temp << " ";
        }
        cout << "\n\n";
    }

    if (!g.is_open()) cout << "Файл \"g\" не удалось открыть\n";
    else
    {
        cout << "Открытие файла \"g\" успешно!\n\n";
        f.seekg(0, ios::beg);
        g.seekg(0, ios::beg);

        for (int i = 0; i < count-1; i++)
        {
            f.seekg(i * sizeof(int), ios::beg);
            f.read(reinterpret_cast<char*>(&t1), sizeof(int));
            f.seekg(0, ios::cur);
            f.read(reinterpret_cast<char*>(&t2), sizeof(int));

            sum = t1 * t2;
            g.write(reinterpret_cast<char*>(&sum), sizeof(int));
        }

        // для человеческого отображения данных
        g.seekg(0, ios::beg);
        for (int i = 0; i < count - 1; i++)
        {
            g.read(reinterpret_cast<char*>(&temp), sizeof(int));
            cout << temp << " ";
        }
        cout << "\n\n";
    }

    f.close();
    g.close();
    system("pause>nul");
}