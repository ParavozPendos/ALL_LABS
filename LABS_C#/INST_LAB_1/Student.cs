using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INST_LAB_1
{
    enum Education
    {
        Specialist,
        Bachelor,
        SecondEducation,
    }

    class Student
    {
        public Student()
        {
            Person = "Иванов Иван Иванович";
            Education = Education.Bachelor;
            Group = 0;
        }

        public Student(string Person, Education Education, int Group)
        {
            this.Person = Person;
            this.Education = Education;
            this.Group = Group;
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
}
