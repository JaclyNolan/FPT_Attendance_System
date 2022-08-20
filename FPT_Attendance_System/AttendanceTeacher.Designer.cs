namespace FPT_Attendance_System
{
    partial class AttendanceTeacher
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
            System.Windows.Forms.ListViewItem listViewItem53 = new System.Windows.Forms.ListViewItem(new string[] {
            "what",
            "noshit",
            "hmmmmmmmm",
            "ok I get"}, -1);
            System.Windows.Forms.ListViewItem listViewItem54 = new System.Windows.Forms.ListViewItem("shit");
            System.Windows.Forms.ListViewItem listViewItem55 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem56 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem57 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem58 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem59 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem60 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem61 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem62 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem63 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem64 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem65 = new System.Windows.Forms.ListViewItem("dog");
            this.listLesson = new System.Windows.Forms.ListView();
            this.clnStudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnStudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnPresent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHome = new System.Windows.Forms.Button();
            this.txtEntryCount = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listLesson
            // 
            this.listLesson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnStudentID,
            this.clnStudentName,
            this.clnPresent});
            this.listLesson.FullRowSelect = true;
            this.listLesson.HideSelection = false;
            this.listLesson.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem53,
            listViewItem54,
            listViewItem55,
            listViewItem56,
            listViewItem57,
            listViewItem58,
            listViewItem59,
            listViewItem60,
            listViewItem61,
            listViewItem62,
            listViewItem63,
            listViewItem64,
            listViewItem65});
            this.listLesson.Location = new System.Drawing.Point(30, 108);
            this.listLesson.Name = "listLesson";
            this.listLesson.Size = new System.Drawing.Size(581, 293);
            this.listLesson.TabIndex = 35;
            this.listLesson.UseCompatibleStateImageBehavior = false;
            this.listLesson.View = System.Windows.Forms.View.Details;
            // 
            // clnStudentID
            // 
            this.clnStudentID.Text = "Student ID";
            this.clnStudentID.Width = 100;
            // 
            // clnStudentName
            // 
            this.clnStudentName.Text = "Student Name";
            this.clnStudentName.Width = 200;
            // 
            // clnPresent
            // 
            this.clnPresent.Text = "Present";
            this.clnPresent.Width = 70;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(-1, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(126, 42);
            this.btnHome.TabIndex = 34;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtEntryCount
            // 
            this.txtEntryCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntryCount.DetectUrls = false;
            this.txtEntryCount.Location = new System.Drawing.Point(498, 81);
            this.txtEntryCount.Name = "txtEntryCount";
            this.txtEntryCount.ReadOnly = true;
            this.txtEntryCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEntryCount.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtEntryCount.Size = new System.Drawing.Size(114, 29);
            this.txtEntryCount.TabIndex = 36;
            this.txtEntryCount.Text = "Entry: 12 of 12";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(289, 55);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(44, 16);
            this.labelClass.TabIndex = 38;
            this.labelClass.Text = "Class:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(33, 55);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(39, 16);
            this.labelDate.TabIndex = 37;
            this.labelDate.Text = "Date:";
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(325, 458);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(287, 33);
            this.btnNo.TabIndex = 41;
            this.btnNo.Text = "Check No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(30, 458);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(287, 33);
            this.btnYes.TabIndex = 40;
            this.btnYes.Text = "Check Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(30, 419);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(582, 33);
            this.btnEdit.TabIndex = 39;
            this.btnEdit.Text = "Edit Attendance";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // AttendanceTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 509);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.listLesson);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtEntryCount);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelDate);
            this.Name = "AttendanceTeacher";
            this.Text = "Attendance Management";
            this.Activated += new System.EventHandler(this.AttendanceTeacher_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AttendanceTeacher_FormClosing);
            this.Load += new System.EventHandler(this.AttendanceTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listLesson;
        private System.Windows.Forms.ColumnHeader clnStudentID;
        private System.Windows.Forms.ColumnHeader clnStudentName;
        private System.Windows.Forms.ColumnHeader clnPresent;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.RichTextBox txtEntryCount;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnEdit;
    }
}