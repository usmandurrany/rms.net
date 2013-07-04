using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ResultManagementSystem
{
    public partial class frmsearch : Form
    {
        public frmsearch()
        {
            InitializeComponent();
            searchas.SelectedItem = searchas.Items[0];
            fsearchas.SelectedItem = searchas.Items[1];

            AcceptButton = button1;
            AcceptButton = button4;
        }

        private void frmsearch_Load(object sender, EventArgs e)
        {
            Location = new Point(307, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string column = "";

            if (searchas.Text == "Student Name")
                column = "s_name";
            if (searchas.Text == "Father Name")
                column = "f_name";
            if (searchas.Text == "Year of Enrolment")
                column = "yoe";
            if (searchas.Text == "Field")
                column = "field";
            if (searchas.Text == "Semester")
                column = "semester";
            if (searchas.Text == "Section")
                column = "sec";

            var resview = new frmdgview(database.dt_query("SELECT * FROM student WHERE " + column + " LIKE '%" + searchstr.Text + "%'"));
            resview.MdiParent = MdiParent;


            resview.Show();
        }

        private void searchstu_Click(object sender, EventArgs e)
        {
        }

        private void searchas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string column = "";

            if (fsearchas.Text == "Teacher ID")
                column = "tid";
            if (fsearchas.Text == "Teacher Name")
                column = "t_name";
            if (fsearchas.Text == "Faculty of")
                column = "f_of";
            if (fsearchas.Text == "Qualification")
                column = "qualification";
            if (fsearchas.Text == "Email")
                column = "email";
            var resview = new frmdgview(database.dt_query("SELECT * FROM faculty WHERE " + column + " LIKE '%" + searchstrf.Text + "%'"), "faculty");
            resview.MdiParent = MdiParent;


            resview.Show();
        }

        private void searchfac_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchstr_TextChanged(object sender, EventArgs e)
        {
        }
    }
}