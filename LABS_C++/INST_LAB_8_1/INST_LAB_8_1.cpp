#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>
#include <Windows.h>
using namespace std;

void main()
{
    setlocale(LC_ALL, "");
    setlocale(LC_NUMERIC, "C");
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    fstream fs;

    const string OPS = "+-*/", digitsDot = "0123456789.", digits = "0123456789", path = "TEXT.txt";
    string str, temp, partA, partB;
    char partQ;
    unsigned int qPos = 0, leftPos, rightPos;
    double valueA, valueB, result = 0;

    fs.open(path,fstream::in);

    if (!fs.is_open()) cout << "ERROR\n";
    else
    {
        cout << "SUCCSESS\n";
        while (fs >> temp)
        {
            str.append(temp + " ");
        }
        cout << "Изначальная строка" << str << endl << endl;

        while (qPos != -1)
        {
            // Q
            qPos = str.find_first_of(OPS, qPos + 1);
            if (qPos == -1) break;
            if (str[qPos - 1] == ' ') str.erase(qPos - 1, 1), qPos--;
            if (str[qPos + 1] == ' ') str.erase(qPos + 1, 1);
            partQ = str[qPos];

            // A
            leftPos = str.find_last_not_of(digitsDot, qPos - 1);
            partA = str.substr(leftPos + 1, qPos - leftPos - 1);
            if (partA == "" || partA == ".") continue;
            if (partA.front() == '.') partA.erase(0, partA.find_first_of(digits, 0));
            if (partA.back() == '.') partA.pop_back();

            // B
            rightPos = str.find_first_not_of(digitsDot, qPos + 1);
            partB = str.substr(qPos + 1, rightPos - qPos - 1);
            if (partB == "" || partB.front() == '.') continue;
            if (partB.back() == '.') partB.erase(partB.find_last_of(digits, partB.back()));
            

            valueA = stod(partA);
            valueB = stod(partB);

            switch (partQ)
            {
            case '+': result = valueA + valueB; break;
            case '-': result = valueA - valueB; break;
            case '*': result = valueA * valueB; break;
            case '/':
                if (valueB != 0)
                {
                    result = valueA / valueB;
                    break;
                }
                else
                {
                    result = 0;
                    cout << "ОШИБКА, ДЕЛЕНИЕ НА НОЛЬ!" << " ";
                    break;
                }
            default: break;
            }

            cout << setprecision(10) <<partA << " " << partQ << " " << partB << " = " << result << endl;
        }
    }

    fs.close();
    system("pause>nul");
}