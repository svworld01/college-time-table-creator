using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HH
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(textBox3.Text))
            {
                MyDbCon mdb = new MyDbCon();
                String sql = "UPDATE `admin` SET `password`=" + textBox3.Text + " WHERE  id=1 and password = " + textBox1.Text;
                if (mdb.runQuery(sql)) {
                    MessageBox.Show("Password Changed Successfully!!");
                    this.Close();
                }
            }
            else {
                MessageBox.Show("New and Confirm password dosen't match.");
            }
            
        }
    }
}
