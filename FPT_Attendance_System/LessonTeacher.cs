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
    public partial class LessonTeacher : Form
    {
        private Teacher teacherPage;
        private string teacherID;
        string sqlconnect = "server = NGUYEN-MINH-ANH\\SQLEXPRESS;database=FPTAttendanceSystem;uid=sa;pwd=123456";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int entryTotal = 0;
        public LessonTeacher(Teacher teacherPage1, string teacherID1)
        {
            InitializeComponent();
            teacherPage = teacherPage1;
            teacherID = teacherID1;
        }

        private void LessonTeacher_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(sqlconnect);
            con.Open();
            labelUsername.Text = "Teacher: " + Global.GlobalUsername;
            con.Close();
            UpdateListView();
        }

        void UpdateListView()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Lesson WHERE teacherID = " + teacherID;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                entryTotal = dr.GetInt32(0);
                txtEntryCount.Text = "Total: " + entryTotal + " lessons";
            }
            dr.Close();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Lesson.lessonID, Lesson.lessonDate, Class.cName, Class.cSubject FROM Class, Lesson WHERE Class.cID = Lesson.classID AND Lesson.teacherID = " + teacherID;
            dr = cmd.ExecuteReader();
            listLesson.Items.Clear();
            while (dr.Read())
            {
                string lessonID = dr.GetInt32(0).ToString();
                string date = dr.GetDateTime(1).ToShortDateString();
                string className = dr.GetString(2);
                string subjectName = dr.GetString(3);
                string[] arr = new string[4];
                arr[0] = lessonID;
                arr[1] = date;
                arr[2] = className;
                arr[3] = subjectName;
                ListViewItem itm = new ListViewItem(arr);
                listLesson.Items.Add(itm);
            }
            dr.Close();
            con.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string lessonID;
            if (listLesson.SelectedItems.Count == 1)
            {
                lessonID = listLesson.SelectedItems[0].Text;
                AttendanceTeacher editLessonPage = new AttendanceTeacher(this, teacherID, lessonID);
                editLessonPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select one lesson to be viewed", "Select Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LessonTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            teacherPage.Show();
        }
    }
}
