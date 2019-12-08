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
    public partial class staff_login : Form
    {
        public staff_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Personal\\Documents\\Login.accdb";
            OleDbConnection con = new OleDbConnection(conn);
            string command = "SELECT * FROM Staff_login WHERE  Staff_ID = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "'";
            con.Open();
            OleDbCommand comm = new OleDbCommand(command,con);
            OleDbDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login Success");
                Thread.Sleep(2000);
                Update_mark uu = new Update_mark();
                uu.Show();

            }
            else
            {
                MessageBox.Show("Incorrect Register Number or Password");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            staff_register s = new staff_register();
            s.Show();

        }

        private void staff_login_MouseMove(object sender, MouseEventArgs e)
        {

        }

      
    }
}
