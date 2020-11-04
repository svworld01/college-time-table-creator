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
    public partial class EditSubject : Form
    {
        public EditSubject()
        {
            InitializeComponent();
        }

        private void EditSubject_Load(object sender, EventArgs e)
        {
            MyDbCon mdb = new MyDbCon();
            String sql = "select * from subject";
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
                MessageBox.Show("There is no branch.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String scode = comboBox3.Text;
            if (scode.Equals("") || scode.Equals(null))
            {
                MessageBox.Show("Please Enter/Select Subject Code.");
            }
            else {
                MyDbCon mdb = new MyDbCon();
                String sql = "select * from subject where scode=" + comboBox3.Text + "";
                MySqlDataReader reader = mdb.selectRow(sql);
                if (reader.HasRows)
                {
                    reader.Read();
                    textBox1.Text = reader.GetString(0);
                    textBox2.Text = reader.GetString(1);
                    textBox3.Text = reader.GetString(2);
                    textBox4.Text = reader.GetString(3);

                }
                else {
                    MessageBox.Show("Subject Code Dosen't Exist.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDbCon mdb = new MyDbCon();
            String sql = "update subject set scode="+textBox1.Text+", sname='"+textBox2.Text+"', bcode="+textBox3.Text+", years="+textBox4.Text+" where scode="+comboBox3.Text;
            if (mdb.runQuery(sql))
            {
                this.Hide();
                MessageBox.Show("Updated Successfully!!");
                Subject sb = new Subject();
                sb.Show();
            }
            else {
                MessageBox.Show("Failed !!");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
