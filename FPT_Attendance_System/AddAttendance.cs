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
    public partial class AddAttendance : Form
    {
        AttendaceAdmin lessonAdminPage;
        string lessonID;
        string sqlconnect = "server = NGUYEN-MINH-ANH\\SQLEXPRESS;database=FPTAttendanceSystem;uid=sa;pwd=123456";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public AddAttendance(AttendaceAdmin lessonAdminPage1, string lessonID1)
        {
            InitializeComponent();
            lessonAdminPage = lessonAdminPage1;
            lessonID = lessonID1;
        }

        private void AddAttendance_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(sqlconnect);
            con.Open();
            txtLessonID.Text = lessonID;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT sId FROM Student";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboStudentID.Items.Add(dr.GetInt32(0).ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO StudentAttendance(lessonID, studentID, saPresent, saReasonOfAbsent) VALUES(@lessonID,@studentID,@present,@reasonOfAbsent)";

                cmd.Parameters.Add("@lessonID", SqlDbType.Int).Value = Int32.Parse(lessonID);
                cmd.Parameters.Add("@studentID", SqlDbType.Int).Value = Int32.Parse(comboStudentID.Text);
                cmd.Parameters.Add("@present", SqlDbType.Bit).Value = radioPresent.Checked;
                cmd.Parameters.Add("@reasonOfAbsent", SqlDbType.VarChar).Value = rtxtReason.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Attendance has been successfully added!", "Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Value", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void AddAttendance_FormClosing(object sender, FormClosingEventArgs e)
        {
            lessonAdminPage.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
