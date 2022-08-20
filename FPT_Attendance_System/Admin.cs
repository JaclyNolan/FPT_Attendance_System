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
    public partial class Admin : Form
    {
        private Login loginPage;
        public Admin(Login loginPage1)
        {
            InitializeComponent();
            loginPage = loginPage1;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            labelUsername.Text = labelUsername.Text + " " + Global.GlobalUsername;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginPage.Show();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            LessonAdmin lessonAdminPage = new LessonAdmin(this);
            lessonAdminPage.Show();
            this.Hide();
        }
    }
}
