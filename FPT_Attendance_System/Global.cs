using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT_Attendance_System
{
    static class Global
    {
        private static string _globalUsername = "";

        public static string GlobalUsername
        {
            get { return _globalUsername; }
            set { _globalUsername = value; }
        }
    }
}
