namespace WinFormsApp3
{
    public class GraduateStudent : Student
    {
        public string ThesisTopic { get; set; }

        public GraduateStudent(string name, int age, double gpa, string thesisTopic, StudyForm educationform) : base(name, age, gpa, educationform)
        {
            ThesisTopic = thesisTopic;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Тема диплома: {ThesisTopic}");
        }

        public override string ToString()
        {
            return base.ToString() + $", Тема диплома: {ThesisTopic}";
        }
    }
}
