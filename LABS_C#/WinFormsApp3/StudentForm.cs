namespace WinFormsApp3
{
    public partial class StudentForm : Form
    {
        private StudentManager studentManager;
        private Student editingStudent = null;

        public event Action StudentAdded; // Событие для обновления списка

        public StudentForm(StudentManager manager, Student toEdit = null)
        {
            InitializeComponent();
            studentManager = manager;
            editingStudent = toEdit;

            if (toEdit != null)
            {
                textBoxName.Text = toEdit.Name;
                textBoxAge.Text = toEdit.Age.ToString();
                textBoxGPA.Text = toEdit.GPA.ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
                int age = int.Parse(textBoxAge.Text);
                double gpa = double.Parse(textBoxGPA.Text);
                StudyForm eduform = (StudyForm)EducationList.SelectedValue;
                Student newStudent = new Student(name, age, gpa, eduform);

                if (editingStudent != null)
                    studentManager.RemoveStudent(editingStudent);

                studentManager.AddStudent(newStudent);
                StudentAdded?.Invoke();  // Вызываем событие
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            
            EducationList.DataSource = StudyFormSource.SetupStudyFormComboBox();
            EducationList.ValueMember = "Value";
            EducationList.DisplayMember = "Display";
            EducationList.SelectedIndex = 0;
        }
    }
}
