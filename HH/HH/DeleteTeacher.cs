using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace HH
{
    public partial class DeleteTeacher : Form
    {
        public DeleteTeacher()
        {
            InitializeComponent();
        }

        private void DeleteTeacher_Load(object sender, EventArgs e)
        {
            MyDbCon mdb = new MyDbCon();
            String sql = "select * from teacher";
            MySqlDataReader reader = mdb.selectRow(sql);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString(0));
                }

            }
            else
            {
                MessageBox.Show("There is no TEACHER.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            String query = "delete from teacher where tid=" + comboBox1.Text + "";
            if (md.runQuery(query))
            {
                MessageBox.Show("Deleted Successfully.");
                this.Hide();
                Teacher b = new Teacher();
                b.Show();
            }
            else
            {
                MessageBox.Show("Failed !!");
            }
        }
    }
}
