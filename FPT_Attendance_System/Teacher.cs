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
    public partial class Teacher : Form
    {
        private Login loginPage;
        private string teacherID;
        public Teacher(Login loginPage1, string teacherID1)
        {
            InitializeComponent();
            loginPage = loginPage1;
            teacherID = teacherID1;
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            labelUsername.Text = "Teacher: " + Global.GlobalUsername;
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            LessonTeacher nextPage = new LessonTeacher(this, teacherID);
            nextPage.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Teacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginPage.Show();
        }
    }
}
