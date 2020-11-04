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
    public partial class TimeTable : Form
    {
        public TimeTable()
        {
            InitializeComponent();
        }

        private void TimeTable_Load(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from branch";
            MySqlDataReader reader = md.selectRow(sql);
            if (reader.HasRows) {
                while (reader.Read()) {
                    comboBox1.Items.Add(reader.GetString(0));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            String sql = "select ttid from timetable where bcode = '"+comboBox1.Text+"' and bshift = '"+comboBox2.Text+"' and years = '"+comboBox3.Text+"'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                MessageBox.Show("Time Table already exists!! \nClick to show for update.");
            }
            else
            {
                AddTT adt = new AddTT(int.Parse(comboBox1.Text), int.Parse(comboBox2.Text), int.Parse(comboBox3.Text));
                this.Hide();
                adt.Show();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            String sql = "select ttid from timetable where bcode = '" + comboBox1.Text + "' and bshift = '" + comboBox2.Text + "' and years = '" + comboBox3.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                ShowTimeTable adt = new ShowTimeTable(int.Parse(comboBox1.Text), int.Parse(comboBox2.Text), int.Parse(comboBox3.Text));
                this.Hide();
                adt.Show();
            }
            else
            {
                MessageBox.Show("Time Table Doesn't Exist!! \nClick on Create to create the time table.");
            }
        }
    }
}
