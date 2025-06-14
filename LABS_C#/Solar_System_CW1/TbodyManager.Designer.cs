﻿namespace Solar_System_CW1
{
    partial class TbodyManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TbodyManager));
            this.bApply = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_Parent = new System.Windows.Forms.ComboBox();
            this.TB_Angle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.bSelectColor = new System.Windows.Forms.Button();
            this.TB_Size = new System.Windows.Forms.TextBox();
            this.TB_Speed = new System.Windows.Forms.TextBox();
            this.TB_Radius = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BodyColorDialog = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bApply
            // 
            this.bApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bApply.Location = new System.Drawing.Point(12, 321);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(341, 40);
            this.bApply.TabIndex = 0;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(8, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 16);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parent: ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CB_Parent);
            this.panel1.Controls.Add(this.TB_Angle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelPosition);
            this.panel1.Controls.Add(this.bSelectColor);
            this.panel1.Controls.Add(this.TB_Size);
            this.panel1.Controls.Add(this.TB_Speed);
            this.panel1.Controls.Add(this.TB_Radius);
            this.panel1.Controls.Add(this.TB_Name);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 303);
            this.panel1.TabIndex = 8;
            // 
            // CB_Parent
            // 
            this.CB_Parent.FormattingEnabled = true;
            this.CB_Parent.Location = new System.Drawing.Point(132, 34);
            this.CB_Parent.Name = "CB_Parent";
            this.CB_Parent.Size = new System.Drawing.Size(193, 21);
            this.CB_Parent.TabIndex = 23;
            // 
            // TB_Angle
            // 
            this.TB_Angle.Location = new System.Drawing.Point(132, 139);
            this.TB_Angle.Name = "TB_Angle";
            this.TB_Angle.Size = new System.Drawing.Size(193, 20);
            this.TB_Angle.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Angle ";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelPosition.Location = new System.Drawing.Point(8, 276);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(71, 16);
            this.labelPosition.TabIndex = 19;
            this.labelPosition.Text = "Position: ";
            // 
            // bSelectColor
            // 
            this.bSelectColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bSelectColor.Location = new System.Drawing.Point(132, 165);
            this.bSelectColor.Name = "bSelectColor";
            this.bSelectColor.Size = new System.Drawing.Size(195, 24);
            this.bSelectColor.TabIndex = 9;
            this.bSelectColor.Text = "Select color";
            this.bSelectColor.UseVisualStyleBackColor = true;
            this.bSelectColor.Click += new System.EventHandler(this.bSelectColor_Click);
            // 
            // TB_Size
            // 
            this.TB_Size.Location = new System.Drawing.Point(132, 113);
            this.TB_Size.Name = "TB_Size";
            this.TB_Size.Size = new System.Drawing.Size(193, 20);
            this.TB_Size.TabIndex = 18;
            // 
            // TB_Speed
            // 
            this.TB_Speed.Location = new System.Drawing.Point(132, 87);
            this.TB_Speed.Name = "TB_Speed";
            this.TB_Speed.Size = new System.Drawing.Size(193, 20);
            this.TB_Speed.TabIndex = 17;
            // 
            // TB_Radius
            // 
            this.TB_Radius.Location = new System.Drawing.Point(132, 61);
            this.TB_Radius.Name = "TB_Radius";
            this.TB_Radius.Size = new System.Drawing.Size(193, 20);
            this.TB_Radius.TabIndex = 16;
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(132, 9);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(193, 20);
            this.TB_Name.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(8, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(8, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Size: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(8, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Speed: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(8, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Radius: ";
            // 
            // TbodyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 373);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TbodyManager";
            this.Text = "Body Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TbodyManager_FormClosed);
            this.Load += new System.EventHandler(this.TbodyManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Size;
        private System.Windows.Forms.TextBox TB_Speed;
        private System.Windows.Forms.TextBox TB_Radius;
        private System.Windows.Forms.Button bSelectColor;
        private System.Windows.Forms.ColorDialog BodyColorDialog;
        private System.Windows.Forms.TextBox TB_Angle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.ComboBox CB_Parent;
    }
}