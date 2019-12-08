using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Mark_List
{
    public partial class Student_or_Staff : Form
    {
        public Student_or_Staff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student_login ss = new student_login();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            staff_login ss = new staff_login();
            ss.Show();
        }
    }
}
