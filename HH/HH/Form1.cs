using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace HH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            MyDbCon c = new MyDbCon();
            String sql = "select * from `admin` where `username` = '" + textBox1.Text + "' and `password` = '" + textBox2.Text + "'";
            MySqlDataReader reader = c.selectRow(sql);

            if (reader.HasRows)
            {
                ActiveForm.Hide();
                Home h = new Home();
                h.Show();
            }
            else
            {
                MessageBox.Show(reader.HasRows + ": You have entered wrong id or password.");
            }
        }
    }
}
