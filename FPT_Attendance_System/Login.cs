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
    public partial class Login : Form
    {
        public static string username = "";
        String sqlconnect = "server = NGUYEN-MINH-ANH\\SQLEXPRESS;database=FPTLoginSystem;uid=sa;pwd=123456";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(sqlconnect);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select uRole, sID, tID from tblUser where uUsername = '" + username + "' and uPassword = '" + password + "'";
            dr = cmd.ExecuteReader(); 
            if (dr.Read())
            {
                String role = dr.GetString(0);
                Global.GlobalUsername = username;
                if (role == "admin")
                {
                    MessageBox.Show("Login successful as admin!", "Success", MessageBoxButtons.OK);
                    clearTxt();
                    Admin adminPage = new Admin(this);
                    adminPage.Show();
                    this.Hide();
                } 
                else if (role == "teacher")
                {
                    MessageBox.Show("Login successful as teacher!", "Success", MessageBoxButtons.OK);
                    clearTxt();
                    Teacher teacherPage = new Teacher(this, dr.GetInt32(2).ToString());
                    teacherPage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login successful as student!", "Success", MessageBoxButtons.OK);
                    clearTxt();
                    Student studentPage = new Student(this, dr.GetInt32(1).ToString());
                    studentPage.Show();
                    this.Hide();
                }
            } 
            else
            {
                clearTxt();
                MessageBox.Show("Given username or password is incorrect!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        void clearTxt()
        {
            txtPassword.Text = txtUsername.Text = "";
        }
    }
}
