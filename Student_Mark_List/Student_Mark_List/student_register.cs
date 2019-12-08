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
    public partial class student_register : Form
    {
        Pen p;
        Rectangle rect;
       
        public student_register()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Personal\\Documents\\Login.accdb";
            OleDbConnection con = new OleDbConnection(conn);
            con.Open();
            OleDbCommand comm = con.CreateCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "insert into student_login values('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "',0,0,0,0,0)";

            comm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
            //Graphics g;
           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            student_login ss = new student_login();
            ss.Show();
        }

        private void student_register_Click(object sender, EventArgs e)
        {
            
           
           
        }
    }
}
