namespace WinFormsApp3
{
    public partial class MainForm : Form
    {
        private StudentManager studentManager = new StudentManager();
        private readonly string txtPath = "students.txt";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            studentManager.LoadFromTxt(txtPath);
            UpdateStudentList();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            studentManager.SaveToTxt(txtPath);
        }

        private void UpdateStudentList()
        {
            listBoxStudents.Items.Clear();
            foreach (var student in studentManager.GetStudents())
            {
                listBoxStudents.Items.Add(student);
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm(studentManager);
            form.StudentAdded += UpdateStudentList;  // Подписываемся на событие
            form.ShowDialog();
        }

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedItem is Student selected)
            {
                StudentForm form = new StudentForm(studentManager, selected);
                form.StudentAdded += UpdateStudentList;
                form.ShowDialog();
            }
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedItem is Student selected)
            {
                studentManager.RemoveStudent(selected);
                UpdateStudentList();
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string filter = textBoxFilter.Text.ToLower();
            listBoxStudents.Items.Clear();

            foreach (var student in studentManager.GetStudents())
            {
                if (student.Name.ToLower().Contains(filter))
                    listBoxStudents.Items.Add(student);
            }
        }
    }
}
