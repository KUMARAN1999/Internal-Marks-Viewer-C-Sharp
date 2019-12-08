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
    public partial class staff_register : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Personal\\Documents\\Login.accdb");
        public staff_register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand comm = con.CreateCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "insert into Staff_login values('"+textBox2.Text+"','"+textBox1.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"')";
            comm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            staff_register s = new staff_register();
            s.Close();
            staff_login ss = new staff_login();
            ss.Show();
        }
    }
}
