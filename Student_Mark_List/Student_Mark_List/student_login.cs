using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace Student_Mark_List
{
    public partial class student_login : Form
    {
        public student_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Personal\\Documents\\Login.accdb";
            OleDbConnection con = new OleDbConnection(conn);
            string command = "select * from student_login where  Register_name = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'";
            con.Open();
            OleDbCommand comm = new OleDbCommand(command,con);
            OleDbDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login Success");
                Thread.Sleep(2000);
                student_login s = new student_login();
                s.Close();
                mark_list mm = new mark_list();
                mm.Show();
                
            }
            else
            {
                MessageBox.Show("Incorrect Register Number or Password");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            student_register ss = new student_register();
            ss.Show();
        }
    }
}
