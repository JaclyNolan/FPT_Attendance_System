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
    public partial class LessonAdmin : Form
    {
        private Admin adminPage;
        string sqlconnect = "server = NGUYEN-MINH-ANH\\SQLEXPRESS;database=FPTAttendanceSystem;uid=sa;pwd=123456";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int entryTotal = 0;
        public LessonAdmin(Admin adminPage1)
        {
            InitializeComponent();
            adminPage = adminPage1;
        }

        private void LessonAdmin_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(sqlconnect);
            UpdateListView();
        }

        void UpdateListView()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Lesson";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                entryTotal = dr.GetInt32(0);
                txtEntryCount.Text = "Total: " + entryTotal + " entries";
            }
            dr.Close();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Lesson.lessonID, Lesson.lessonDate, " +
                "Teacher.tName , Class.cName FROM Lesson, Class, Teacher " +
                "WHERE Class.cID = Lesson.classID AND Teacher.tId = Lesson.teacherID";
            dr = cmd.ExecuteReader();
            listLesson.Items.Clear();
            while (dr.Read())
            {
                string lessonID = dr.GetInt32(0).ToString();
                string lessonDate = dr.GetDateTime(1).ToShortDateString();
                string teacherName = dr.GetString(2);
                string className = dr.GetString(3);
                string[] arr = new string[4];
                arr[0] = lessonID;
                arr[1] = lessonDate;
                arr[2] = teacherName;
                arr[3] = className;
                ListViewItem itm = new ListViewItem(arr);
                listLesson.Items.Add(itm);
            }
            con.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LessonAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            dr.Close();
            adminPage.Show();
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            AddLesson addLessonPage = new AddLesson(this);
            addLessonPage.Show();
            this.Hide();
        }

        private void btnEditLesson_Click(object sender, EventArgs e)
        {
            string lessonID;
            if (listLesson.SelectedItems.Count == 1)
            {
                lessonID = listLesson.SelectedItems[0].Text;
                EditLesson editLessonPage = new EditLesson(this, lessonID);
                editLessonPage.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Please select one lesson to be edited", "Select Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            if (listLesson.SelectedItems.Count > 0)
            {
                con.Open();
                foreach (ListViewItem item in listLesson.SelectedItems)
                {
                    string lessonID = item.Text;
                    cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM StudentAttendance WHERE lessonID = " + lessonID;
                    cmd.ExecuteNonQuery();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM Lesson WHERE lessonID = " + lessonID;
                    cmd.ExecuteNonQuery();
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

        private void btnCheckAttendance_Click(object sender, EventArgs e)
        {
            string lessonID;
            if (listLesson.SelectedItems.Count == 1)
            {
                lessonID = listLesson.SelectedItems[0].Text;
                AttendaceAdmin attendanceAdminPage = new AttendaceAdmin(this, lessonID);
                attendanceAdminPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select one lesson to check the attendance status", "Select Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LessonAdmin_Activated(object sender, EventArgs e)
        {
            UpdateListView();
        }
    }
}
