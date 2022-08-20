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
    public partial class AttendanceStudent : Form
    {
        private ClassStudent studentPage;
        private string studentID;
        private string classID;
        string sqlconnect = "server = NGUYEN-MINH-ANH\\SQLEXPRESS;database=FPTAttendanceSystem;uid=sa;pwd=123456";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int entryTotal = 0;
        public AttendanceStudent(ClassStudent studentPage1, string studentID1, string classID1)
        {
            InitializeComponent();
            studentID = studentID1;
            studentPage = studentPage1;
            classID = classID1;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AttendanceStudent_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(sqlconnect);
            UpdateListView();
        }
        void UpdateListView()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM StudentAttendance WHERE studentID = " + studentID;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                entryTotal = dr.GetInt32(0);
                txtEntryCount.Text = "Total: " + entryTotal + " lessons";
            }
            dr.Close();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT cName, cSubject FROM Class WHERE cID = " + classID;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                labelClass.Text = dr.GetString(0);
                labelSubject.Text = dr.GetString(1);
            }
            dr.Close();
            cmd.CommandText = "SELECT Lesson.lessonDate, StudentAttendance.saPresent, StudentAttendance.saReasonOfAbsent FROM Lesson, StudentAttendance WHERE Lesson.classID = " + classID + " AND Lesson.lessonID = StudentAttendance.lessonID AND StudentAttendance.studentID = " + studentID;
            dr = cmd.ExecuteReader();
            listLesson.Items.Clear();
            while (dr.Read())
            {
                string lessonDate = dr.GetDateTime(0).ToShortDateString();
                string present;
                if (dr.GetBoolean(1)) present = "Yes"; else present = "No";
                string reasonOfAbsent = dr.GetString(2);
                string[] arr = new string[3];
                arr[0] = lessonDate;
                arr[1] = present;
                arr[2] = reasonOfAbsent;
                ListViewItem itm = new ListViewItem(arr);
                listLesson.Items.Add(itm);
            }
            dr.Close();
            con.Close();
        }

        private void AttendanceStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            studentPage.Show();
        }
    }
}
