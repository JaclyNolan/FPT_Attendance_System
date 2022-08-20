namespace FPT_Attendance_System
{
    partial class EditLesson
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
            this.dtpLessonDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboClassID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTeacherID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLessonID = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpLessonDate
            // 
            this.dtpLessonDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLessonDate.Location = new System.Drawing.Point(136, 115);
            this.dtpLessonDate.Name = "dtpLessonDate";
            this.dtpLessonDate.Size = new System.Drawing.Size(266, 22);
            this.dtpLessonDate.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(50, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(387, 30);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Confirm Edit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboClassID
            // 
            this.comboClassID.FormattingEnabled = true;
            this.comboClassID.Location = new System.Drawing.Point(136, 205);
            this.comboClassID.Name = "comboClassID";
            this.comboClassID.Size = new System.Drawing.Size(266, 24);
            this.comboClassID.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Class ID";
            // 
            // comboTeacherID
            // 
            this.comboTeacherID.FormattingEnabled = true;
            this.comboTeacherID.Location = new System.Drawing.Point(136, 160);
            this.comboTeacherID.Name = "comboTeacherID";
            this.comboTeacherID.Size = new System.Drawing.Size(266, 24);
            this.comboTeacherID.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Teacher ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date";
            // 
            // txtLessonID
            // 
            this.txtLessonID.Location = new System.Drawing.Point(136, 73);
            this.txtLessonID.Name = "txtLessonID";
            this.txtLessonID.ReadOnly = true;
            this.txtLessonID.Size = new System.Drawing.Size(266, 22);
            this.txtLessonID.TabIndex = 15;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(47, 76);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(67, 16);
            this.labelUsername.TabIndex = 14;
            this.labelUsername.Text = "Lesson ID";
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
            // EditLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 308);
            this.Controls.Add(this.dtpLessonDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboClassID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboTeacherID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLessonID);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.btnBack);
            this.Name = "EditLesson";
            this.Text = "Edit Lesson";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditLesson_FormClosing);
            this.Load += new System.EventHandler(this.EditLesson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpLessonDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboClassID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTeacherID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLessonID;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button btnBack;
    }
}