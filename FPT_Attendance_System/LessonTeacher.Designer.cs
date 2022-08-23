namespace FPT_Attendance_System
{
    partial class LessonTeacher
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "what",
            "noshit",
            "hmmmmmmmm",
            "ok I get"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("shit");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("dog");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("dog");
            this.listLesson = new System.Windows.Forms.ListView();
            this.clnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnSubjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtEntryCount = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listLesson
            // 
            this.listLesson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnID,
            this.clnDate,
            this.clnClass,
            this.clnSubjectName});
            this.listLesson.FullRowSelect = true;
            this.listLesson.HideSelection = false;
            this.listLesson.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13});
            this.listLesson.Location = new System.Drawing.Point(31, 71);
            this.listLesson.Name = "listLesson";
            this.listLesson.Size = new System.Drawing.Size(581, 293);
            this.listLesson.TabIndex = 29;
            this.listLesson.UseCompatibleStateImageBehavior = false;
            this.listLesson.View = System.Windows.Forms.View.Details;
            // 
            // clnID
            // 
            this.clnID.Text = "ID";
            // 
            // clnDate
            // 
            this.clnDate.Text = "Date";
            this.clnDate.Width = 100;
            // 
            // clnClass
            // 
            this.clnClass.Text = "Class";
            this.clnClass.Width = 100;
            // 
            // clnSubjectName
            // 
            this.clnSubjectName.Text = "Subject Name";
            this.clnSubjectName.Width = 250;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(0, -1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(126, 42);
            this.btnHome.TabIndex = 28;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(31, 387);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(582, 33);
            this.btnCheck.TabIndex = 31;
            this.btnCheck.Text = "Check attendance status of selected class";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtEntryCount
            // 
            this.txtEntryCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntryCount.DetectUrls = false;
            this.txtEntryCount.Location = new System.Drawing.Point(499, 44);
            this.txtEntryCount.Name = "txtEntryCount";
            this.txtEntryCount.ReadOnly = true;
            this.txtEntryCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEntryCount.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtEntryCount.Size = new System.Drawing.Size(114, 29);
            this.txtEntryCount.TabIndex = 30;
            this.txtEntryCount.Text = "Entry: 12 of 12";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(132, 12);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(61, 16);
            this.labelUsername.TabIndex = 32;
            this.labelUsername.Text = "Teacher:";
            // 
            // LessonTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 443);
            this.Controls.Add(this.listLesson);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtEntryCount);
            this.Controls.Add(this.labelUsername);
            this.Name = "LessonTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lesson Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LessonTeacher_FormClosing);
            this.Load += new System.EventHandler(this.LessonTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listLesson;
        private System.Windows.Forms.ColumnHeader clnClass;
        private System.Windows.Forms.ColumnHeader clnSubjectName;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.RichTextBox txtEntryCount;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.ColumnHeader clnDate;
        private System.Windows.Forms.ColumnHeader clnID;
    }
}