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
    public partial class AddTT : Form
    {
        private int branch, year, shift;
        public AddTT(int branch, int year, int shift)
        {
            InitializeComponent();
            this.branch = branch;
            this.year = year;
            this.shift = shift;
        }

        private void AddTT_Load(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            String sql = "select tchsub.scode, subject.sname, tchsub.tid,teacher.tname from tchsub inner JOIN subject on tchsub.scode=subject.scode inner join teacher on tchsub.tid = teacher.tid where subject.bcode = "+branch+" and subject.years ="+year;
            MySqlDataReader reader =   md.selectRow(sql);
            if (reader.HasRows) {
                while (reader.Read()) {
                    string[] row1 = { reader.GetString(0), reader.GetString(1) };
                    string[] row2 = { reader.GetString(2), reader.GetString(3) };
                    Console.WriteLine("ROWS " + reader.GetString(1));
                    //var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(new ListViewItem(row1));
                    listView2.Items.Add(new ListViewItem(row2));
                    monday11.Items.Add(reader.GetString(0));
                    monday21.Items.Add(reader.GetString(0));
                    monday31.Items.Add(reader.GetString(0));
                    monday41.Items.Add(reader.GetString(0));
                    monday51.Items.Add(reader.GetString(0));
                    monday61.Items.Add(reader.GetString(0));

                    tuesday11.Items.Add(reader.GetString(0));
                    tuesday21.Items.Add(reader.GetString(0));
                    tuesday31.Items.Add(reader.GetString(0));
                    tuesday41.Items.Add(reader.GetString(0));
                    tuesday51.Items.Add(reader.GetString(0));
                    tuesday61.Items.Add(reader.GetString(0));

                    wednesday11.Items.Add(reader.GetString(0));
                    wednesday21.Items.Add(reader.GetString(0));
                    wednesday31.Items.Add(reader.GetString(0));
                    wednesday41.Items.Add(reader.GetString(0));
                    wednesday51.Items.Add(reader.GetString(0));
                    wednesday61.Items.Add(reader.GetString(0));

                    thursday11.Items.Add(reader.GetString(0));
                    thursday21.Items.Add(reader.GetString(0));
                    thursday31.Items.Add(reader.GetString(0));
                    thursday41.Items.Add(reader.GetString(0));
                    thursday51.Items.Add(reader.GetString(0));
                    thursday61.Items.Add(reader.GetString(0));

                    friday11.Items.Add(reader.GetString(0));
                    friday21.Items.Add(reader.GetString(0));
                    friday31.Items.Add(reader.GetString(0));
                    friday41.Items.Add(reader.GetString(0));
                    friday51.Items.Add(reader.GetString(0));
                    friday61.Items.Add(reader.GetString(0));

                    saturday11.Items.Add(reader.GetString(0));
                    saturday21.Items.Add(reader.GetString(0));
                    saturday31.Items.Add(reader.GetString(0));
                    saturday41.Items.Add(reader.GetString(0));
                    saturday51.Items.Add(reader.GetString(0));
                    saturday61.Items.Add(reader.GetString(0));
                }
            }
            
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tuesday_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void monday11_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='"+monday11.Text+"'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows) {
                while (rd.Read()) {
                    monday12.Items.Add(rd.GetString(0));
                }
            }
        }

        private void monday21_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + monday21.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    monday22.Items.Add(rd.GetString(0));
                }
            }
        }

        private void monday31_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + monday31.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    monday32.Items.Add(rd.GetString(0));
                }
            }
        }

        private void monday41_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + monday41.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    monday42.Items.Add(rd.GetString(0));
                }
            }
        }

        private void monday51_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + monday51.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    monday52.Items.Add(rd.GetString(0));
                }
            }
        }

        private void monday61_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + monday61.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    monday62.Items.Add(rd.GetString(0));
                }
            }
        }

        private void tuesday11_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + tuesday11.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    tuesday12.Items.Add(rd.GetString(0));
                }
            }
        }

        private void tuesday21_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + tuesday21.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    tuesday22.Items.Add(rd.GetString(0));
                }
            }
        }

        private void tuesday31_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + tuesday31.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    tuesday32.Items.Add(rd.GetString(0));
                }
            }
        }

        private void tuesday41_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + tuesday41.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    tuesday42.Items.Add(rd.GetString(0));
                }
            }
        }

        private void tuesday51_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + tuesday51.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    tuesday52.Items.Add(rd.GetString(0));
                }
            }
        }

        private void tuesday61_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + tuesday61.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    tuesday62.Items.Add(rd.GetString(0));
                }
            }
        }

        private void wednesday11_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + wednesday11.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    wednesday12.Items.Add(rd.GetString(0));
                }
            }
        }

        private void wednesday21_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + wednesday21.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    wednesday22.Items.Add(rd.GetString(0));
                }
            }
        }

        private void wednesday31_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + wednesday31.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    wednesday32.Items.Add(rd.GetString(0));
                }
            }
        }

        private void wednesday41_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + wednesday41.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    wednesday42.Items.Add(rd.GetString(0));
                }
            }
        }

        private void wednesday51_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + wednesday51.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    wednesday52.Items.Add(rd.GetString(0));
                }
            }
        }

        private void wednesday61_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + wednesday61.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    wednesday62.Items.Add(rd.GetString(0));
                }
            }
        }

        private void thursday11_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + thursday11.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    thursday12.Items.Add(rd.GetString(0));
                }
            }
        }

        private void thursday21_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + thursday21.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    thursday22.Items.Add(rd.GetString(0));
                }
            }
        }

        private void thursday31_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + thursday31.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    thursday32.Items.Add(rd.GetString(0));
                }
            }
        }

        private void thursday41_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + thursday41.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    thursday42.Items.Add(rd.GetString(0));
                }
            }
        }

        private void thursday51_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + thursday51.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    thursday52.Items.Add(rd.GetString(0));
                }
            }
        }

        private void thursday61_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + thursday61.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    thursday62.Items.Add(rd.GetString(0));
                }
            }
        }

        private void friday11_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + friday11.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    friday12.Items.Add(rd.GetString(0));
                }
            }
        }

        private void friday21_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + friday21.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    friday22.Items.Add(rd.GetString(0));
                }
            }
        }

        private void friday31_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + friday31.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    friday32.Items.Add(rd.GetString(0));
                }
            }
        }

        private void friday41_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + friday41.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    friday42.Items.Add(rd.GetString(0));
                }
            }
        }

        private void friday51_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + friday51.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    friday52.Items.Add(rd.GetString(0));
                }
            }
        }

        private void friday61_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + friday61.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    friday62.Items.Add(rd.GetString(0));
                }
            }
        }

        private void saturday11_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + saturday11.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    saturday12.Items.Add(rd.GetString(0));
                }
            }
        }

        private void saturday21_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + friday21.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    saturday22.Items.Add(rd.GetString(0));
                }
            }
        }

        private void saturday31_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + friday31.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    saturday32.Items.Add(rd.GetString(0));
                }
            }
        }

        private void saturday41_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + friday41.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    saturday42.Items.Add(rd.GetString(0));
                }
            }
        }

        private void saturday51_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + friday51.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    saturday52.Items.Add(rd.GetString(0));
                }
            }
        }

        private void saturday61_SelectedIndexChanged(object sender, EventArgs e)
        {

            MyDbCon md = new MyDbCon();
            string sql = "select tid from tchsub where scode='" + friday61.Text + "'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    saturday62.Items.Add(rd.GetString(0));
                }
            }
        }

        private void saturday12_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '"+saturday12.Text+"' and day = '6' and bshift = '"+shift+"' and lect='1'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {
                
                while (rd.Read()) {
                    saturday12.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\n branch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7)+" on subject = " + rd.GetString(4)+"\nYou cannot Assign this lecture to this teacher.");
                    saturday12.ResetText();
                }
                
                
            }
           
        }

        private void saturday22_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + saturday22.Text + "' and day = '6' and bshift = '" + shift + "' and lect='1'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    saturday22.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\n branch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    saturday22.ResetText();
                }
                

            }
        }

        private void saturday32_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + saturday32.Text + "' and day = '6' and bshift = '" + shift + "' and lect='1'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    saturday32.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\n branch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    saturday32.ResetText();
                }


            }
        }

        private void saturday42_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + saturday42.Text + "' and day = '6' and bshift = '" + shift + "' and lect='1'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    saturday42.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\n branch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    saturday42.ResetText();
                }


            }
        }

        private void saturday52_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + saturday52.Text + "' and day = '6' and bshift = '" + shift + "' and lect='1'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    saturday52.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\n branch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    saturday52.ResetText();
                }


            }
        }

        private void saturday62_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + saturday62.Text + "' and day = '6' and bshift = '" + shift + "' and lect='1'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    saturday62.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\n branch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    saturday62.ResetText();
                }


            }
        }

        private void friday12_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + friday12.Text + "' and day = '5' and bshift = '" + shift + "' and lect='1'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    friday12.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\n branch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    friday12.ResetText();
                }


            }
        }

        private void friday22_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + friday22.Text + "' and day = '5' and bshift = '" + shift + "' and lect='1'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    friday22.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\n branch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    friday22.ResetText();
                }


            }
        }

        private void friday32_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + friday32.Text + "' and day = '5' and bshift = '" + shift + "' and lect='1'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    friday32.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\n branch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    friday32.ResetText();
                }


            }
        }

        private void friday42_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + friday42.Text + "' and day = '5' and bshift = '" + shift + "' and lect='1'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    friday42.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\n branch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    friday42.ResetText();
                }


            }
        }

        private void friday52_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + friday52.Text + "' and day = '5' and bshift = '" + shift + "' and lect='1'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    friday52.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\n branch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    friday52.ResetText();
                }


            }
        }

        private void friday62_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + friday62.Text + "' and day = '5' and bshift = '" + shift + "' and lect='1'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    friday62.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\n branch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    friday62.ResetText();
                }


            }
        }

        private void thursday12_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + thursday12.Text + "' and day = '4' and bshift = '" + shift + "' and lect='1'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    thursday12.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    thursday12.ResetText();
                }


            }
        }

        private void thursday22_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + thursday22.Text + "' and day = '4' and bshift = '" + shift + "' and lect='2'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    thursday22.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    thursday22.ResetText();
                }


            }
        }

        private void thursday32_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + thursday32.Text + "' and day = '4' and bshift = '" + shift + "' and lect='3'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    thursday32.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    thursday32.ResetText();
                }


            }
        }

        private void thursday42_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + thursday42.Text + "' and day = '4' and bshift = '" + shift + "' and lect='4'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    thursday42.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    thursday42.ResetText();
                }


            }
        }

        private void thursday52_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + thursday52.Text + "' and day = '4' and bshift = '" + shift + "' and lect='5'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    thursday52.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    thursday52.ResetText();
                }


            }
        }

        private void thursday62_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + thursday62.Text + "' and day = '4' and bshift = '" + shift + "' and lect='6'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    thursday62.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    thursday62.ResetText();
                }


            }
        }

        private void wednesday12_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + wednesday12.Text + "' and day = '3' and bshift = '" + shift + "' and lect='1'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    wednesday12.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    wednesday12.ResetText();
                }


            }
        }

        private void wednesday22_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + wednesday22.Text + "' and day = '3' and bshift = '" + shift + "' and lect='2'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    wednesday22.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    wednesday22.ResetText();
                }


            }
        }

        private void wednesday32_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + wednesday32.Text + "' and day = '3' and bshift = '" + shift + "' and lect='3'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    wednesday32.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    wednesday32.ResetText();
                }


            }
        }

        private void wednesday42_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + wednesday42.Text + "' and day = '3' and bshift = '" + shift + "' and lect='4'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    wednesday42.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    wednesday42.ResetText();
                }


            }
        }

        private void wednesday52_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + wednesday52.Text + "' and day = '3' and bshift = '" + shift + "' and lect='5'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    wednesday52.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    wednesday52.ResetText();
                }


            }
        }

        private void wednesday62_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + wednesday62.Text + "' and day = '3' and bshift = '" + shift + "' and lect='6'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    wednesday62.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    wednesday62.ResetText();
                }


            }
        }

        private void tuesday12_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + tuesday12.Text + "' and day = '2' and bshift = '" + shift + "' and lect='1'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    tuesday12.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    tuesday12.ResetText();
                }


            }
        }

        private void tuesday22_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + tuesday22.Text + "' and day = '2' and bshift = '" + shift + "' and lect='2'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    tuesday22.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    tuesday22.ResetText();
                }


            }
        }

        private void tuesday32_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + tuesday32.Text + "' and day = '2' and bshift = '" + shift + "' and lect='3'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    tuesday32.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    tuesday32.ResetText();
                }


            }
        }

        private void tuesday42_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + tuesday42.Text + "' and day = '2' and bshift = '" + shift + "' and lect='4'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    tuesday42.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    tuesday42.ResetText();
                }


            }
        }

        private void tuesday52_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + tuesday52.Text + "' and day = '2' and bshift = '" + shift + "' and lect='5'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    tuesday52.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    tuesday52.ResetText();
                }


            }
        }

        private void tuesday62_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + tuesday62.Text + "' and day = '2' and bshift = '" + shift + "' and lect='6'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    tuesday62.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    tuesday62.ResetText();
                }


            }
        }

        private void monday12_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + monday12.Text + "' and day = '1' and bshift = '" + shift + "' and lect='1'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    monday12.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    monday12.ResetText();
                }


            }
        }

        private void monday22_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + monday22.Text + "' and day = '1' and bshift = '" + shift + "' and lect='2'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    monday22.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    monday22.ResetText();
                }


            }
        }

        private void monday32_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + monday32.Text + "' and day = '1' and bshift = '" + shift + "' and lect='3'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    monday32.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    monday32.ResetText();
                }


            }
        }

        private void monday42_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + monday42.Text + "' and day = '1' and bshift = '" + shift + "' and lect='4'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    monday42.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    monday42.ResetText();
                }


            }
        }

        private void monday52_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + monday52.Text + "' and day = '1' and bshift = '" + shift + "' and lect='5'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    monday52.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    monday52.ResetText();
                }


            }
        }

        private void monday62_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDbCon md = new MyDbCon();
            string sql = "select * from timetable where tid = '" + monday62.Text + "' and day = '1' and bshift = '" + shift + "' and lect='6'";
            MySqlDataReader rd = md.selectRow(sql);
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    monday62.Text = "";
                    MessageBox.Show("This Teacher is busy in this lecture at\nBranch= " + rd.GetString(1) + ", \nYear = " + rd.GetString(6) + ", \nshift = " + rd.GetString(7) + " on subject = " + rd.GetString(4) + "\nYou cannot Assign this lecture to this teacher.");
                    monday62.ResetText();
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (monday11.Text.Length == 0 || monday12.Text.Length == 0) 
            {
                MessageBox.Show("Lecture 1 On Monday is Empty!!");
            }
            else if (monday21.Text.Length == 0 || monday22.Text.Length == 0)
            {
                MessageBox.Show("Lecture 2 On Monday is Empty!!");
            }
            else if (monday31.Text.Length == 0 || monday32.Text.Length == 0)
            {
                MessageBox.Show("Lecture 3 On Monday is Empty!!");
            }
            else if (monday41.Text.Length == 0 || monday42.Text.Length == 0)
            {
                MessageBox.Show("Lecture 4 On Monday is Empty!!");
            }
            else if (monday51.Text.Length == 0 || monday52.Text.Length == 0)
            {
                MessageBox.Show("Lecture 5 On Monday is Empty!!");
            }
            else if (monday61.Text.Length == 0 || monday62.Text.Length == 0)
            {
                MessageBox.Show("Lecture 6 On Monday is Empty!!");
            }
            //tuesday...
            else if (tuesday11.Text.Length == 0 || tuesday12.Text.Length == 0)
            {
                MessageBox.Show("Lecture 1 On Tuesday is Empty!!");
            }
            else if (tuesday11.Text.Length == 0 || tuesday12.Text.Length == 0)
            {
                MessageBox.Show("Lecture 1 On Tuesday is Empty!!");
            }
            else if (tuesday21.Text.Length == 0 || tuesday22.Text.Length == 0)
            {
                MessageBox.Show("Lecture 2 On Tuesday is Empty!!");
            }
            else if (tuesday31.Text.Length == 0 || tuesday32.Text.Length == 0)
            {
                MessageBox.Show("Lecture 3 On Tuesday is Empty!!");
            }
            else if (tuesday41.Text.Length == 0 || tuesday42.Text.Length == 0)
            {
                MessageBox.Show("Lecture 4 On Tuesday is Empty!!");
            }
            else if (tuesday51.Text.Length == 0 || tuesday52.Text.Length == 0)
            {
                MessageBox.Show("Lecture 5 On Tuesday is Empty!!");
            }
            //wednesday...
            else if (wednesday11.Text.Length == 0 || wednesday12.Text.Length==0)
            {
                MessageBox.Show("Lecture 1 On Wednesday is Empty!!");
            }
            else if (wednesday21.Text.Length == 0 || wednesday22.Text.Length == 0)
            {
                MessageBox.Show("Lecture 2 On Wednesday is Empty!!");
            }
            else if (wednesday31.Text.Length == 0 || wednesday32.Text.Length == 0)
            {
                MessageBox.Show("Lecture 3 On Wednesday is Empty!!");
            }
            else if (wednesday41.Text.Length == 0 || wednesday42.Text.Length == 0)
            {
                MessageBox.Show("Lecture 4 On Wednesday is Empty!!");
            }
            else if (wednesday51.Text.Length == 0 || wednesday52.Text.Length == 0)
            {
                MessageBox.Show("Lecture 5 On Wednesday is Empty!!");
            }
            //thursday...
            else if (thursday11.Text.Length == 0 || thursday12.Text.Length == 0)
            {
                MessageBox.Show("Lecture 1 On Thursday is Empty!!");
            }
            else if (thursday21.Text.Length == 0 || thursday22.Text.Length == 0)
            {
                MessageBox.Show("Lecture 2 On Thursday is Empty!!");
            }
            else if (thursday31.Text.Length == 0 || thursday32.Text.Length == 0)
            {
                MessageBox.Show("Lecture 3 On Thursday is Empty!!");
            }
            else if (thursday41.Text.Length == 0 || thursday42.Text.Length == 0)
            {
                MessageBox.Show("Lecture 4 On Thursday is Empty!!");
            }
            else if (thursday51.Text.Length == 0 || thursday52.Text.Length == 0)
            {
                MessageBox.Show("Lecture 5 On Thursday is Empty!!");
            }
            else if (thursday61.Text.Length == 0 || thursday62.Text.Length == 0)
            {
                MessageBox.Show("Lecture 6 On Thursday is Empty!!");
            }
            //friday...
            else if (friday11.Text.Length == 0 || friday12.Text.Length == 0)
            {
                MessageBox.Show("Lecture 1 On Friday is Empty!!");
            }
            else if (friday21.Text.Length == 0 || friday22.Text.Length == 0)
            {
                MessageBox.Show("Lecture 2 On Friday is Empty!!");
            }
            else if (friday31.Text.Length == 0 || friday32.Text.Length == 0)
            {
                MessageBox.Show("Lecture 3 On Friday is Empty!!");
            }
            else if (friday41.Text.Length == 0 || friday42.Text.Length == 0)
            {
                MessageBox.Show("Lecture 4 On Friday is Empty!!");
            }
            else if (friday51.Text.Length == 0 || friday52.Text.Length == 0)
            {
                MessageBox.Show("Lecture 5 On Friday is Empty!!");
            }
            else if (friday61.Text.Length == 0 || friday62.Text.Length == 0)
            {
                MessageBox.Show("Lecture 6 On Friday is Empty!!");
            }
            //saturday...
            else if (saturday11.Text.Length == 0 || saturday12.Text.Length == 0)
            {
                MessageBox.Show("Lecture 1 On Saturday is Empty!!");
            }
            else if (saturday21.Text.Length == 0 || saturday22.Text.Length == 0)
            {
                MessageBox.Show("Lecture 2 On Saturday is Empty!!");
            }
            else if (saturday31.Text.Length == 0 || saturday32.Text.Length == 0)
            {
                MessageBox.Show("Lecture 3 On Saturday is Empty!!");
            }
            else if (saturday41.Text.Length == 0 || saturday42.Text.Length == 0)
            {
                MessageBox.Show("Lecture 4 On Saturday is Empty!!");
            }
            else if (saturday51.Text.Length == 0 || saturday52.Text.Length == 0)
            {
                MessageBox.Show("Lecture 5 On Saturday is Empty!!");
            }
            else if (saturday61.Text.Length == 0 || saturday62.Text.Length == 0)
            {
                MessageBox.Show("Lecture 6 On Saturday is Empty!!");
            }
            else
            {
                String sql = "INSERT INTO `timetable`(`bcode`, `day`, `lect`, `scode`, `tid`, `years`, `bshift`) VALUES "
                    + "('" + branch + "','1','1','" + monday11.Text + "','" + monday12.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','1','2','" + monday21.Text + "','" + monday22.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','1','3','" + monday31.Text + "','" + monday32.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','1','4','" + monday41.Text + "','" + monday42.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','1','5','" + monday51.Text + "','" + monday52.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','1','6','" + monday61.Text + "','" + monday62.Text + "','" + year + "','" + shift + "'),"
                    
                    + "('" + branch + "','2','1','" + tuesday11.Text + "','" + tuesday12.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','2','2','" + tuesday21.Text + "','" + tuesday22.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','2','3','" + tuesday31.Text + "','" + tuesday32.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','2','4','" + tuesday41.Text + "','" + tuesday42.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','2','5','" + tuesday51.Text + "','" + tuesday52.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','2','6','" + tuesday61.Text + "','" + tuesday62.Text + "','" + year + "','" + shift + "'),"
                    
                    + "('" + branch + "','3','1','" + wednesday11.Text + "','" + wednesday12.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','3','2','" + wednesday21.Text + "','" + wednesday22.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','3','3','" + wednesday31.Text + "','" + wednesday32.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','3','4','" + wednesday41.Text + "','" + wednesday42.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','3','5','" + wednesday51.Text + "','" + wednesday52.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','3','6','" + wednesday61.Text + "','" + wednesday62.Text + "','" + year + "','" + shift + "'),"
                    
                    + "('" + branch + "','4','1','" + thursday11.Text + "','" + thursday12.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','4','2','" + thursday21.Text + "','" + thursday22.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','4','3','" + thursday31.Text + "','" + thursday32.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','4','4','" + thursday41.Text + "','" + thursday42.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','4','5','" + thursday51.Text + "','" + thursday52.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','4','6','" + thursday61.Text + "','" + thursday62.Text + "','" + year + "','" + shift + "'),"
                    
                    + "('" + branch + "','5','1','" + friday11.Text + "','" + friday12.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','5','2','" + friday21.Text + "','" + friday22.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','5','3','" + friday31.Text + "','" + friday32.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','5','4','" + friday41.Text + "','" + friday42.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','5','5','" + friday51.Text + "','" + friday52.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','5','6','" + friday61.Text + "','" + friday62.Text + "','" + year + "','" + shift + "'),"
                    
                    + "('" + branch + "','6','1','" + saturday11.Text + "','" + saturday12.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','6','2','" + saturday21.Text + "','" + saturday22.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','6','3','" + saturday31.Text + "','" + saturday32.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','6','4','" + saturday41.Text + "','" + saturday42.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','6','5','" + saturday51.Text + "','" + saturday52.Text + "','" + year + "','" + shift + "'),"
                    + "('" + branch + "','6','6','" + saturday61.Text + "','" + saturday62.Text + "','" + year + "','" + shift + "')";

                MyDbCon md = new MyDbCon();
                if (md.runQuery(sql))
                {
                    this.Close();
                    MessageBox.Show("Added Successfully!!");
                }
                else
                {
                    MessageBox.Show("Failed !!");
                }
            }




        }
    }
}
