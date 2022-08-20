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
    public partial class AttendanceTeacher : Form
    {
        private LessonTeacher previousPage;
        private string teacherID;
        private string lessonID;
        string sqlconnect = "server = NGUYEN-MINH-ANH\\SQLEXPRESS;database=FPTAttendanceSystem;uid=sa;pwd=123456";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int entryTotal = 0;
        public AttendanceTeacher(LessonTeacher previousPage1, string teacherID1, string lessonID1)
        {
            InitializeComponent();
            previousPage = previousPage1;
            teacherID = teacherID1;
            lessonID = lessonID1;
        }

        private void AttendanceTeacher_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(sqlconnect);
            UpdateLabel();
            UpdateListView();
        }

        void UpdateLabel()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM StudentAttendance WHERE lessonID = " + lessonID;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                entryTotal = dr.GetInt32(0);
                txtEntryCount.Text = "Total: " + entryTotal + " attendances";
            }
            dr.Close();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Lesson.lessonDate, Class.cName FROM Lesson, Class WHERE Lesson.classID = Class.cID AND Lesson.lessonID = " + lessonID;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                labelClass.Text = dr.GetString(1);
                labelDate.Text = dr.GetDateTime(0).ToShortDateString();
            }
            dr.Close();
            con.Close();
        }
        void UpdateListView()
        {
            con.Open();
            cmd.CommandText = "SELECT Student.sID, Student.sName, StudentAttendance.saPresent FROM Student, StudentAttendance WHERE Student.sID = StudentAttendance.studentID AND StudentAttendance.lessonID = " + lessonID;
            dr = cmd.ExecuteReader();
            listLesson.Items.Clear();
            while (dr.Read())
            {
                string studentID = dr.GetInt32(0).ToString();
                string studentName = dr.GetString(1).ToString();
                string present;
                if (dr.GetBoolean(2)) present = "Yes"; else present = "No";
                string[] arr = new string[3];
                arr[0] = studentID;
                arr[1] = studentName;
                arr[2] = present;
                ListViewItem itm = new ListViewItem(arr);
                listLesson.Items.Add(itm);
            }
            dr.Close();
            con.Close();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listLesson.SelectedItems.Count == 1)
            {
                con.Open();
                string studentID = listLesson.SelectedItems[0].Text;
                EditAttendance editLessonPage = new EditAttendance(this, lessonID, studentID);
                editLessonPage.Show();
                this.Hide();
                dr.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("Please select one lesson to be edited", "Select Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (listLesson.SelectedItems.Count > 0)
            {
                con.Open();
                foreach (ListViewItem item in listLesson.SelectedItems)
                {
                    string studentID = item.Text;
                    cmd = con.CreateCommand();
                    cmd.CommandText = "UPDATE StudentAttendance SET saPresent = 1 WHERE studentID = " + studentID;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show(listLesson.SelectedItems.Count + " record(s) has been modified", "Check Yes");
                UpdateListView();
            }
            else
            {
                MessageBox.Show("Please select one lesson to check", "Select Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            UpdateListView();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (listLesson.SelectedItems.Count > 0)
            {
                con.Open();
                foreach (ListViewItem item in listLesson.SelectedItems)
                {
                    string studentID = item.Text;
                    cmd = con.CreateCommand();
                    cmd.CommandText = "UPDATE StudentAttendance SET saPresent = 0 WHERE studentID = " + studentID;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show(listLesson.SelectedItems.Count + " record(s) has been modified", "Check No");
                UpdateListView();
            }
            else
            {
                MessageBox.Show("Please select one lesson to check", "Select Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            UpdateListView();
        }

        private void AttendanceTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousPage.Show();
        }

        private void AttendanceTeacher_Activated(object sender, EventArgs e)
        {
            UpdateListView();
        }
    }
}
