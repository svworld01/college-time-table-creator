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
    public partial class EditBranch : Form
    {
        private String branch;
        public EditBranch(String b)
        {
            InitializeComponent();
            branch = b;
        }

        private void EditBranch_Load(object sender, EventArgs e)
        {
            MyDbCon mdb = new MyDbCon();
            String sql = "select * from branch where bcode = "+branch+"";
            MySqlDataReader reader = mdb.selectRow(sql);

            if (reader.HasRows)
            {
                reader.Read();
                textBox1.Text = reader.GetString(0);
                textBox2.Text = reader.GetString(1);
                textBox3.Text = reader.GetString(2);
                textBox4.Text = reader.GetString(3);
            }
            else
            {
                MessageBox.Show("There is no branch.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDbCon mdb = new MyDbCon();
            String sql = "UPDATE branch SET bname='"+textBox2.Text+"',byear="+textBox3.Text+",bshift="+textBox4.Text+" WHERE bcode="+branch+"";
            if (mdb.runQuery(sql)) {
                this.Hide();
                MessageBox.Show("Updated Succefully !!");
                Branch b = new Branch();
                b.Show();
            }
            else
            {
                MessageBox.Show("There is no branch.");
            }
        }
    }
}
