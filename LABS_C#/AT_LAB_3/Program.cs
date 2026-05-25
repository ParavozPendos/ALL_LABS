using System;

namespace NumericalIntegration
{
    class Program
    {
        // Верхняя функция
        static double f1(double x) => -x * x + 3 * x + 3;

        // Нижняя функция
        static double f2(double x) => x * x - 3 * x + 2;

        // Разность (подынтегральная функция)
        static double f(double x) => f1(x) - f2(x);

        // Точное значение площади (аналитическое)
        static double ExactArea() => (11 * Math.Sqrt(11)) / 3;

        // Метод левых прямоугольников
        static double LeftRectangles(double a, double b, double h)
        {
            int n = (int)((b - a) / h);
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double x = a + i * h;
                sum += f(x);
            }
            return sum * h;
        }

        // Метод правых прямоугольников
        static double RightRectangles(double a, double b, double h)
        {
            int n = (int)((b - a) / h);
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double x = a + i * h;
                sum += f(x);
            }
            return sum * h;
        }

        // Метод средних прямоугольников
        static double MiddleRectangles(double a, double b, double h)
        {
            int n = (int)((b - a) / h);
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double x = a + (i + 0.5) * h;
                sum += f(x);
            }
            return sum * h;
        }

        // Метод трапеций
        static double Trapezoid(double a, double b, double h)
        {
            int n = (int)((b - a) / h);
            double sum = (f(a) + f(b)) / 2;
            for (int i = 1; i < n; i++)
            {
                double x = a + i * h;
                sum += f(x);
            }
            return sum * h;
        }

        // Метод Монте-Карло
        static double MonteCarlo(double a, double b, int points, Random rand)
        {
            // Точные границы фигуры по y
            double yMin = -0.3;
            double yMax = 5.3;
            int inside = 0;
            for (int i = 0; i < points; i++)
            {
                double x = a + rand.NextDouble() * (b - a);
                double y = yMin + rand.NextDouble() * (yMax - yMin);
                if (y <= f1(x) && y >= f2(x))
                    inside++;
            }
            double rectArea = (b - a) * (yMax - yMin);
            return rectArea * inside / points;
        }

        static void Main()
        {
            double a = (3 - Math.Sqrt(11)) / 2;
            double b = (3 + Math.Sqrt(11)) / 2;
            double exact = ExactArea();

            Console.WriteLine("Границы интегрирования:");
            Console.WriteLine($"a = {a:F6}");
            Console.WriteLine($"b = {b:F6}");
            Console.WriteLine($"\nТочное значение площади: {exact:F6}\n");

            // Шаги для исследования точности
            double[] steps = { 0.5, 0.2, 0.1, 0.05, 0.01 };

            Console.WriteLine("Погрешности методов численного интегрирования:");
            Console.WriteLine($"{"Шаг",-10} {"Левые",-15} {"Правые",-15} {"Средние",-15} {"Трапеции",-15}");
            foreach (double h in steps)
            {
                double left = LeftRectangles(a, b, h);
                double right = RightRectangles(a, b, h);
                double middle = MiddleRectangles(a, b, h);
                double trap = Trapezoid(a, b, h);

                double errLeft = Math.Abs(exact - left);
                double errRight = Math.Abs(exact - right);
                double errMiddle = Math.Abs(exact - middle);
                double errTrap = Math.Abs(exact - trap);

                Console.WriteLine($"{h,-10:F2} {errLeft,-15:F6} {errRight,-15:F6} {errMiddle,-15:F6} {errTrap,-15:F6}");
            }

            // Метод Монте-Карло
            int[] pointsArr = { 1000, 10000, 100000, 500000};
            Random rand = new Random();

            Console.WriteLine("\nМетод Монте-Карло:");
            Console.WriteLine($"{"Точки",-15} {"Погрешность",-15}");
            foreach (int pts in pointsArr)
            {
                double mc = MonteCarlo(a, b, pts, rand);
                double err = Math.Abs(exact - mc);
                Console.WriteLine($"{pts,-15} {err,-15:F6}");
            }
            
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}