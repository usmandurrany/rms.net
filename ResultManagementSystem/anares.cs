using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ResultManagementSystem
{
    public partial class frmanares : Form
    {
        public frmanares(string[] prams)
        {
            InitializeComponent();
            var cmd = new MySqlCommand();
            cmd.Connection = database.conn;
            int maxth = 0;
            int maxlab = 0;
            cmd.CommandText = "SELECT AVG(total), Count(seatno), max_th, max_lab FROM result WHERE result.c_no ='" +
                              prams[0] + "' AND result.section = '" + prams[1] + "' AND result.year = '" + prams[2] +
                              "'";
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                totstu.Text = myReader[1].ToString();
                avgmarks.Text = myReader[0].ToString();
                maxth = int.Parse(myReader[2].ToString());
                maxlab = int.Parse(myReader[3].ToString());
            }
            myReader.Close();
            cmd.CommandText = "SELECT COUNT(total) FROM result WHERE total >= '50' AND result.c_no ='" + prams[0] +
                              "' AND result.section = '" + prams[1] + "' AND result.year = '" + prams[2] + "'";

            stupass.Text = cmd.ExecuteScalar().ToString();

            cmd.CommandText = "SELECT COUNT(total) FROM result WHERE total < '50' AND result.c_no ='" + prams[0] +
                              "' AND result.section = '" + prams[1] + "' AND result.year = '" + prams[2] + "'";

            stufail.Text = cmd.ExecuteScalar().ToString();


            cmd.CommandText = "SELECT COUNT(obt_th) FROM result WHERE obt_th >= '" + (maxth/2) + "' AND result.c_no ='" +
                              prams[0] + "' AND result.section = '" + prams[1] + "' AND result.year = '" + prams[2] +
                              "'";
            passth.Text = cmd.ExecuteScalar().ToString();


            cmd.CommandText = "SELECT COUNT(obt_th) FROM result WHERE obt_th < '" + (maxth/2) + "' AND result.c_no ='" +
                              prams[0] + "' AND result.section = '" + prams[1] + "' AND result.year = '" + prams[2] +
                              "'";
            failth.Text = cmd.ExecuteScalar().ToString();

            cmd.CommandText = "SELECT COUNT(obt_lab) FROM result WHERE obt_th >= '" + (maxlab/2) +
                              "' AND result.c_no ='" + prams[0] + "' AND result.section = '" + prams[1] +
                              "' AND result.year = '" + prams[2] + "'";
            passlab.Text = cmd.ExecuteScalar().ToString();

            cmd.CommandText = "SELECT COUNT(obt_lab) FROM result WHERE obt_th < '" + (maxlab/2) + "' AND result.c_no ='" +
                              prams[0] + "' AND result.section = '" + prams[1] + "' AND result.year = '" + prams[2] +
                              "'";
            faillab.Text = cmd.ExecuteScalar().ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmanares_Load(object sender, EventArgs e)
        {
            Location = new Point(307, 0);
        }
    }
}