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
    public partial class ClassStudent : Form
    {
        private Student studentPage;
        private string studentID;
        string sqlconnect = "server = NGUYEN-MINH-ANH\\SQLEXPRESS;database=FPTAttendanceSystem;uid=sa;pwd=123456";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int entryTotal = 0;
        public ClassStudent(Student studentPage1, string studentID1)
        {
            InitializeComponent();
            studentPage = studentPage1;
            studentID = studentID1;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClassStudent_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(sqlconnect);
            con.Open();
            labelUsername.Text = "Student: " + Global.GlobalUsername;
            con.Close();
            UpdateListView();
        }

        void UpdateListView()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM StudentClass WHERE studentID = " + studentID;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                entryTotal = dr.GetInt32(0);
                txtEntryCount.Text = "Total: " + entryTotal + " classes";
            }
            dr.Close();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Class.cName, Class.cSubject FROM Class, StudentClass WHERE StudentClass.classID = Class.cID AND StudentClass.studentID = " + studentID;
            dr = cmd.ExecuteReader();
            listLesson.Items.Clear();
            while (dr.Read())
            {
                string className = dr.GetString(0);
                string subjectName = dr.GetString(1);
                string[] arr = new string[2];
                arr[0] = className;
                arr[1] = subjectName;
                ListViewItem itm = new ListViewItem(arr);
                listLesson.Items.Add(itm);
            }
            dr.Close();
            con.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (listLesson.SelectedItems.Count == 1)
            {
                string className = listLesson.SelectedItems[0].Text;
                string classID = "";
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT cID FROM Class WHERE cName = '" + className + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read()) classID = dr.GetInt32(0).ToString();
                dr.Close();
                con.Close();
                AttendanceStudent attendancePage = new AttendanceStudent(this, studentID, classID);
                attendancePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select one class to be viewed", "Select Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClassStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            studentPage.Show();
        }
    }
}
