using System;

class OneDimSearch
{
    static double f(double x) => (x - 9) * (x - 9);

    // Метод дихотомии
    static (double min, int calls) Dichotomy(double a, double b, double eps)
    {
        double delta = 1e-10;   
        int calls = 0;
        while (b - a >= eps)
        {
            double mid = (a + b) / 2;
            double x1 = mid - delta;
            double x2 = mid + delta;
            double f1 = f(x1);
            double f2 = f(x2);
            calls += 2;
            if (f1 < f2)
                b = x2;
            else
                a = x1;
        }
        return ((a + b) / 2, calls);
    }

    // Метод золотого сечения
    static (double min, int calls) GoldenSection(double a, double b, double eps)
    {
        double phi = (1 + Math.Sqrt(5)) / 2;      // 1.618...
        double tau = 1 - 1 / phi;                // 0.382...
        double x1 = a + (1 - tau) * (b - a);     // = a + 0.382*(b-a)
        double x2 = a + tau * (b - a);           // = a + 0.618*(b-a)
        double f1 = f(x1), f2 = f(x2);
        int calls = 2;

        while (b - a >= eps)
        {
            if (f1 < f2)
            {
                b = x2;
                x2 = x1;
                f2 = f1;
                x1 = a + (1 - tau) * (b - a);
                f1 = f(x1);
            }
            else
            {
                a = x1;
                x1 = x2;
                f1 = f2;
                x2 = a + tau * (b - a);
                f2 = f(x2);
            }
            calls++;
        }
        return ((a + b) / 2, calls);
    }

    static void Main()
    {
        double a = -2, b = 20;
        double eps = 0.001;

        // Запуск для ε = 0.001 с подробным выводом
        Console.WriteLine("Метод дихотомии (ε=0.001)");
        var (minDich, callsDich) = Dichotomy(a, b, eps);
        Console.WriteLine($"x_min = {minDich:F8}, f(x_min) = {f(minDich):F8}, вызовов = {callsDich}");

        Console.WriteLine("\nМетод золотого сечения (ε=0.001)");
        var (minGold, callsGold) = GoldenSection(a, b, eps);
        Console.WriteLine($"x_min = {minGold:F8}, f(x_min) = {f(minGold):F8}, вызовов = {callsGold}");

        // Сравнение для разных ε
        Console.WriteLine("\nСравнение по точности:");
        Console.WriteLine("ε\t\tДихотомия\tЗолотое сечение");
        for (int p = 2; p <= 8; p++)
        {
            double e = Math.Pow(10, -p);
            int d = Dichotomy(a, b, e).calls;
            int g = GoldenSection(a, b, e).calls;
            Console.WriteLine($"{e:F8}\t{d}\t\t{g}");
        }
        Console.ReadKey();
    }
}