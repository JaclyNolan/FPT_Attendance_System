namespace FPT_Attendance_System
{
    partial class AttendanceStudent
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
            this.clnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnPresent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHome = new System.Windows.Forms.Button();
            this.txtEntryCount = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listLesson
            // 
            this.listLesson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnDate,
            this.clnPresent,
            this.clnReason});
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
            this.listLesson.Location = new System.Drawing.Point(31, 108);
            this.listLesson.Name = "listLesson";
            this.listLesson.Size = new System.Drawing.Size(581, 293);
            this.listLesson.TabIndex = 29;
            this.listLesson.UseCompatibleStateImageBehavior = false;
            this.listLesson.View = System.Windows.Forms.View.Details;
            // 
            // clnDate
            // 
            this.clnDate.Text = "Date";
            this.clnDate.Width = 100;
            // 
            // clnPresent
            // 
            this.clnPresent.Text = "Present";
            this.clnPresent.Width = 70;
            // 
            // clnReason
            // 
            this.clnReason.Text = "Reason";
            this.clnReason.Width = 250;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(126, 42);
            this.btnHome.TabIndex = 28;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtEntryCount
            // 
            this.txtEntryCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntryCount.DetectUrls = false;
            this.txtEntryCount.Location = new System.Drawing.Point(446, 81);
            this.txtEntryCount.Name = "txtEntryCount";
            this.txtEntryCount.ReadOnly = true;
            this.txtEntryCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEntryCount.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtEntryCount.Size = new System.Drawing.Size(167, 29);
            this.txtEntryCount.TabIndex = 30;
            this.txtEntryCount.Text = "Entry: 12 of 12";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(34, 55);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(44, 16);
            this.labelClass.TabIndex = 32;
            this.labelClass.Text = "Class:";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(290, 55);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(55, 16);
            this.labelSubject.TabIndex = 33;
            this.labelSubject.Text = "Subject:";
            // 
            // AttendanceStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 423);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.listLesson);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtEntryCount);
            this.Controls.Add(this.labelClass);
            this.Name = "AttendanceStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AttendanceStudent_FormClosing);
            this.Load += new System.EventHandler(this.AttendanceStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listLesson;
        private System.Windows.Forms.ColumnHeader clnDate;
        private System.Windows.Forms.ColumnHeader clnPresent;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.RichTextBox txtEntryCount;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.ColumnHeader clnReason;
        private System.Windows.Forms.Label labelSubject;
    }
}