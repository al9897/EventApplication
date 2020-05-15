using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace ProPApplication
{
    //static so dont have to create object for this
    public static class DBConnection
    {
        public static string connectionInfo = "server=studmysql01.fhict.local;database=dbi334234;userId=dbi334234;password=abcdef;SSL mode = none; convert zero datetime = true";
      

        //execute count(*), max,...
        public static decimal ExecuteScalar(string sql)
        {
            decimal i = -1;
            using(MySqlConnection connection = new MySqlConnection(connectionInfo))
            {
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                if(command.ExecuteScalar() != System.DBNull.Value)
                {
                    i = Convert.ToDecimal(command.ExecuteScalar());
                }
            }
            return i;
        }
        //update, insert,...
        public static int ExecuteNonQuery(string sql)
        {
            int nrOfRecordAffected = -1;
            using(MySqlConnection connection = new MySqlConnection(connectionInfo))
            {
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                nrOfRecordAffected = command.ExecuteNonQuery();
            }
            return nrOfRecordAffected;
        }
        // query with unknown number of rows 1st parameter count number of line in the query, 2nd is the main query, 3rd is the number of column
        public static string[,] ExecuteQuery(string sql1, string sql2, int column)
        {
            string[,] result = null;
            int y = 0;
            int i = Convert.ToInt32(ExecuteScalar(sql1));
            using (MySqlConnection connection = new MySqlConnection(connectionInfo))
            {
                MySqlCommand command = new MySqlCommand(sql2, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    result = new string[i, column];
                    while (reader.Read())
                    {
                        for (int x = 0; x < column; x++)
                        {
                            result[y, x] = Convert.ToString(reader[x]);
                        }
                        y++;
                    }
                    reader.Close();
                }
            }
            return result;
        }
        // query with known number of rows(the same with the above method but specify the number of row in the 1st parameter)
        public static string[,] ExecuteQuery1(int i, string sql2, int column)
        {
            string[,] result = null;
            int y = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionInfo))
            {
                MySqlCommand command = new MySqlCommand(sql2, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    result = new string[i, column];
                    while (reader.Read())
                    {
                        for (int x = 0; x < column; x++)
                        {
                            result[y, x] = Convert.ToString(reader[x]);
                        }
                        y++;
                    }
                    reader.Close();
                }
            }
            return result;
        }

        //Show Quantity
        //update both tab page
        //ignore the 2 method below
        public static void UpdateLabel2(TabPage tabPage1, TabPage tabPage2,List<Item> itemList)
        {
            Label label = null;
            Label label1 = null;
            for (int i = 1; i < 13; i++)
            {
                foreach (Item search in itemList)
                {
                    label = (Label)tabPage1.Controls[string.Format("label{0}", i)];
                    if (i < 7)
                    {
                        if (search.ItemNo == i)
                        {
                            label.Text = search.Quantity.ToString();
                            if (search.Quantity <= 5)
                            {
                                label.BackColor = Color.Red;
                            }
                        }
                    }
                    else
                    {
                        label1 = (Label)tabPage2.Controls[string.Format("label{0}", i)];
                        label1.Visible = true;
                        if (search.ItemNo == i)
                        {
                            label1.Text = search.Quantity.ToString();
                            if (search.Quantity <= 5)
                            {
                                label1.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }
        // update one tabpage
        public static void UpdateLabel1(Panel panel1, List<Item> itemList)
        {
            Label label = null;
            for (int i = 1; i < 13; i++)
            {
                foreach (Item search in itemList)
                {
                    label = (Label)panel1.Controls[string.Format("label{0}", i)];
                    if (i < 7)
                    {
                        if (search.ItemNo == i)
                        {
                            label.Text = search.Quantity.ToString();
                            if (search.Quantity <= 5)
                            {
                                label.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }

    }
}
