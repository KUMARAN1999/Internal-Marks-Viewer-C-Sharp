using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Student_Mark_List
{
    public partial class mark_list : Form
    {
        public mark_list()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Personal\\Documents\\Login.accdb";
            OleDbConnection con = new OleDbConnection(conn);
            string command="select * from student_login where Register_name='"+textBox1.Text+"'";
            con.Open();
            OleDbCommand cmd = new OleDbCommand(command,con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                label8.Text = dr.GetValue(5).ToString();
                label9.Text = dr.GetValue(6).ToString();
                label10.Text = dr.GetValue(7).ToString();
                label11.Text = dr.GetValue(8).ToString();
                label12.Text = dr.GetValue(9).ToString();
            }
            con.Close();
                        

        }
    }
}
