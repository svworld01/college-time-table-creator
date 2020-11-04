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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void branchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Branch b = new Branch();
            b.Show();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subject sub = new Subject();
            sub.Show();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();
        }

        private void timeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeTable ttt = new TimeTable();
            ttt.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.Show(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
