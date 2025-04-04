using System;
using System.IO;
using System.Linq;

namespace INST_LAB_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student(
                "Абоба",
                Education.Bachelor,
                101
            );

            Console.WriteLine("Инфа о студенте (короткая):");
            Console.WriteLine(student.ToShortString());
            Console.WriteLine();

            Console.WriteLine("Проверка уровня образования:");
            Console.WriteLine($"Specialist: {student[Education.Specialist]}");
            Console.WriteLine($"Bachelor: {student[Education.Bachelor]}");
            Console.WriteLine($"SecondEducation: {student[Education.SecondEducation]}");
            Console.WriteLine();

            student.Education = Education.Specialist;
            student.Group = 102;
            student.Exams = new Exam[]
            {
                new Exam(4, "математика", new DateTime(2025, 1, 15)),
                new Exam(5, "обществознание", new DateTime(2025, 1, 20))
            };

            Console.WriteLine("Инфа о студенте (полная):");
            Console.WriteLine(student.ToString());
            Console.WriteLine();

            student.AddExams(
                new Exam(3, "Химия", new DateTime(2025, 2, 1)),
                new Exam(3, "Физика", new DateTime(2025, 2, 5))
            );

            Console.WriteLine("обновление полной инфы:");
            Console.WriteLine(student.ToString());
            Console.WriteLine();

            Console.WriteLine("Инфа о студенте (короткая):");
            Console.WriteLine(student.ToShortString());
            Console.WriteLine();

            const int SIZE = 10000;
            Exam exam = new Exam(0, "TEST", DateTime.Now);

            Exam[] ARR_1 = new Exam[SIZE*SIZE];
            float start_1 = Environment.TickCount;
            for (int i = 0; i < ARR_1.Length; i++)
            {
                ARR_1[i] = exam;
            }
            Console.WriteLine((Environment.TickCount - start_1) + " tick");

            Exam[,] ARR_2 = new Exam[SIZE, SIZE];
            int start_2 = Environment.TickCount;
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    ARR_2[i, j] = exam;
                }
            }
            Console.WriteLine((Environment.TickCount - start_2) + " tick");

            var ARR_3 = new Exam[SIZE][];
            for (int i = 0; i < SIZE; i++)
            {
                ARR_3[i] = new Exam[SIZE];
            }
            int start_3 = Environment.TickCount;
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    ARR_3[i][j] = exam;
                }
            }
            Console.WriteLine((Environment.TickCount - start_3) + " tick");

            Console.ReadKey(true);
        }
    }
}