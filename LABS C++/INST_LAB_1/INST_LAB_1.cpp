#include <iostream>
#include <iomanip>
#include <math.h>
using namespace std;

int main()
{
	setlocale(LC_ALL, "");

	// Часть #1

	float Melchor;
	float Nikel;
	float Copper;

	cout << "Введите массу Мелькхора: ";
	cin >> Melchor;		

	Nikel = Melchor / 11 * 2;
	Copper = Melchor / 11 * 9;

	cout.precision(15);

	cout << "Масса Никеля = ";
	cout.width(30);
	cout << Nikel << endl;
	cout << "Масса Меди   = ";
	cout.width(30);
	cout << Copper << endl << endl;

	// Часть #2


	double x;
	double y;

	cout << "Введите число x: ";
	cin >> x;
			
	y = sqrt(exp(2 * x) * sqrt(x) - ((x + 1.0 / 3.0) / x)) * fabs(cos(2.5 * x));

	cout << "Результат    = ";
	cout.width(30);
	cout  << y << endl << endl;
	system("pause ");
}