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
    public partial class DeleteSubject : Form
    {
        public DeleteSubject()
        {
            InitializeComponent();
        }

        private void DeleteSubject_Load(object sender, EventArgs e)
        {
            MyDbCon mdb = new MyDbCon();
            String sql = "select * from subject";
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
                MessageBox.Show("There is no branch.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            String query = "delete from subject where scode=" + comboBox1.Text + "";
            if (md.runQuery(query))
            {
                MessageBox.Show("Deleted Successfully.");
                this.Hide();
                Subject b = new Subject();
                b.Show();
            }
            else
            {
                MessageBox.Show("Failed !!");
            }
        }
    }
}
