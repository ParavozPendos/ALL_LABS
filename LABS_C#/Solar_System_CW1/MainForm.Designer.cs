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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hsbApprox = new System.Windows.Forms.HScrollBar();
            this.hsbSpeed = new System.Windows.Forms.HScrollBar();
            this.labelApprox = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.labelGeneration = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.bStop);
            this.splitContainer1.Panel1.Controls.Add(this.bStart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelGeneration);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(1277, 582);
            this.splitContainer1.SplitterDistance = 108;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rtbDescription);
            this.panel2.Location = new System.Drawing.Point(851, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Size = new System.Drawing.Size(418, 115);
            this.panel2.TabIndex = 5;
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.SystemColors.Control;
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbDescription.Location = new System.Drawing.Point(4, 4);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ShowSelectionMargin = true;
            this.rtbDescription.Size = new System.Drawing.Size(408, 105);
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
            this.panel1.Location = new System.Drawing.Point(243, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 115);
            this.panel1.TabIndex = 4;
            // 
            // hsbApprox
            // 
            this.hsbApprox.LargeChange = 1;
            this.hsbApprox.Location = new System.Drawing.Point(153, 71);
            this.hsbApprox.Minimum = 1;
            this.hsbApprox.Name = "hsbApprox";
            this.hsbApprox.Size = new System.Drawing.Size(416, 17);
            this.hsbApprox.TabIndex = 6;
            this.hsbApprox.Value = 1;
            this.hsbApprox.ValueChanged += new System.EventHandler(this.hsbApprox_ValueChanged);
            // 
            // hsbSpeed
            // 
            this.hsbSpeed.LargeChange = 1;
            this.hsbSpeed.Location = new System.Drawing.Point(153, 17);
            this.hsbSpeed.Maximum = 1000;
            this.hsbSpeed.Name = "hsbSpeed";
            this.hsbSpeed.Size = new System.Drawing.Size(416, 17);
            this.hsbSpeed.TabIndex = 5;
            this.hsbSpeed.Value = 1;
            this.hsbSpeed.ValueChanged += new System.EventHandler(this.hsbSpeed_ValueChanged);
            // 
            // labelApprox
            // 
            this.labelApprox.AutoSize = true;
            this.labelApprox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelApprox.Location = new System.Drawing.Point(11, 71);
            this.labelApprox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApprox.Name = "labelApprox";
            this.labelApprox.Size = new System.Drawing.Size(98, 20);
            this.labelApprox.TabIndex = 4;
            this.labelApprox.Text = "Approx: 1x";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelSpeed.Location = new System.Drawing.Point(11, 17);
            this.labelSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(83, 20);
            this.labelSpeed.TabIndex = 3;
            this.labelSpeed.Text = "Speed: 1";
            // 
            // bStop
            // 
            this.bStop.Enabled = false;
            this.bStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStop.Location = new System.Drawing.Point(121, 12);
            this.bStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(113, 116);
            this.bStop.TabIndex = 3;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = false;
            this.bStop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bStop_MouseClick);
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.Location = new System.Drawing.Point(13, 12);
            this.bStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(100, 116);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bStart_MouseClick);
            // 
            // labelGeneration
            // 
            this.labelGeneration.AutoSize = true;
            this.labelGeneration.BackColor = System.Drawing.SystemColors.ControlText;
            this.labelGeneration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelGeneration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGeneration.Location = new System.Drawing.Point(0, 445);
            this.labelGeneration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGeneration.Name = "labelGeneration";
            this.labelGeneration.Size = new System.Drawing.Size(123, 20);
            this.labelGeneration.TabIndex = 2;
            this.labelGeneration.Text = "Generation: 0";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1273, 465);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 582);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}

