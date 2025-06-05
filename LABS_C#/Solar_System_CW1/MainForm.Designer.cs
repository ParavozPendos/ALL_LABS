namespace Solar_System_CW1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bDelete = new System.Windows.Forms.Button();
            this.bCollisions = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hsbApprox = new System.Windows.Forms.HScrollBar();
            this.hsbSpeed = new System.Windows.Forms.HScrollBar();
            this.labelApprox = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.labelMousePos = new System.Windows.Forms.Label();
            this.labelMousePos_field = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.labelGeneration = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.secTimer = new System.Windows.Forms.Timer(this.components);
            this.ContextOnBody = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSM_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextOnEmpty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSM_add = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.ContextOnBody.SuspendLayout();
            this.ContextOnEmpty.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bDelete);
            this.splitContainer1.Panel1.Controls.Add(this.bCollisions);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.bStop);
            this.splitContainer1.Panel1.Controls.Add(this.bStart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelMousePos);
            this.splitContainer1.Panel2.Controls.Add(this.labelMousePos_field);
            this.splitContainer1.Panel2.Controls.Add(this.labelSeconds);
            this.splitContainer1.Panel2.Controls.Add(this.labelGeneration);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(952, 478);
            this.splitContainer1.SplitterDistance = 108;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.Red;
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDelete.Location = new System.Drawing.Point(91, 59);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(85, 45);
            this.bDelete.TabIndex = 7;
            this.bDelete.Text = "Delete Save";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bCollisions
            // 
            this.bCollisions.BackColor = System.Drawing.Color.Green;
            this.bCollisions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCollisions.Location = new System.Drawing.Point(91, 9);
            this.bCollisions.Name = "bCollisions";
            this.bCollisions.Size = new System.Drawing.Size(85, 45);
            this.bCollisions.TabIndex = 6;
            this.bCollisions.Text = "Collisions";
            this.bCollisions.UseVisualStyleBackColor = false;
            this.bCollisions.Click += new System.EventHandler(this.bCollisions_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rtbDescription);
            this.panel2.Location = new System.Drawing.Point(638, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(307, 94);
            this.panel2.TabIndex = 5;
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.SystemColors.Control;
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbDescription.Location = new System.Drawing.Point(3, 3);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbDescription.ShowSelectionMargin = true;
            this.rtbDescription.Size = new System.Drawing.Size(299, 86);
            this.rtbDescription.TabIndex = 4;
            this.rtbDescription.Text = "";
            this.rtbDescription.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.hsbApprox);
            this.panel1.Controls.Add(this.hsbSpeed);
            this.panel1.Controls.Add(this.labelApprox);
            this.panel1.Controls.Add(this.labelSpeed);
            this.panel1.Location = new System.Drawing.Point(182, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 94);
            this.panel1.TabIndex = 4;
            // 
            // hsbApprox
            // 
            this.hsbApprox.LargeChange = 1;
            this.hsbApprox.Location = new System.Drawing.Point(115, 58);
            this.hsbApprox.Minimum = 1;
            this.hsbApprox.Name = "hsbApprox";
            this.hsbApprox.Size = new System.Drawing.Size(312, 17);
            this.hsbApprox.TabIndex = 6;
            this.hsbApprox.Value = 2;
            this.hsbApprox.ValueChanged += new System.EventHandler(this.hsbApprox_ValueChanged);
            // 
            // hsbSpeed
            // 
            this.hsbSpeed.LargeChange = 1;
            this.hsbSpeed.Location = new System.Drawing.Point(115, 14);
            this.hsbSpeed.Maximum = 1000;
            this.hsbSpeed.Name = "hsbSpeed";
            this.hsbSpeed.Size = new System.Drawing.Size(312, 17);
            this.hsbSpeed.TabIndex = 5;
            this.hsbSpeed.Value = 1;
            this.hsbSpeed.ValueChanged += new System.EventHandler(this.hsbSpeed_ValueChanged);
            // 
            // labelApprox
            // 
            this.labelApprox.AutoSize = true;
            this.labelApprox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelApprox.Location = new System.Drawing.Point(8, 58);
            this.labelApprox.Name = "labelApprox";
            this.labelApprox.Size = new System.Drawing.Size(79, 16);
            this.labelApprox.TabIndex = 4;
            this.labelApprox.Text = "Approx: 1x";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelSpeed.Location = new System.Drawing.Point(8, 14);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(69, 16);
            this.labelSpeed.TabIndex = 3;
            this.labelSpeed.Text = "Speed: 1";
            // 
            // bStop
            // 
            this.bStop.BackColor = System.Drawing.Color.Yellow;
            this.bStop.Enabled = false;
            this.bStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStop.Location = new System.Drawing.Point(3, 59);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(85, 45);
            this.bStop.TabIndex = 3;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = false;
            this.bStop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bStop_MouseClick);
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.Location = new System.Drawing.Point(3, 9);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(85, 45);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bStart_MouseClick);
            // 
            // labelMousePos
            // 
            this.labelMousePos.AutoSize = true;
            this.labelMousePos.BackColor = System.Drawing.SystemColors.ControlText;
            this.labelMousePos.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMousePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelMousePos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMousePos.Location = new System.Drawing.Point(0, 16);
            this.labelMousePos.Name = "labelMousePos";
            this.labelMousePos.Size = new System.Drawing.Size(121, 16);
            this.labelMousePos.TabIndex = 5;
            this.labelMousePos.Text = "Mouse Position: ";
            // 
            // labelMousePos_field
            // 
            this.labelMousePos_field.AutoSize = true;
            this.labelMousePos_field.BackColor = System.Drawing.SystemColors.ControlText;
            this.labelMousePos_field.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMousePos_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelMousePos_field.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMousePos_field.Location = new System.Drawing.Point(0, 0);
            this.labelMousePos_field.Name = "labelMousePos_field";
            this.labelMousePos_field.Size = new System.Drawing.Size(121, 16);
            this.labelMousePos_field.TabIndex = 4;
            this.labelMousePos_field.Text = "Mouse Position: ";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.BackColor = System.Drawing.SystemColors.ControlText;
            this.labelSeconds.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelSeconds.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSeconds.Location = new System.Drawing.Point(0, 330);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(72, 16);
            this.labelSeconds.TabIndex = 3;
            this.labelSeconds.Text = "Seconds:";
            // 
            // labelGeneration
            // 
            this.labelGeneration.AutoSize = true;
            this.labelGeneration.BackColor = System.Drawing.SystemColors.ControlText;
            this.labelGeneration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelGeneration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGeneration.Location = new System.Drawing.Point(0, 346);
            this.labelGeneration.Name = "labelGeneration";
            this.labelGeneration.Size = new System.Drawing.Size(87, 16);
            this.labelGeneration.TabIndex = 2;
            this.labelGeneration.Text = "Generation:";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(948, 362);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // secTimer
            // 
            this.secTimer.Interval = 1000;
            this.secTimer.Tick += new System.EventHandler(this.secTimer_Tick);
            // 
            // ContextOnBody
            // 
            this.ContextOnBody.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_delete,
            this.TSM_edit});
            this.ContextOnBody.Name = "ContextOnBody";
            this.ContextOnBody.Size = new System.Drawing.Size(155, 48);
            // 
            // TSM_delete
            // 
            this.TSM_delete.Name = "TSM_delete";
            this.TSM_delete.Size = new System.Drawing.Size(154, 22);
            this.TSM_delete.Text = "Удалить";
            this.TSM_delete.Click += new System.EventHandler(this.TSM_delete_Click);
            // 
            // TSM_edit
            // 
            this.TSM_edit.Name = "TSM_edit";
            this.TSM_edit.Size = new System.Drawing.Size(154, 22);
            this.TSM_edit.Text = "Редактировать";
            this.TSM_edit.Click += new System.EventHandler(this.TSM_edit_Click);
            // 
            // ContextOnEmpty
            // 
            this.ContextOnEmpty.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_add});
            this.ContextOnEmpty.Name = "ContextOnEmpty";
            this.ContextOnEmpty.Size = new System.Drawing.Size(125, 26);
            // 
            // TSM_add
            // 
            this.TSM_add.Name = "TSM_add";
            this.TSM_add.Size = new System.Drawing.Size(124, 22);
            this.TSM_add.Text = "добавить";
            this.TSM_add.Click += new System.EventHandler(this.TSM_add_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 478);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ContextOnBody.ResumeLayout(false);
            this.ContextOnEmpty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Label labelGeneration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar hsbApprox;
        private System.Windows.Forms.HScrollBar hsbSpeed;
        private System.Windows.Forms.Label labelApprox;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Timer secTimer;
        private System.Windows.Forms.ContextMenuStrip ContextOnBody;
        private System.Windows.Forms.ToolStripMenuItem TSM_delete;
        private System.Windows.Forms.ToolStripMenuItem TSM_edit;
        private System.Windows.Forms.ContextMenuStrip ContextOnEmpty;
        private System.Windows.Forms.ToolStripMenuItem TSM_add;
        private System.Windows.Forms.Label labelMousePos_field;
        private System.Windows.Forms.Label labelMousePos;
        private System.Windows.Forms.Button bCollisions;
        private System.Windows.Forms.Button bDelete;
    }
}

