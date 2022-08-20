namespace FPT_Attendance_System
{
    partial class EditAttendance
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
            this.txtLessonID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtReason = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.radioPresent = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtLessonID
            // 
            this.txtLessonID.Location = new System.Drawing.Point(143, 68);
            this.txtLessonID.Name = "txtLessonID";
            this.txtLessonID.ReadOnly = true;
            this.txtLessonID.Size = new System.Drawing.Size(266, 22);
            this.txtLessonID.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Absent";
            // 
            // rtxtReason
            // 
            this.rtxtReason.Location = new System.Drawing.Point(143, 200);
            this.rtxtReason.Name = "rtxtReason";
            this.rtxtReason.Size = new System.Drawing.Size(266, 96);
            this.rtxtReason.TabIndex = 34;
            this.rtxtReason.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(387, 30);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Confirm Edit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Reason of";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Present";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Student ID";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(37, 71);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(64, 16);
            this.labelUsername.TabIndex = 27;
            this.labelUsername.Text = "LessonID";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 42);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(143, 112);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(266, 22);
            this.txtStudentID.TabIndex = 37;
            // 
            // radioPresent
            // 
            this.radioPresent.AutoSize = true;
            this.radioPresent.Location = new System.Drawing.Point(143, 160);
            this.radioPresent.Name = "radioPresent";
            this.radioPresent.Size = new System.Drawing.Size(18, 17);
            this.radioPresent.TabIndex = 38;
            this.radioPresent.UseVisualStyleBackColor = true;
            // 
            // EditAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 365);
            this.Controls.Add(this.radioPresent);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtLessonID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtxtReason);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.btnBack);
            this.Name = "EditAttendance";
            this.Text = "Edit Attendance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditAttendance_FormClosing);
            this.Load += new System.EventHandler(this.EditAttendance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLessonID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtReason;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.CheckBox radioPresent;
    }
}