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
    public partial class SubAssignment : Form
    {
        public SubAssignment()
        {
            InitializeComponent();
        }
        //function to save a user
        public void listUser()
        {
            // Change the username, password and database according to your needs
            // You can ignore the database option if you want to access all of them.
            // 127.0.0.1 stands for localhost and the default port to connect.
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tt;";
            // Your query,
            string query = "select tchsub.scode, subject.sname, tchsub.tid,teacher.tname from tchsub inner JOIN subject on tchsub.scode=subject.scode inner join teacher on tchsub.tid = teacher.tid order by tchsub.scode asc";

            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            // Let's do it !
            try
            {
                // Open the database
                databaseConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                // All succesfully executed, now do something

                // IMPORTANT : 
                // If your query returns result, use the following processor :

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        // Do something with every received database ROW
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        Console.WriteLine("ROWS " + reader.GetString(1));
                        //var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(new ListViewItem(row));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                // Finally close the connection
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }

        }

        //code to insert a user into database
        public void SaveUser()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tt;";
            string query = "INSERT INTO tchsub VALUES ( '" + comboBox2.Text + "','" + comboBox1.Text + "')";
            // Which could be translated manually to :
            // INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'Bruce', 'Wayne', 'Wayne Manor')

            MySqlConnection con = new MySqlConnection(connectionString);

            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandTimeout = 60;

            try
            {
                con.Open();
                MySqlDataReader myReader = cmd.ExecuteReader();

                MessageBox.Show("Subject succesfully registered");

                con.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void SubAssignment_Load(object sender, EventArgs e)
        {
            MyDbCon mdb = new MyDbCon();
            String sql = "select * from teacher";
   
            MySqlDataReader reader = mdb.selectRow(sql);
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader.GetString(0));
                }
            }
            else
            {
                MessageBox.Show("There is no branch.");
            }
            sql = "select * from subject";
            MyDbCon md = new MyDbCon();
            MySqlDataReader reader2 = md.selectRow(sql);
            if (reader2.HasRows)
            {
                while (reader2.Read())
                {
                    comboBox1.Items.Add(reader2.GetString(0));
                }
            }
            listUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveUser();
            listView1.Items.Clear();
            listUser(); 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
