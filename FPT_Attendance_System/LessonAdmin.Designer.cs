namespace FPT_Attendance_System
{
    partial class LessonAdmin
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
            System.Windows.Forms.ColumnHeader clnID;
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
            this.btnHome = new System.Windows.Forms.Button();
            this.listLesson = new System.Windows.Forms.ListView();
            this.clnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTeacherName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtEntryCount = new System.Windows.Forms.RichTextBox();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.btnEditLesson = new System.Windows.Forms.Button();
            this.btnDeleteLesson = new System.Windows.Forms.Button();
            this.btnCheckAttendance = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            clnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // clnID
            // 
            clnID.Text = "ID";
            clnID.Width = 50;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(126, 42);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // listLesson
            // 
            this.listLesson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            clnID,
            this.clnDate,
            this.clnTeacherName,
            this.clnClassName});
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
            this.listLesson.Location = new System.Drawing.Point(31, 72);
            this.listLesson.Name = "listLesson";
            this.listLesson.Size = new System.Drawing.Size(581, 293);
            this.listLesson.TabIndex = 1;
            this.listLesson.UseCompatibleStateImageBehavior = false;
            this.listLesson.View = System.Windows.Forms.View.Details;
            // 
            // clnDate
            // 
            this.clnDate.Text = "Date";
            this.clnDate.Width = 100;
            // 
            // clnTeacherName
            // 
            this.clnTeacherName.Text = "Teacher Name";
            this.clnTeacherName.Width = 150;
            // 
            // clnClassName
            // 
            this.clnClassName.Text = "Class Name";
            this.clnClassName.Width = 150;
            // 
            // txtEntryCount
            // 
            this.txtEntryCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntryCount.DetectUrls = false;
            this.txtEntryCount.Location = new System.Drawing.Point(499, 45);
            this.txtEntryCount.Name = "txtEntryCount";
            this.txtEntryCount.ReadOnly = true;
            this.txtEntryCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEntryCount.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtEntryCount.Size = new System.Drawing.Size(114, 29);
            this.txtEntryCount.TabIndex = 2;
            this.txtEntryCount.Text = "Entry: 12 of 12";
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Location = new System.Drawing.Point(31, 385);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(582, 33);
            this.btnAddLesson.TabIndex = 7;
            this.btnAddLesson.Text = "Add a new lesson";
            this.btnAddLesson.UseVisualStyleBackColor = true;
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // btnEditLesson
            // 
            this.btnEditLesson.Location = new System.Drawing.Point(31, 424);
            this.btnEditLesson.Name = "btnEditLesson";
            this.btnEditLesson.Size = new System.Drawing.Size(582, 33);
            this.btnEditLesson.TabIndex = 8;
            this.btnEditLesson.Text = "Edit the selected lesson";
            this.btnEditLesson.UseVisualStyleBackColor = true;
            this.btnEditLesson.Click += new System.EventHandler(this.btnEditLesson_Click);
            // 
            // btnDeleteLesson
            // 
            this.btnDeleteLesson.Location = new System.Drawing.Point(31, 463);
            this.btnDeleteLesson.Name = "btnDeleteLesson";
            this.btnDeleteLesson.Size = new System.Drawing.Size(582, 33);
            this.btnDeleteLesson.TabIndex = 9;
            this.btnDeleteLesson.Text = "Delete the selected lesson";
            this.btnDeleteLesson.UseVisualStyleBackColor = true;
            this.btnDeleteLesson.Click += new System.EventHandler(this.btnDeleteLesson_Click);
            // 
            // btnCheckAttendance
            // 
            this.btnCheckAttendance.Location = new System.Drawing.Point(30, 502);
            this.btnCheckAttendance.Name = "btnCheckAttendance";
            this.btnCheckAttendance.Size = new System.Drawing.Size(582, 33);
            this.btnCheckAttendance.TabIndex = 10;
            this.btnCheckAttendance.Text = "Check attendance status of the selected lesson";
            this.btnCheckAttendance.UseVisualStyleBackColor = true;
            this.btnCheckAttendance.Click += new System.EventHandler(this.btnCheckAttendance_Click);
            // 
            // LessonAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 553);
            this.Controls.Add(this.btnCheckAttendance);
            this.Controls.Add(this.btnDeleteLesson);
            this.Controls.Add(this.btnEditLesson);
            this.Controls.Add(this.btnAddLesson);
            this.Controls.Add(this.txtEntryCount);
            this.Controls.Add(this.listLesson);
            this.Controls.Add(this.btnHome);
            this.Name = "LessonAdmin";
            this.Text = "Lesson Management";
            this.Activated += new System.EventHandler(this.LessonAdmin_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LessonAdmin_FormClosing);
            this.Load += new System.EventHandler(this.LessonAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ListView listLesson;
        private System.Windows.Forms.ColumnHeader clnDate;
        private System.Windows.Forms.ColumnHeader clnTeacherName;
        private System.Windows.Forms.ColumnHeader clnClassName;
        private System.Windows.Forms.RichTextBox txtEntryCount;
        private System.Windows.Forms.Button btnAddLesson;
        private System.Windows.Forms.Button btnEditLesson;
        private System.Windows.Forms.Button btnDeleteLesson;
        private System.Windows.Forms.Button btnCheckAttendance;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}