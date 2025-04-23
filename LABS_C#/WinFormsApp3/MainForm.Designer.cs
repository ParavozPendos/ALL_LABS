namespace WinFormsApp3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxStudents = new ListBox();
            buttonAddStudent = new Button();
            buttonEditStudent = new Button();
            buttonDeleteStudent = new Button();
            textBoxFilter = new TextBox();
            buttonFilter = new Button();
            SuspendLayout();
            // 
            // listBoxStudents
            // 
            listBoxStudents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.Location = new Point(11, 15);
            listBoxStudents.Margin = new Padding(3, 4, 3, 4);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(260, 244);
            listBoxStudents.TabIndex = 0;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Font = new Font("Arial", 10F, FontStyle.Bold);
            buttonAddStudent.Location = new Point(11, 275);
            buttonAddStudent.Margin = new Padding(3, 4, 3, 4);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(261, 51);
            buttonAddStudent.TabIndex = 1;
            buttonAddStudent.Text = "Добавить студента";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonEditStudent
            // 
            buttonEditStudent.Location = new Point(14, 333);
            buttonEditStudent.Margin = new Padding(3, 4, 3, 4);
            buttonEditStudent.Name = "buttonEditStudent";
            buttonEditStudent.Size = new Size(129, 40);
            buttonEditStudent.TabIndex = 0;
            buttonEditStudent.Text = "Редактировать";
            buttonEditStudent.Click += buttonEditStudent_Click;
            // 
            // buttonDeleteStudent
            // 
            buttonDeleteStudent.Location = new Point(150, 333);
            buttonDeleteStudent.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteStudent.Name = "buttonDeleteStudent";
            buttonDeleteStudent.Size = new Size(122, 40);
            buttonDeleteStudent.TabIndex = 0;
            buttonDeleteStudent.Text = "Удалить";
            buttonDeleteStudent.Click += buttonDeleteStudent_Click;
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(14, 387);
            textBoxFilter.Margin = new Padding(3, 4, 3, 4);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(258, 27);
            textBoxFilter.TabIndex = 0;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(150, 425);
            buttonFilter.Margin = new Padding(3, 4, 3, 4);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(122, 35);
            buttonFilter.TabIndex = 0;
            buttonFilter.Text = "Фильтр";
            buttonFilter.Click += buttonFilter_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 472);
            Controls.Add(buttonAddStudent);
            Controls.Add(listBoxStudents);
            Controls.Add(buttonEditStudent);
            Controls.Add(buttonDeleteStudent);
            Controls.Add(textBoxFilter);
            Controls.Add(buttonFilter);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Студенты";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private ListBox listBoxStudents;
        private Button buttonAddStudent;
        private Button buttonEditStudent;
        private Button buttonDeleteStudent;
        private TextBox textBoxFilter;
        private Button buttonFilter;
        #endregion
    }
}
