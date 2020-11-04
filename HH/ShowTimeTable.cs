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
    public partial class ShowTimeTable : Form
    {
        private int branch, year, shift;
        public string getShortName(int tid)
        {
            //string s;
            string sql = "select tshort from teacher where tid='" + tid + "'";
            MyDbCon md = new MyDbCon();
            MySqlDataReader rd =  md.selectRow(sql);
            if (rd.HasRows) {
                rd.Read();
                return rd.GetString(0);
            }
            return "NULL";
        }
        public ShowTimeTable(int branch, int year, int shift)
        {
            InitializeComponent();
            this.branch = branch;
            this.year = year;
            this.shift = shift;
        }

        private void ShowTimeTable_Load(object sender, EventArgs e)
        {
            label85.Text = "BRANCH CODE : " + branch;
            label86.Text = "YEAR : " + year;
            label87.Text = "SHIFT : " + shift;
            String sql = "select * from timetable where bcode='"+branch+"' and years='"+year+"' and bshift='"+shift+"' ";
            MyDbCon mdb = new MyDbCon();
            MySqlDataReader reader = mdb.selectRow(sql);
            if (reader.HasRows)
            {
                reader.Read();
                L11.Text = reader.GetString(4);
                T11.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L12.Text = reader.GetString(4);
                T12.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L13.Text = reader.GetString(4);
                T13.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L14.Text = reader.GetString(4);
                T14.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L15.Text = reader.GetString(4);
                T15.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L16.Text = reader.GetString(4);
                T16.Text = getShortName(int.Parse(reader.GetString(5)));

                reader.Read();
                L21.Text = reader.GetString(4);
                T21.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L22.Text = reader.GetString(4);
                T22.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L23.Text = reader.GetString(4);
                T23.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L24.Text = reader.GetString(4);
                T24.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L25.Text = reader.GetString(4);
                T25.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L26.Text = reader.GetString(4);
                T26.Text = getShortName(int.Parse(reader.GetString(5)));
                
                reader.Read();
                L31.Text = reader.GetString(4);
                T31.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L32.Text = reader.GetString(4);
                T32.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L33.Text = reader.GetString(4);
                T33.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L34.Text = reader.GetString(4);
                T34.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L35.Text = reader.GetString(4);
                T35.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L36.Text = reader.GetString(4);
                T36.Text = getShortName(int.Parse(reader.GetString(5)));

                reader.Read();
                L41.Text = reader.GetString(4);
                T41.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L42.Text = reader.GetString(4);
                T42.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L43.Text = reader.GetString(4);
                T43.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L44.Text = reader.GetString(4);
                T44.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L45.Text = reader.GetString(4);
                T45.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L46.Text = reader.GetString(4);
                T46.Text = getShortName(int.Parse(reader.GetString(5)));

                reader.Read();
                L51.Text = reader.GetString(4);
                T51.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L52.Text = reader.GetString(4);
                T52.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L53.Text = reader.GetString(4);
                T53.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L54.Text = reader.GetString(4);
                T54.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L55.Text = reader.GetString(4);
                T55.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L56.Text = reader.GetString(4);
                T56.Text = getShortName(int.Parse(reader.GetString(5)));


                reader.Read();
                L61.Text = reader.GetString(4);
                T61.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L62.Text = reader.GetString(4);
                T62.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L63.Text = reader.GetString(4);
                T63.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L64.Text = reader.GetString(4);
                T64.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L65.Text = reader.GetString(4);
                T65.Text = getShortName(int.Parse(reader.GetString(5)));
                reader.Read();
                L66.Text = reader.GetString(4);
                T66.Text = getShortName(int.Parse(reader.GetString(5)));



            }
            
        }
    }
}
