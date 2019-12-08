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
    public partial class Update_mark : Form
    {
        public Update_mark()
        {
            InitializeComponent();
        }

        private void Update_mark_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Personal\\Documents\\Login.accdb";
            OleDbConnection con = new OleDbConnection(conn);
            con.Open();
            OleDbCommand comm = con.CreateCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "update student_login set Platform_Tech='"+textBox3.Text+"',Automata_Theory='"+textBox4.Text+"',Embedded_System='"+textBox5.Text+"',Mobile_App='"+textBox6.Text+"' where Register_name='"+textBox1.Text+"'";
            comm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            string conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Personal\\Documents\\Login.accdb";
            OleDbConnection con = new OleDbConnection(conn);
            con.Open();
            OleDbCommand comm = con.CreateCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "delete from student_login where Register_name='" + textBox1.Text + "'";
            comm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted");
        }

        private void Update_mark_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
