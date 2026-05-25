using System;
using System.Collections.Generic;

namespace OneDimensionalSearch
{
    class IterationData
    {
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double F1 { get; set; }
        public double F2 { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public double Width { get; set; }
    }

    class Program
    {
        static double F(double x) => (x - 1) * (x - 1);

        // Метод дихотомии
        static (double result, List<IterationData> iterations, int funcCount) DichotomyMethod(double a, double b, double eps)
        {
            double delta = eps * 0.1;
            var iterations = new List<IterationData>();
            int funcCount = 0;

            while (true)
            {
                double width = b - a;
                if (width <= eps) break;

                double x1 = (a + b) / 2 - delta;
                double x2 = (a + b) / 2 + delta;
                double f1 = F(x1);
                double f2 = F(x2);
                funcCount += 2;

                iterations.Add(new IterationData
                {
                    X1 = x1,
                    X2 = x2,
                    F1 = f1,
                    F2 = f2,
                    A = a,
                    B = b,
                    Width = width
                });

                if (f1 < f2)
                    b = x2;
                else
                    a = x1;
            }

            double result = (a + b) / 2;
            return (result, iterations, funcCount);
        }

        // Метод золотого сечения
        static (double result, List<IterationData> iterations, int funcCount) GoldenSectionMethod(double a, double b, double eps)
        {
            double phi = (1 + Math.Sqrt(5)) / 2;
            double tau = 2 - phi;  // ~0.381966

            double x1 = a + tau * (b - a);
            double x2 = b - tau * (b - a);
            double f1 = F(x1);
            double f2 = F(x2);
            int funcCount = 2;

            var iterations = new List<IterationData>();

            while (true)
            {
                double width = b - a;
                if (width <= eps) break;

                iterations.Add(new IterationData
                {
                    X1 = x1,
                    X2 = x2,
                    F1 = f1,
                    F2 = f2,
                    A = a,
                    B = b,
                    Width = width
                });

                if (f1 < f2)
                {
                    b = x2;
                    x2 = x1;
                    f2 = f1;
                    x1 = a + tau * (b - a);
                    f1 = F(x1);
                }
                else
                {
                    a = x1;
                    x1 = x2;
                    f1 = f2;
                    x2 = b - tau * (b - a);
                    f2 = F(x2);
                }
                funcCount++;
            }

            double result = (a + b) / 2;
            return (result, iterations, funcCount);
        }

        // Печать таблицы итераций
        static void PrintTable(string title, List<IterationData> iterations)
        {
            Console.WriteLine($"\n{title}");
            string header = string.Format("{0,-4} | {1,-10} | {2,-10} | {3,-10} | {4,-10} | {5,-10} | {6,-10} | {7,-10}",
                "i", "x1", "x2", "f(x1)", "f(x2)", "a_i", "b_i", "b-a");
            Console.WriteLine(new string('-', header.Length));
            Console.WriteLine(header);
            Console.WriteLine(new string('-', header.Length));

            for (int i = 0; i < iterations.Count; i++)
            {
                var it = iterations[i];
                Console.WriteLine(string.Format("{0,-4} | {1,-10:F6} | {2,-10:F6} | {3,-10:F6} | {4,-10:F6} | {5,-10:F6} | {6,-10:F6} | {7,-10:F6}",
                    i + 1, it.X1, it.X2, it.F1, it.F2, it.A, it.B, it.Width));
            }
        }

        static void Main(string[] args)
        {
            double A = -2, B = 20;
            double epsTable = 0.001;

            // 1. Таблицы для eps = 0.001
            var (_, iterDich, _) = DichotomyMethod(A, B, epsTable);
            var (_, iterGold, _) = GoldenSectionMethod(A, B, epsTable);

            PrintTable("ТАБЛИЦА ИТЕРАЦИЙ: ДИХОТОМИЯ (eps=0.001)", iterDich);
            PrintTable("ТАБЛИЦА ИТЕРАЦИЙ: ЗОЛОТОЕ СЕЧЕНИЕ (eps=0.001)", iterGold);

            // 2. Дополнительные требуемые epsilon: 0.01 и 0.25
            Console.WriteLine("\n" + new string('=', 70));
            Console.WriteLine("ПРОВЕРКА СТОЛБЦА b-a ПО ТРЕБОВАНИЮ ПРЕПОДАВАТЕЛЯ");
            Console.WriteLine(new string('=', 70));

            foreach (double eps in new double[] { 0.01 })
            {
                Console.WriteLine($"\nЭпсилон = {eps}");
                var (_, iterD, _) = DichotomyMethod(A, B, eps);
                var (_, iterG, _) = GoldenSectionMethod(A, B, eps);

                Console.WriteLine("\nДихотомия (последняя итерация):");
                var lastD = iterD[iterD.Count - 1];
                Console.WriteLine($"  b-a = {lastD.Width:F6}  |  Условие b-a <= eps: {lastD.Width <= eps}");

                Console.WriteLine("\nЗолотое сечение (последняя итерация):");
                var lastG = iterG[iterG.Count - 1];
                Console.WriteLine($"  b-a = {lastG.Width:F6}  |  Условие b-a <= eps: {lastG.Width <= eps}");
            }

            // 3. Сравнение по точности от 1e-2 до 1e-8
            Console.WriteLine("\n" + new string('=', 70));
            Console.WriteLine("СРАВНЕНИЕ ПО ТОЧНОСТИ (количество вычислений f)");
            Console.WriteLine(new string('=', 70));
            Console.WriteLine(string.Format("{0,-12} | {1,-12} | {2,-12}", "eps", "Дихотомия", "Зол. сечение"));
            Console.WriteLine(new string('-', 45));

            for (int p = 2; p <= 8; p++)
            {
                double e = Math.Pow(10, -p);
                var (_, _, countD) = DichotomyMethod(A, B, e);
                var (_, _, countG) = GoldenSectionMethod(A, B, e);
                Console.WriteLine(string.Format("{0,-12:F8} | {1,-12} | {2,-12}", e, countD, countG));
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}