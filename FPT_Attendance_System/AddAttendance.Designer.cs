namespace FPT_Attendance_System
{
    partial class AddAttendance
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboStudentID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtReason = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLessonID = new System.Windows.Forms.TextBox();
            this.radioPresent = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 323);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(387, 30);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add a new attandance status";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Reason of";
            // 
            // comboStudentID
            // 
            this.comboStudentID.FormattingEnabled = true;
            this.comboStudentID.Location = new System.Drawing.Point(142, 111);
            this.comboStudentID.Name = "comboStudentID";
            this.comboStudentID.Size = new System.Drawing.Size(266, 24);
            this.comboStudentID.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Present";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(36, 70);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(64, 16);
            this.labelUsername.TabIndex = 14;
            this.labelUsername.Text = "LessonID";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(-1, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 42);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Student ID";
            // 
            // rtxtReason
            // 
            this.rtxtReason.Location = new System.Drawing.Point(142, 199);
            this.rtxtReason.Name = "rtxtReason";
            this.rtxtReason.Size = new System.Drawing.Size(266, 96);
            this.rtxtReason.TabIndex = 23;
            this.rtxtReason.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Absent";
            // 
            // txtLessonID
            // 
            this.txtLessonID.Location = new System.Drawing.Point(142, 67);
            this.txtLessonID.Name = "txtLessonID";
            this.txtLessonID.ReadOnly = true;
            this.txtLessonID.Size = new System.Drawing.Size(266, 22);
            this.txtLessonID.TabIndex = 25;
            // 
            // radioPresent
            // 
            this.radioPresent.AutoSize = true;
            this.radioPresent.Location = new System.Drawing.Point(142, 159);
            this.radioPresent.Name = "radioPresent";
            this.radioPresent.Size = new System.Drawing.Size(18, 17);
            this.radioPresent.TabIndex = 26;
            this.radioPresent.UseVisualStyleBackColor = true;
            // 
            // AddAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 365);
            this.Controls.Add(this.radioPresent);
            this.Controls.Add(this.txtLessonID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtxtReason);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboStudentID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.btnBack);
            this.Name = "AddAttendance";
            this.Text = "Add Attendance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddAttendance_FormClosing);
            this.Load += new System.EventHandler(this.AddAttendance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboStudentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtReason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLessonID;
        private System.Windows.Forms.CheckBox radioPresent;
    }
}