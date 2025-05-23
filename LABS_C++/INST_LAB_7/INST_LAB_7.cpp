#include <iostream>
#include <string>
using namespace std;

int main()
{
    setlocale(LC_ALL, "");
    
    string str;
    unsigned int open[3] = { 0 }, close[3] = {0};

    cout << "Введите строку" << endl;
    
    getline(cin, str);

    for (int i = 0; i < str.size(); i++)
    {
        switch (str[i])
        {
            case '{': open[0]++; break;
            case '[': open[1]++; break;
            case '(': open[2]++; break;
            case '}': close[0]++; break;
            case ']': close[1]++; break;
            case ')': close[2]++; break;
            default: break;
        }
    }

    if (open[0] == close[0] and open[1] == close[1] and open[2] == close[2])
        cout << "Кол-во закрывающих и открывающих скобок совпадает";
    else
        cout << "Кол-во закрывающих и открывающих скобок отличается";

    system("pause>nul");
}