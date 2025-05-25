#include <iostream>
#include <string>
#include <fstream>
#include <Windows.h>
using namespace std;

int main()
{
    setlocale(LC_ALL, "");
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    string path = "TEXT.txt";
    fstream fs;

    fs.open(path, fstream::in | fstream::out | fstream::app);

    if (!fs.is_open()) cout << "ERROR";
    else
    {
       
    }
    
    
    fs.close();
    system("pause>nul");
}