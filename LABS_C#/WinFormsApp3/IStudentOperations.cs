namespace WinFormsApp3
{
    public interface IStudentOperations
    {
        void AddStudent(Student student);
        void RemoveStudent(Student student);
        IEnumerable<Student> GetStudents();
    }
}
