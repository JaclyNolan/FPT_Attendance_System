using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPT_Attendance_System
{
    public partial class Student : Form
    {
        private Login loginPage;
        private string studentID;
        public Student(Login loginPage1, string studentID1)
        {
            InitializeComponent();
            loginPage = loginPage1;
            studentID = studentID1;
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            ClassStudent classPage = new ClassStudent(this, studentID);
            classPage.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            labelUsername.Text = "Student: " + Global.GlobalUsername;
        }

        private void Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginPage.Show();
        }
    }
}
