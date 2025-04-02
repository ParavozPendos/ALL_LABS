using System;
using System.IO;
using System.Linq;

namespace INST_LAB_1
{
    enum Education
    {
        Specialist,
        Bachelor,
        SecondEducation,
    }

    class Exam
    {
        public Exam()
        {
            this.Mark = 0;
            this.Subject = "None";
            this.Time = DateTime.MinValue;
        }

        public Exam(int Mark, string Subject, DateTime Time)
        {
            this.Mark = Mark;
            this.Subject = Subject;
            this.Time = Time;
        }

        public int Mark { get; set; }
        public string Subject { get; set; }
        public DateTime Time { get; set; }

        public override string ToString()
        {
            return $"Предмет: {Subject} | Время: {Time:yyyy-MM-dd} | Оценка: {Mark}";
        }
    }

    class Student
    {
        public Student()
        {
            Person = "Иванов Иван Иванович";
            Education = Education.Bachelor;
            Group = 0;
            exams = Array.Empty<Exam>();
        }

        public Student(string Person, Education Education, int Group)
        {
            this.Person = Person;
            this.Education = Education;
            this.Group = Group;
            this.exams = Array.Empty<Exam>();
        }

        public string Person { get; private set; }
        public Education Education { get; set; }
        public int Group { get; set; }

        private Exam[] exams;
        public Exam[] Exams
        {
            get { return exams; }
            set { exams = value ?? Array.Empty<Exam>(); }
        }
        private double average;
        public double Average
        {
            get
            {
                if (exams == null || exams.Length == 0)
                    return 0;

                foreach (var item in exams)
                {
                    average += item.Mark;
                }
                average /= exams.Length;

                return average;
            }
        }

        public bool this[Education education]
        {
            get => Education == education;
        }

        public void AddExams(params Exam[] newExams)
        {
            Array.Resize(ref exams, exams.Length + newExams.Length);
            Array.Copy(newExams, 0, exams, exams.Length - newExams.Length, newExams.Length);
        }

        public override string ToString()
        {
            string ExamList = "";
            foreach (var item in Exams)
            {
                ExamList += item.ToString() + "\n";
            }
            return $"Студент: {Person} | Образование: {Education} | Группа: {Group}\nЭкзамены:\n{ExamList}";
        }

        public string ToShortString()
        {
            return $"Студент: {Person} | Образование: {Education} | Группа: {Group} | СрБалл: {Average}";
        }
    }

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
            DateTime start_1 = DateTime.Now;
            for (int i = 0; i < ARR_1.Length; i++)
            {
                ARR_1[i] = exam;
            }
            Console.WriteLine((DateTime.Now - start_1).TotalMilliseconds + " ms");

            Exam[,] ARR_2 = new Exam[SIZE, SIZE];
            DateTime start_2 = DateTime.Now;
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    ARR_2[i, j] = exam;
                }
            }
            Console.WriteLine((DateTime.Now - start_2).TotalMilliseconds + " ms");

            var ARR_3 = new Exam[SIZE][];
            for (int i = 0; i < SIZE; i++)
            {
                ARR_3[i] = new Exam[SIZE];
            }
            DateTime start_3 = DateTime.Now;
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    ARR_3[i][j] = exam;
                }
            }
            Console.WriteLine((DateTime.Now - start_3).TotalMilliseconds + " ms");

            Console.ReadKey(true);
        }
    }
}