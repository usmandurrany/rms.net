using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ResultManagementSystem
{
    public partial class frmaddrc : Form
    {
        private string tid;
        private string tname;

        public frmaddrc()
        {
            InitializeComponent();
        }

        private void frmresdet_Load(object sender, EventArgs e)
        {
            Location = new Point(307, 0);
            //year.Value = DateTime.Today;
            year.Format = DateTimePickerFormat.Custom;
            year.CustomFormat = "yyyy";
            label1.Text = tname;
            //label1.Text += tid;
            var cmd = new MySqlCommand();
            cmd.CommandText = "SELECT c_no,c_name FROM course";
            cmd.Connection = database.conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                c_no.Items.Add(reader[0] + " " + reader[1]);
            }
            reader.Close();
            semes.SelectedItem = semes.Items[0];
            field.SelectedItem = field.Items[0];
            sec.SelectedItem = sec.Items[0];
            c_no.SelectedItem = c_no.Items[0];

        }

        public void GetTID(string tname, string id)
        {
            this.tname = tname;
            tid = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] course = c_no.SelectedItem.ToString().Split(' ');
            var viewres = new frmdgview(tid, course[0], year.Text, semes.Text, field.Text, sec.Text, seattype.Text,
                                       seatst.Text, seatend.Text, maxth.Text, maxlab.Text);
            viewres.MdiParent = MdiParent;
            viewres.Dock = DockStyle.Right;
            //viewres.Width = (MdiParent.Width - 315);
            //viewres.Height = (MdiParent.Height - 15);
            viewres.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void TabControl1_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                Height = 205;
            if (tabControl1.SelectedIndex == 0)
                Height = 319;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cmd = new MySqlCommand();

            cmd.Connection = database.conn;
            cmd.CommandText = "INSERT INTO course(c_no, c_name, c_hr, c_semester) VALUES('" + cno.Text + "', '" +
                              cname.Text + "', '" + chr.Text + "', '" + csemes.Text + "')";
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SystemException){}
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void seatst_TextChanged(object sender, EventArgs e)
        {
            seatend.Text = seatst.Text;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}