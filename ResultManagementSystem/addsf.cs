using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ResultManagementSystem
{
    public partial class frmaddsf : Form
    {
        public frmaddsf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cmd = new MySqlCommand();

            cmd.Connection = database.conn;
            cmd.CommandText = "INSERT INTO student(seatno, s_name, f_name, dob, field, sec, semester, yoe) VALUES('" +txtseat.Text + "', '" + txtsname.Text + "', '" + txtfname.Text + "', '" + dobpick.Text +"', '" + txtfield.Text + "', '" + txtsec.Text + "', '" + txtcursem.Text + "', '" +yoepick.Text + "' )";
            cmd.ExecuteNonQuery();
        }

        private void frmaddstu_Load(object sender, EventArgs e)
        {
            Location = new Point(307, 0);
            yoepick.Format = DateTimePickerFormat.Custom;
            yoepick.CustomFormat = "yyyy";
            dobpick.Format = DateTimePickerFormat.Custom;
            dobpick.CustomFormat = "dd-MM-yyyy";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void TabControl1_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                Height = 185;
            if (tabControl1.SelectedIndex == 0)
                Height = 280;
        }

        private void yoepick_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cmd = new MySqlCommand();

            cmd.Connection = database.conn;
            cmd.CommandText = "INSERT INTO faculty(t_name, , email, qualification, f_off) VALUES('" + tname.Text +
                              "', '" + email.Text + "', '" + quali.Text + "', '" + fof.Text + "')";
            cmd.ExecuteNonQuery();
        }
    }
}