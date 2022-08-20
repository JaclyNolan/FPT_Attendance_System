using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FPT_Attendance_System
{
    public partial class AttendaceAdmin : Form
    {
        private LessonAdmin lessonAdminPage;
        private string lessonID;
        string sqlconnect = "server = NGUYEN-MINH-ANH\\SQLEXPRESS;database=FPTAttendanceSystem;uid=sa;pwd=123456";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int entryTotal = 0;
        public AttendaceAdmin(LessonAdmin lessonAdminPage1, string lessonID1)
        {
            InitializeComponent();
            lessonAdminPage = lessonAdminPage1;
            lessonID = lessonID1;
        }

        private void AttendaceAdmin_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(sqlconnect);
            UpdateLabel();
            UpdateListView();
        }

        void UpdateLabel()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Lesson.lessonID, Lesson.lessonDate, Teacher.tName , Class.cName FROM Lesson, Class, Teacher WHERE Lesson.lessonID = " + lessonID + " AND Class.cID = Lesson.classID AND Teacher.tId = Lesson.teacherID";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                labelLessonID.Text = "LessonID: " + dr.GetInt32(0).ToString();
                labelDate.Text = "Date: " + dr.GetDateTime(1).ToShortDateString();
                labelTeacher.Text = "Teacher: " + dr.GetString(2);
                labelClass.Text = "Class: " + dr.GetString(3);
            }
            con.Close();
        }

        void UpdateListView()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM StudentAttendance WHERE lessonID = " + lessonID;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                entryTotal = dr.GetInt32(0);
                txtEntryCount.Text = "Total: " + entryTotal + " entries";
            }
            dr.Close();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Student.sName, StudentAttendance.saPresent, StudentAttendance.saReasonOfAbsent FROM Student, StudentAttendance WHERE StudentAttendance.lessonID = " + lessonID + " AND Student.sID = StudentAttendance.studentID";
            dr = cmd.ExecuteReader();
            listLesson.Items.Clear();
            while (dr.Read())
            {
                string studentName = dr.GetString(0);
                string present;
                if (dr.GetBoolean(1)) present = "Yes"; else present = "No";
                string absent = dr.GetString(2);
                string[] arr = new string[3];
                arr[0] = studentName;
                arr[1] = present;
                arr[2] = absent;
                ListViewItem itm = new ListViewItem(arr);
                listLesson.Items.Add(itm);
            }
            dr.Close();
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listLesson.SelectedItems.Count > 0)
            {
                con.Open();

                foreach (ListViewItem item in listLesson.SelectedItems)
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT sID FROM Student WHERE sName = '" + item.Text + "'";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        string studentID = dr.GetInt32(0).ToString();
                        dr.Close();
                        cmd = con.CreateCommand();
                        cmd.CommandText = "DELETE FROM StudentAttendance WHERE lessonID = " + lessonID + " AND studentID = " + studentID;
                        cmd.ExecuteNonQuery();
                    }
                    
                }
                con.Close();
                MessageBox.Show(listLesson.SelectedItems.Count + " record(s) has been deleted", "Deleted");
                UpdateListView();
            }
            else
            {
                MessageBox.Show("Please select one lesson to be deleted", "Select Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listLesson.SelectedItems.Count == 1)
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT sID FROM Student WHERE sName = '" + listLesson.SelectedItems[0].Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string studentID = dr.GetInt32(0).ToString();
                    EditAttendance editLessonPage = new EditAttendance(this, lessonID, studentID);
                    editLessonPage.Show();
                    this.Hide();
                }
                dr.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("Please select one lesson to be edited", "Select Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAttendance addPage = new AddAttendance(this, lessonID);
            addPage.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AttendaceAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            lessonAdminPage.Show();
        }

        private void AttendaceAdmin_Activated(object sender, EventArgs e)
        {
            UpdateListView();
        }
    }
}
