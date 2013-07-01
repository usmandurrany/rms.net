using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ResultManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmmain());
        }
    }

    internal class common
    {
        public static frmmain main;
        public static frmsidebar sidebar;
        public static frmlogin login;
        public static MenuStrip mnubar;
        public static frmviewres viewres;
        public static string[] usr_details = new string[9];
    }

    internal class database
    {
        public static MySqlConnection conn;
        private static readonly MySqlConnectionStringBuilder conn_str;
        public static MySqlCommand cmd;
        public static MySqlDataAdapter da;
        public static DataTable dt;

        static database()
        {
            conn_str = new MySqlConnectionStringBuilder();
            conn_str.Add("Database", "ubit");
            conn_str.Add("Data Source", "localhost");
            conn_str.Add("User ID", "root");
            conn_str.Add("Password", "");
            conn = new MySqlConnection(conn_str.ConnectionString);
            try
            {
                conn.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Unable to connect to database");
            }
        }

        public static List<string> login_check(string loginas, string uid_type, string uid, string pass)
        {
            cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM " + loginas + " WHERE " + uid_type + " ='" + uid + "' AND password ='" +
                              pass + "'";
            var lst = new List<string>();

            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (loginas == "student")
                {
                    lst.Add(reader[0].ToString()); //0
                    lst.Add(reader[1].ToString()); //1
                    lst.Add(reader[2].ToString()); //2
                    lst.Add(reader["acc_lvl"].ToString()); //acc_lvl pos 3

                    lst.Add(reader[3].ToString()); //4

                    lst.Add(reader[4].ToString()); //5

                    lst.Add(reader[5].ToString()); //6
                    lst.Add(reader[6].ToString()); //7
                    lst.Add(reader[7].ToString()); //8
                    lst.Add(reader[8].ToString()); //9
                }
                if (loginas == "faculty")
                {
                    lst.Add(reader[0].ToString());
                    lst.Add(reader[1].ToString());
                    lst.Add(reader[2].ToString());
                    lst.Add(reader[3].ToString());
                    lst.Add(reader[4].ToString());
                    lst.Add(reader["acc_lvl"].ToString());
                }
            }
            reader.Close();
            return lst;
        }

        public static DataTable dt_query(string sql)
        {
            da = new MySqlDataAdapter();
            dt = new DataTable();
            cmd = new MySqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
    }
}