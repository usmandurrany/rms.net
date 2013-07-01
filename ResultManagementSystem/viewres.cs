using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ResultManagementSystem
{
    public partial class frmviewres : Form
    {
        private string course;
        //private string semester;
        private MySqlDataAdapter da;
        private DataTable dt;
        private string section;
        private string year;

        public frmviewres()
        {
            InitializeComponent();
            //viewres.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //viewres.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            //viewres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //viewres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmviewres_Load(object sender, EventArgs e)
        {
            //da = new MySqlDataAdapter();
            //dt = new DataTable();
            //database.cmd.CommandText =
            //    ;
            //database.cmd.Connection = database.conn;
            //da.SelectCommand = database.cmd;
           dt = database.dt_query("SELECT result.*, student.seatno, student.s_name FROM result LEFT JOIN student on result.seatno = student.seatno WHERE result.c_no ='" +
                course + "' AND result.section = '" + section + "' AND result.year = '" + year + "'");
           viewres.DataSource = dt;
            viewres.Columns[0].Visible = false;
            viewres.Columns[1].HeaderText = "Seat #";
            viewres.Columns[2].HeaderText = "Course #";
            viewres.Columns[3].HeaderText = "Max Marks(TH)";
            viewres.Columns[4].HeaderText = "Obtained Marks(TH)";
            viewres.Columns[5].HeaderText = "Max Marks(LB)";
            viewres.Columns[6].HeaderText = "Obtained Marks(LB)";
            viewres.Columns[7].HeaderText = "Total";
            viewres.Columns[8].HeaderText = "TeacherID";
            viewres.Columns[9].HeaderText = "Section";
            viewres.Columns[10].HeaderText = "Year";
            viewres.Columns[11].HeaderText = "Semester";

            viewres.Columns[8].Visible = false;
            viewres.Columns[9].Visible = false;
            viewres.Columns[10].Visible = false;
            viewres.Columns[11].Visible = false;
            viewres.Columns[12].Visible = false;

            viewres.Columns[13].HeaderText = "Students Name";
            viewres.Columns[13].DisplayIndex = 2;
            viewres.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            Width = (MdiParent.Width - 311);
            Height = (MdiParent.Height - 15);
            Text = "Result of ";
            Text += course;
        }

        public void getresult(string course, string section, string year)
        {
            this.course = course;
            this.section = section;

            this.year = year;

            // this.semester =semester;
        }


        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //MySqlCommand cmd= new MySqlCommand();
            //cmd.CommandText = "SELECT result.*, student.seatno, student.s_name, FROM result LEFT JOIN student on result.seatno = student.seatno WHERE result.seatno LIKE '%" + txtsearch.Text + "%' AND result.c_no ='" + course + "'";
            //cmd.Connection= database.conn;
            //MySqlDataAdapter da = new MySqlDataAdapter();
            //DataTable dt = new DataTable();
            //da.SelectCommand = cmd;
            //da.Fill(dt);
            ((DataTable) viewres.DataSource).DefaultView.RowFilter = string.Format("seatno LIKE '%{0}%'",
                                                                                    txtsearch.Text);

            viewres.DataSource = dt;
            viewres.Columns[0].Visible = false;
            viewres.Columns[1].HeaderText = "Seat #";
            viewres.Columns[2].HeaderText = "Course #";
            viewres.Columns[3].HeaderText = "Max Marks(TH)";
            viewres.Columns[4].HeaderText = "Obtained Marks(TH)";
            viewres.Columns[5].HeaderText = "Max Marks(LB)";
            viewres.Columns[6].HeaderText = "Obtained Marks(LB)";
            viewres.Columns[7].HeaderText = "Total";
            viewres.Columns[8].HeaderText = "TeacherID";
            viewres.Columns[8].Visible = false;
            viewres.Columns[9].Visible = false;
            viewres.Columns[10].HeaderText = "Students Name";
            viewres.Columns[10].DisplayIndex = 2;
            viewres.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //MySqlDataReader reader = database.cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    reslist.Items.Add(reader[2]);
            //    reslist.Update();

            //}
            //reader.Close();
        }

        private void mnusearch_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void mnuprint_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT t_name FROM faculty WHERE tid = '" + dt.Rows[0]["t_id"] + "'";
            // MySqlDataReader reader = new MySqlDataReader();
            cmd.Connection = database.conn;
            string tname = cmd.ExecuteScalar().ToString();
            //reader.Read();

            var rptview = new frmrptview(dt, tname);
            rptview.Show();
        }

        private void mnuanares_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "frmanares")
                    Application.OpenForms[i].Close();
            }
            string[] prams = {course, section, year};
            var anares = new frmanares(prams);
            anares.MdiParent = MdiParent;
            anares.Show();
        }

        private void mnuedit_Click(object sender, EventArgs e)
        {
            viewres.ReadOnly = false;
            mnusave.Enabled = true;
            mnuedit.Enabled = false;
        }

        private void mnusave_Click(object sender, EventArgs e)
        {
            //MySqlDataAdapter da = new MySqlDataAdapter();
            mnusave.Enabled = false;
            mnuedit.Enabled = true;
            da.UpdateCommand =
                new MySqlCommand(
                    "UPDATE result SET seatno=@seatno, max_th=@max_th, obt_th=@obt_th, max_lab=@max_lab, obt_lab=@obt_lab, total=@total WHERE id= @id",
                    database.conn);
            da.UpdateCommand.Parameters.Add("@seatno", MySqlDbType.VarChar, 50, "seatno");
            da.UpdateCommand.Parameters.Add("@max_th", MySqlDbType.Int16, 3, "max_th");
            da.UpdateCommand.Parameters.Add("@obt_th", MySqlDbType.Int16, 3, "obt_th");
            da.UpdateCommand.Parameters.Add("@max_lab", MySqlDbType.Int16, 3, "max_lab");
            da.UpdateCommand.Parameters.Add("@obt_lab", MySqlDbType.Int16, 3, "obt_lab");
            da.UpdateCommand.Parameters.Add("@total", MySqlDbType.VarChar, 50, "total");
            da.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int16, 11, "id");
            da.Update(dt);
        }
    }
}