namespace INST_LAB_3_4
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
            listBoxStudents.ItemHeight = 15;
            listBoxStudents.Location = new Point(10, 11);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(228, 184);
            listBoxStudents.TabIndex = 0;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAddStudent.Font = new Font("Arial", 10F, FontStyle.Bold);
            buttonAddStudent.Location = new Point(10, 206);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(228, 38);
            buttonAddStudent.TabIndex = 1;
            buttonAddStudent.Text = "Добавить студента";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonEditStudent
            // 
            buttonEditStudent.Location = new Point(10, 250);
            buttonEditStudent.Name = "buttonEditStudent";
            buttonEditStudent.Size = new Size(115, 30);
            buttonEditStudent.TabIndex = 0;
            buttonEditStudent.Text = "Редактировать";
            buttonEditStudent.Click += buttonEditStudent_Click;
            // 
            // buttonDeleteStudent
            // 
            buttonDeleteStudent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonDeleteStudent.Location = new Point(131, 250);
            buttonDeleteStudent.Name = "buttonDeleteStudent";
            buttonDeleteStudent.Size = new Size(107, 30);
            buttonDeleteStudent.TabIndex = 0;
            buttonDeleteStudent.Text = "Удалить";
            buttonDeleteStudent.Click += buttonDeleteStudent_Click;
            // 
            // textBoxFilter
            // 
            textBoxFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFilter.Location = new Point(11, 286);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(226, 23);
            textBoxFilter.TabIndex = 0;
            // 
            // buttonFilter
            // 
            buttonFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonFilter.Location = new Point(10, 315);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(228, 30);
            buttonFilter.TabIndex = 0;
            buttonFilter.Text = "Фильтр";
            buttonFilter.Click += buttonFilter_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 354);
            Controls.Add(buttonAddStudent);
            Controls.Add(listBoxStudents);
            Controls.Add(buttonEditStudent);
            Controls.Add(buttonDeleteStudent);
            Controls.Add(textBoxFilter);
            Controls.Add(buttonFilter);
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
