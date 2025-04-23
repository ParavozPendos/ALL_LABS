namespace WinFormsApp3
{
    public class StudentManager : IStudentOperations
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public IEnumerable<Student> GetStudents()
        {
            return students;
        }

        public void SaveToTxt(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var student in students)
                {
                    writer.WriteLine($"Student|{student.Name}|{student.Age}|{student.GPA}|{student.EducationForm}");
                }
            }
        }

        public void LoadFromTxt(string path)
        {
            if (!File.Exists(path))
                return;

            students.Clear();

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                string name = parts[1];
                int age = int.Parse(parts[2]);
                double gpa = double.Parse(parts[3]);
                StudyForm eduform = StudyForm.Parse<StudyForm>(parts[4]);
                students.Add(new Student(name, age, gpa, eduform));
            }
        }
    }
}
