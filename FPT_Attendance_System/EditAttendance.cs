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
    public partial class EditAttendance : Form
    {
        private AttendaceAdmin adminPage;
        private AttendanceTeacher previousPage;
        string sqlconnect = "server = NGUYEN-MINH-ANH\\SQLEXPRESS;database=FPTAttendanceSystem;uid=sa;pwd=123456";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string lessonID;
        string studentID;
        public EditAttendance(AttendaceAdmin adminPage1, string lessonID1, string studentID1)
        {
            InitializeComponent();
            adminPage = adminPage1;
            lessonID = lessonID1;
            studentID = studentID1;
        }

        public EditAttendance(AttendanceTeacher previousPage1, string lessonID1, string studentID1)
        {
            InitializeComponent();
            previousPage = previousPage1;
            lessonID = lessonID1;
            studentID = studentID1;
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
                cmd.CommandText = "UPDATE StudentAttendance SET saPresent = @present, saReasonOfAbsent = @reasonOfAbsent WHERE lessonID = " + lessonID + " AND studentID = " + studentID;

                cmd.Parameters.Add("@present", SqlDbType.Bit).Value = radioPresent.Checked;
                cmd.Parameters.Add("@reasonOfAbsent", SqlDbType.VarChar).Value = rtxtReason.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Lesson has been successfully edited!", "Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Value", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void EditAttendance_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(sqlconnect);
            con.Open();
            txtLessonID.Text = lessonID;
            txtStudentID.Text = studentID;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT saPresent, saReasonOfAbsent FROM StudentAttendance WHERE lessonID = " + lessonID + " AND studentID = " + studentID;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                radioPresent.Checked = dr.GetBoolean(0);
                rtxtReason.Text = dr.GetString(1);
            }
            dr.Close();
            con.Close();
        }

        private void EditAttendance_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (adminPage != null) adminPage.Show(); else previousPage.Show();
        }
    }
}
