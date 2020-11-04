using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace HH
{
    class MyDbCon
    {
        private string connectionString;
        private MySqlConnection con;
        private MySqlDataReader reader;
        MySqlCommand cmd;
        public MyDbCon()
        {
            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tt;";
            con = new MySqlConnection(connectionString);
        }
        public MySqlDataReader selectRow(string query)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            //finally { con.Close(); }
            return reader;
        }
        public MySqlCommand makecmd(string query)
        {
            con.Open();
            cmd = new MySqlCommand(query, con);
            return cmd;
        }
        public Boolean runQuery(string query)
        {

            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { con.Close(); }
            return false;
        }
    }
}
