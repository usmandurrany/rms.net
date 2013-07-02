using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ResultManagementSystem
{
    public partial class frmgpcalc : Form
    {
        private readonly string seatno;

        public frmgpcalc(string sno)
        {
            InitializeComponent();
            seatno = sno;
        }

        private void gpacalc_Load(object sender, EventArgs e)
        {
            Location = new Point(307, 0);
        }

        private void calc_Click(object sender, EventArgs e)
        {
            int marks = 0;
            int tot_marks = 0;
            int numres = 0;
            var cmd = new MySqlCommand();
            cmd.Connection = database.conn;
            cmd.CommandText = "SELECT SUM(total),SUM(max_th),SUM(max_lab),COUNT(total) FROM result WHERE seatno = '" +
                              seatno + "' AND semester ='" + semes.Text + "'";

            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {


                while (reader.Read())
                {
                    marks = Convert.ToInt32(reader[0]);
                    tot_marks = Convert.ToInt32(reader[1]) + Convert.ToInt32(reader[2]);
                    numres = Convert.ToInt32(reader[3]);
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("No results available for the selected semester", "Not Found", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }    
            reader.Close();

            totpap.Text = numres.ToString();

            double percentage = marks/(double) tot_marks;
            percentage = percentage*100;
            if (percentage <= 40)
                calgpa.Text = "N/A";
            if (percentage > 40)
            {
                if ((percentage > 49) && (percentage < 53))
                    calgpa.Text = "1.0 / D";
                if ((percentage > 52) && (percentage < 57))
                    calgpa.Text = "1.4 / D";
                if ((percentage > 56) && (percentage < 61))
                    calgpa.Text = "1.8 / C-";
                if ((percentage > 60) && (percentage < 64))
                    calgpa.Text = "2.0 / C";
                if ((percentage > 63) && (percentage < 68))
                    calgpa.Text = "2.4 / C+";
                if ((percentage > 67) && (percentage < 71))
                    calgpa.Text = "2.8 / B-";
                if ((percentage > 70) && (percentage < 75))
                    calgpa.Text = "3.0 / B";
                if ((percentage > 74) && (percentage < 80))
                    calgpa.Text = "3.4 / B+";
                if ((percentage > 79) && (percentage < 85))
                    calgpa.Text = "3.8 / A-";
                if ((percentage > 84) && (percentage < 90))
                    calgpa.Text = "4.0 / A";
                if (percentage > 89)
                    calgpa.Text = "4.0 / A+";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}