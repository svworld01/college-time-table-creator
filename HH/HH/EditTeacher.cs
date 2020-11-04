using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HH
{
    public partial class EditTeacher : Form
    {
        public EditTeacher()
        {
            InitializeComponent();
        }

        private void EditTeacher_Load(object sender, EventArgs e)
        {
            MyDbCon mdb = new MyDbCon();
            String sql = "select * from teacher";
            MySqlDataReader reader = mdb.selectRow(sql);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox3.Items.Add(reader.GetString(0));
                }

            }
            else
            {
                MessageBox.Show("There is no Teacher.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String scode = comboBox3.Text;
            if (scode.Equals("") || scode.Equals(null))
            {
                MessageBox.Show("Please Enter/Select Teacher ID.");
            }
            else
            {
                MyDbCon mdb = new MyDbCon();
                String sql = "select * from teacher where tid=" + comboBox3.Text + "";
                MySqlDataReader reader = mdb.selectRow(sql);
                if (reader.HasRows)
                {
                    reader.Read();
                    textBox1.Text = reader.GetString(1);
                    textBox2.Text = reader.GetString(2);
                }
                else
                {
                    MessageBox.Show("Teacher Dosen't Dosen't Exist.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text.Equals("") || comboBox3.Text.Equals(null))
            {
                MessageBox.Show("Please Select/Choose The Teacher ID First.");
            }
            else {
                MyDbCon mdb = new MyDbCon();
                String sql = "Update teacher set tname='"+textBox1.Text+"', tshort='"+textBox2.Text+"' where tid="+comboBox3.Text;
                if (mdb.runQuery(sql))
                {
                    MessageBox.Show("Teacher Details Updated Successfully!!");
                    this.Hide();
                    Teacher t = new Teacher();
                    t.Show();
                }
                else
                {
                    MessageBox.Show("Updation Failed !!");
                }
            }
        }
    }
}
