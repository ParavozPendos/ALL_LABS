#include <iostream>
#include <string>
using namespace std;

bool StringChecker(string str)
{
    unsigned int left = 0, right = 0, balance = 0;

    while (left < str.size() || right < str.size())
    {
        left = str.find('(', left);
        right = str.find(')', right);
        if (left != string::npos && left < str.size()) balance++, left++;
        if (right != string::npos && right < str.size()) balance--, right++;
        if (balance != 0 || right < left) return 0;
    }
    return balance == 0;
}

int main()
{
    setlocale(LC_ALL, "");
    string str;


    cout << "Введите строку" << endl;
    getline(cin, str);
    if (StringChecker(str)) cout << "Совпадает!";
    else cout << "Не совпадает!";



    system("pause>nul");
}