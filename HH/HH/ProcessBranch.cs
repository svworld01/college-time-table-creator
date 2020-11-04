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
    public partial class ProcessBranch : Form
    {
        public ProcessBranch()
        {
            InitializeComponent();
        }

        private void ProcessBranch_Load(object sender, EventArgs e)
        {
            MyDbCon mdb = new MyDbCon();
            String sql = "select * from branch";
            MySqlDataReader reader = mdb.selectRow(sql);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString(0));
                }

            }
            else {
                MessageBox.Show("There is no branch.");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String action = comboBox2.Text;
            String branch = comboBox1.Text;
            if (action.Equals("EDIT")) {
                EditBranch eb = new EditBranch(branch);
                this.Hide();
                eb.Show();
            }
            else if (action.Equals("DELETE"))
            {
                MyDbCon md = new MyDbCon();
                String query = "delete from branch where bcode="+comboBox1.Text+"";
                if (md.runQuery(query))
                {
                    MessageBox.Show("Deleted Successfully.");
                    this.Hide();
                    Branch b = new Branch();
                    b.Show();
                }
                else {
                    MessageBox.Show("Failed !!");
                }

            }
            else {
                MessageBox.Show("Failed to delete.");
            }
        }
    }
}
