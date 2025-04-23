namespace INST_LAB_3_4
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            textBoxName = new TextBox();
            labelAge = new Label();
            textBoxAge = new TextBox();
            labelGPA = new Label();
            textBoxGPA = new TextBox();
            buttonSave = new Button();
            EducationList = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(11, 19);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Имя:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(80, 15);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(201, 27);
            textBoxName.TabIndex = 1;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(11, 63);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(67, 20);
            labelAge.TabIndex = 2;
            labelAge.Text = "Возраст:";
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(80, 59);
            textBoxAge.Margin = new Padding(3, 4, 3, 4);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(201, 27);
            textBoxAge.TabIndex = 3;
            // 
            // labelGPA
            // 
            labelGPA.AutoSize = true;
            labelGPA.Location = new Point(11, 107);
            labelGPA.Name = "labelGPA";
            labelGPA.Size = new Size(110, 20);
            labelGPA.TabIndex = 4;
            labelGPA.Text = "Средний балл:";
            // 
            // textBoxGPA
            // 
            textBoxGPA.Location = new Point(120, 103);
            textBoxGPA.Margin = new Padding(3, 4, 3, 4);
            textBoxGPA.Name = "textBoxGPA";
            textBoxGPA.Size = new Size(159, 27);
            textBoxGPA.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Arial", 10F, FontStyle.Bold);
            buttonSave.Location = new Point(14, 231);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(265, 51);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // EducationList
            // 
            EducationList.FormattingEnabled = true;
            EducationList.Location = new Point(141, 138);
            EducationList.Name = "EducationList";
            EducationList.Size = new Size(155, 28);
            EducationList.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 141);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 8;
            label1.Text = "Форма обучения";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 295);
            Controls.Add(label1);
            Controls.Add(EducationList);
            Controls.Add(buttonSave);
            Controls.Add(textBoxGPA);
            Controls.Add(labelGPA);
            Controls.Add(textBoxAge);
            Controls.Add(labelAge);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentForm";
            Text = "Добавить студента";
            Load += StudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBoxAge;
        private TextBox textBoxName;
        private Label labelGPA;
        private Label labelAge;
        private Label labelName;
        private TextBox textBoxGPA;
        private Button buttonSave;

        #endregion

        private ComboBox EducationList;
        private Label label1;
    }
}