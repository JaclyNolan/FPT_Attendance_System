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
    public partial class AddLesson : Form
    {
        LessonAdmin lessonAdminPage;
        string sqlconnect = "server = NGUYEN-MINH-ANH\\SQLEXPRESS;database=FPTAttendanceSystem;uid=sa;pwd=123456";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public AddLesson(LessonAdmin lessonAdminPage1)
        {
            InitializeComponent();
            lessonAdminPage = lessonAdminPage1;
        }

        private void AddLesson_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(sqlconnect);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT tId FROM Teacher";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboTeacherID.Items.Add(dr.GetInt32(0).ToString());
            }
            dr.Close();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT cId FROM Class";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboClassID.Items.Add(dr.GetInt32(0).ToString());
            }
            dr.Close();
            con.Close();
        }

        private void AddLesson_FormClosing(object sender, FormClosingEventArgs e)
        {
            lessonAdminPage.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Lesson(lessonDate, teacherID, classID) OUTPUT Inserted.lessonID VALUES(@lessonDate,@teacherID,@classID)";
                
                cmd.Parameters.Add("@lessonDate", SqlDbType.Date).Value = dtpLessonDate.Value;
                cmd.Parameters.Add("@teacherID", SqlDbType.Int).Value = comboTeacherID.Text;
                cmd.Parameters.Add("@classID", SqlDbType.Int).Value = comboClassID.Text;

                dr = cmd.ExecuteReader();
                string lessonID = "";
                if (dr.Read()) lessonID = dr.GetInt32(0).ToString();
                dr.Close();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(studentID) FROM StudentClass WHERE classID = " + comboClassID.Text;
                dr = cmd.ExecuteReader();
                int nOfStudentID = 0;
                if (dr.Read()) nOfStudentID = dr.GetInt32(0);
                dr.Close();
                int[] studentID = new int[nOfStudentID];
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT studentID FROM StudentClass WHERE classID = " + comboClassID.Text;
                dr = cmd.ExecuteReader();
                SqlCommand cmd2;
                for (int i = 0; i < nOfStudentID; i++)
                {
                    dr.Read();
                    studentID[i] = dr.GetInt32(0);
                }
                dr.Close(); 
                foreach (int id in studentID)
                {
                    cmd2 = con.CreateCommand();
                    cmd2.CommandText = "INSERT INTO StudentAttendance(studentID, lessonID, saPresent, saReasonOfAbsent) VALUES (" + id + "," + lessonID + ",0,'')";
                    cmd2.ExecuteNonQuery();
                }
                MessageBox.Show("Lesson has been successfully added!", "Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Value", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }
    }
}
