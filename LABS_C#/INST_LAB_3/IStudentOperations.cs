namespace INST_LAB_3_4
{
    public interface IStudentOperations
    {
        void AddStudent(Student student);
        void RemoveStudent(Student student);
        IEnumerable<Student> GetStudents();
    }
}
