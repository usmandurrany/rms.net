using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ResultManagementSystem
{
    public partial class frmsidebar : Form
    {
        public frmsidebar()
        {
            InitializeComponent();
        }

        public void SetValues(List<string> details)
        {
            try
            {
                if (details[3] == "0")
                {
                    seatno.Text += details[0];
                    //fname.Text = details[1];
                    usrdetails.Text = details[1];
                    fthname.Text += details[2];
                    dob.Text += details[4];
                    field.Text += details[5];
                    sec.Text += details[6];
                    semes.Text += details[7];
                    yoe.Text += details[8]; // reader pos 7 list pos 8
                }
                if (details[5] == "1")
                {
                    field.Text = "E-Mail " + details[2];
                    //fname.Text = details[1];
                    usrdetails.Text = details[1];
                    fthname.Text = "Qualification " + details[3];
                    dob.Text = "Faculty of " + details[4];
                    seatno.Visible = false;
                    sec.Visible = false;
                    semes.Visible = false;
                    yoe.Visible = false; // reader pos 7 list pos 8
                }
            }
            catch
            {
                SystemException ex;
            }
        }

        private void frmsidebar_Load(object sender, EventArgs e)
        {
            database.cmd.CommandText =
                "SELECT DISTINCT least(result.c_no,result.c_no) as c_no, result.section, result.year, result.t_id, faculty.t_name, faculty.tid FROM result LEFT JOIN faculty on result.t_id = faculty.tid";
            MySqlDataReader reader = database.cmd.ExecuteReader();
            while (reader.Read())
            {
                reslist.Items.Add(reader["c_no"] + " Section " + reader["section"] + " " + reader["t_name"] + " " +
                                  reader["year"]);
            }
            reader.Close();
            if (MdiParent.MainMenuStrip.Items["mnuadd"].Visible)
                btngpa.Visible = false;
        }

        private void reslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int item = reslist.SelectedIndex;
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "frmviewres")
                    Application.OpenForms[i].Close();
            }
            if (item < 0)
                item = 0;
            string[] course = reslist.Items[item].ToString().Split(' ');
            var viewres = new frmviewres(course[0], course[2], course[4]);
            viewres.MdiParent = MdiParent;

            if (Application.OpenForms.Count == 2)
                viewres.Dock = DockStyle.Right;

            viewres.Width = (MdiParent.Width - 315);
            viewres.Height = (MdiParent.Height - 15);
            viewres.Show();
        }


        private void resfilter_TextChanged(object sender, EventArgs e)
        {
            reslist.Items.Clear();
            database.cmd.CommandText =
                "SELECT DISTINCT least(result.c_no,result.c_no) as c_no, result.section, result.year, result.t_id, faculty.t_name, faculty.tid FROM result LEFT JOIN faculty on result.t_id = faculty.tid WHERE result.c_no LIKE '%" +
                resfilter.Text + "%'";
            MySqlDataReader reader = database.cmd.ExecuteReader();
            while (reader.Read())
            {
                reslist.Items.Add(reader["c_no"] + " Section " + reader["section"] + " " + reader["t_name"] + " " +
                                  reader["year"]);
                reslist.Update();
            }
            reader.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reslist.Items.Clear();
            database.cmd.CommandText =
                "SELECT DISTINCT least(result.c_no,result.c_no) as c_no, result.section, result.year, result.t_id, faculty.t_name, faculty.tid FROM result LEFT JOIN faculty on result.t_id = faculty.tid";
            MySqlDataReader reader = database.cmd.ExecuteReader();
            while (reader.Read())
            {
                reslist.Items.Add(reader["c_no"] + " Section " + reader["section"] + " " + reader["t_name"] + " " +reader["year"]);
            }
            reader.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void reslist_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            var p = new Point(300, (Cursor.Position.Y - 405));
            var cmd = new MySqlCommand();
            int item = reslist.SelectedIndex;
            if (item >= 0)
            {
                string[] course = reslist.Items[item].ToString().Split(' ');
                cmd.Connection = database.conn;
                cmd.CommandText = "(Select c_name from course where c_no ='" + course[0] + "')";
                string c_name = cmd.ExecuteScalar().ToString();
                toolTip1.Show(c_name, reslist, p, 800);
            }
        }

        private void usrdetails_Enter_1(object sender, EventArgs e)
        {
        }

        private void btngpa_Click(object sender, EventArgs e)
        {
            var gpcalc = new frmgpcalc(seatno.Text);
            gpcalc.MdiParent = MdiParent;
            gpcalc.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
        }

        private void field_Click(object sender, EventArgs e)
        {
        }

        private void dob_Click(object sender, EventArgs e)
        {
        }

        private void sec_Click(object sender, EventArgs e)
        {
        }

        private void semes_Click(object sender, EventArgs e)
        {
        }

        private void yoe_Click(object sender, EventArgs e)
        {
        }

        private void fthname_Click(object sender, EventArgs e)
        {
        }

        private void seatno_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
        }
    }
}