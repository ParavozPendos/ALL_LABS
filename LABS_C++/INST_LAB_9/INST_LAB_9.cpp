#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>
#include <Windows.h>
using namespace std;

void main()
{
    //Общая часть
    setlocale(LC_ALL, "");
    srand(time(NULL));

    struct Bagazh
    {
        int count;
        double weight;
    };
    Bagazh temp;

    //Часть первой программы
    {
        fstream writer;
        int number;

        cout << "Введите количество багажей для добавления (-1) для отчистки: ";
        cin >> number;
        cout << endl;

        writer.open("Bagazhi.dat", ios::out | ios::app | ios::binary);

        if (!writer.is_open()) cout << "Файл \"writer\" не удалось открыть\n";
        else
        {
            cout << "Открытие файла \"writer\" успешно!\n";
            if (number == -1)
            {
                writer.close();
                writer.open("Bagazhi.dat", ios::out | ios::binary | ios::trunc);
                cout << "Файл очищен!\n";
            }
            for (int i = 0; i < number; i++)
            {
                temp.count = rand() % 4 + 1;
                temp.weight = (rand() % 5000) / 100.0;
                writer.write(reinterpret_cast<char*>(&temp), sizeof(Bagazh));
            }
        }
        writer.close();
    }

    //Часть второй программы
    {
        fstream reader;
        bool isFind = false;

        reader.open("Bagazhi.dat", ios::in | ios::ate | ios::binary);
        if (!reader.is_open()) cout << "Файл \"reader\" не удалось открыть\n";
        else
        {
            cout << "Открытие файла \"reader\" успешно!\n\n";

            reader.seekg(0, ios::beg);
            while (reader.read(reinterpret_cast<char*>(&temp), sizeof(Bagazh)))
            {
                cout << "Число вещей: " << temp.count << "| Вес багажа: " << setw(7) << right << temp.weight << " кг" << endl;
                if (temp.count == 1 && temp.weight <= 30)
                {
                    isFind = true;
                }
            }
            if (isFind) cout << "\nСреди них был минимум 1 багаж с 1 вещью, весом менее 30кг\n";
            else cout << "\nСреди них не было ни одного багажа с одной вещью и весом 30кг\n";

            cout << "\n\n";
        }
        reader.close();
    }

    system("pause>nul");
}