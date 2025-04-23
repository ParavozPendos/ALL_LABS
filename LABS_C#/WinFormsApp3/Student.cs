using System.Drawing.Text;

namespace WinFormsApp3
{
    public class Student
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public double GPA { get; private set; }
        public StudyForm EducationForm { get; private set; }
        public Student(string name, int age, double gpa, StudyForm educationform)
        {
            if (age < 16)
                throw new ArgumentException("Возраст должен быть c 16 лет.");

            if (gpa < 0 || gpa > 5)
                throw new ArgumentException("Средний балл должен быть от 0 до 5.");

            Name = name;
            Age = age;
            GPA = gpa;
            EducationForm = educationform;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Студент: {Name}, Возраст: {Age}, Средний балл: {GPA}, Форма обучения {EducationForm}");
        }

        public override string ToString()
        {
            return $"{Name} ({Age} лет) - Средний балл: {GPA}, Форма обучения {StudyFormSource.GetDifinition(EducationForm)}";
        }
    }
}
