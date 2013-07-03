using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ResultManagementSystem
{
    public partial class frmdgview : Form
    {
        private string course;
        //private string semester;
        private MySqlDataAdapter da;
        private DataTable dt;
        private string section;
        private string year;
       // private readonly string course;
        //private readonly DataTable dt = new DataTable();
        private readonly string maxlab;
        private readonly string maxth;
        private readonly string seatend;
        private readonly string seatst;
        private readonly string seattype;
        private readonly string sec;
        private readonly string semes;
        private readonly string tid;
      //  private readonly string year;
        private string field;

        public frmdgview()
        { InitializeComponent(); }

        public frmdgview(params string[] values)
        {

            InitializeComponent();
            mnuanares.Visible = false;
            mnuedit.Visible = false;
            mnuprint.Visible = false;
            txtsearch.Visible = false;
            mnusave.Visible = false;
            mnucreate.Visible = true;
            mnucancel.Visible = true;
            dgview.ReadOnly = false;

            dt = new DataTable();
            this.tid = values[0];
            this.course = values[1];
            this.year = values[2];
            this.semes = values[3];
            this.field = values[4];
            this.sec = values[5];
            this.seattype = values[6];
            this.seatst = values[7];
            this.seatend = values[8];
            this.maxth = values[9];
            this.maxlab = values[10];

            var seatno = new string[2];
            seatno[0] = seatst;
            seatno[1] = seatend;


            Text = "New Result for " + course;
            dt.Columns.Add("seatno");
            dt.Columns.Add("c_no");
            dt.Columns.Add("max_th");
            dt.Columns.Add("obt_th");
            dt.Columns.Add("max_lab");
            dt.Columns.Add("obt_lab");
            dt.Columns.Add("total");
            dt.Columns.Add("t_id");
            dt.Columns.Add("section");
            dt.Columns.Add("year");
            dt.Columns.Add("semester");

            try
            {
                for (int i = 0; i <= (Convert.ToInt32(seatno[1]) - Convert.ToInt32(seatno[0])); i++)
                {
                    dt.Rows.Add(seattype + "" + (Convert.ToInt32(seatno[0]) + i), course, maxth, "0", maxlab, "0", "0", tid, sec, year, semes);
                }
            }
            catch (IndexOutOfRangeException)
            {
            }

            dgview.DataSource = dt;
            dgview.Columns[0].HeaderText = "Seat #";
            dgview.Columns[1].HeaderText = "Course #";
            dgview.Columns[2].HeaderText = "Max Marks (TH)";
            dgview.Columns[3].HeaderText = "Obtained Marks (TH)";
            dgview.Columns[4].HeaderText = "Max Marks (LAB)";
            dgview.Columns[5].HeaderText = "Obatained Marks (LAB)";
            dgview.Columns[6].HeaderText = "Total Marks (TH + LAB)";
            dgview.Columns[7].HeaderText = "Teacher ID";
            dgview.Columns[8].HeaderText = "Section";
            dgview.Columns[9].HeaderText = "Year";
            dgview.Columns[10].HeaderText = "Semester";

            dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public frmdgview(DataTable dt)
        {
            InitializeComponent();
            mnuanares.Visible = false;
            mnuedit.Visible = false;
            mnuprint.Visible = false;
            mnusearch.Visible = false;
            mnusave.Visible = false;
            mnucreate.Visible = false;
            mnucancel.Visible = false;
            dgview.DataSource = dt;
            dgview.Columns[0].HeaderText = "Seat #";
            dgview.Columns[1].HeaderText = "Student Name";
            dgview.Columns[2].HeaderText = "Father Name";
            dgview.Columns[3].HeaderText = "Date of Birth";
            dgview.Columns[4].HeaderText = "Field";
            dgview.Columns[5].HeaderText = "Section";
            dgview.Columns[6].HeaderText = "Semester";
            dgview.Columns[7].HeaderText = "Admission Date";
            dgview.Columns[8].Visible = false;
            dgview.Columns[9].Visible = false;

            dgview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public frmdgview(DataTable dt, string type)
        {
            InitializeComponent();
            mnuanares.Visible = false;
            mnuedit.Visible = false;
            mnuprint.Visible = false;
            mnusearch.Visible = false;
            mnusave.Visible = false;
            mnucreate.Visible = false;
            mnucancel.Visible = false;
            dgview.DataSource = dt;
            dgview.Columns[0].HeaderText = "Teacher ID";
            dgview.Columns[1].HeaderText = "Teacher Name";
            dgview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgview.Columns[2].HeaderText = "Email";
            dgview.Columns[3].HeaderText = "Qualification";
            dgview.Columns[4].HeaderText = "Faculty of";


            dgview.Columns[5].Visible = false;
            dgview.Columns[6].Visible = false;
        }

        public frmdgview(string course, string section, string year)
        {
            InitializeComponent();
            this.course = course;
            this.section = section;
            
            mnucreate.Visible = false;
            mnucancel.Visible = false;
            this.year = year;
            dt = database.dt_query("SELECT result.*, student.seatno, student.s_name FROM result LEFT JOIN student on result.seatno = student.seatno WHERE result.c_no ='" +
                course + "' AND result.section = '" + section + "' AND result.year = '" + year + "'");
            dgview.DataSource = dt;
            dgview.Columns[0].Visible = false;
            dgview.Columns[1].HeaderText = "Seat #";
            dgview.Columns[2].HeaderText = "Course #";
            dgview.Columns[3].HeaderText = "Max Marks(TH)";
            dgview.Columns[4].HeaderText = "Obtained Marks(TH)";
            dgview.Columns[5].HeaderText = "Max Marks(LB)";
            dgview.Columns[6].HeaderText = "Obtained Marks(LB)";
            dgview.Columns[7].HeaderText = "Total";
            dgview.Columns[8].HeaderText = "TeacherID";
            dgview.Columns[9].HeaderText = "Section";
            dgview.Columns[10].HeaderText = "Year";
            dgview.Columns[11].HeaderText = "Semester";

            dgview.Columns[8].Visible = false;
            dgview.Columns[9].Visible = false;
            dgview.Columns[10].Visible = false;
            dgview.Columns[11].Visible = false;
            dgview.Columns[12].Visible = false;

            dgview.Columns[13].HeaderText = "Students Name";
            dgview.Columns[13].DisplayIndex = 2;
            dgview.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

           
        }


        private void frmviewres_Load(object sender, EventArgs e)
        {
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

   
        }


        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

            ((DataTable) dgview.DataSource).DefaultView.RowFilter = string.Format("seatno LIKE '%{0}%'",
                                                                                    txtsearch.Text);

            dgview.DataSource = dt;
            dgview.Columns[0].Visible = false;
            dgview.Columns[1].HeaderText = "Seat #";
            dgview.Columns[2].HeaderText = "Course #";
            dgview.Columns[3].HeaderText = "Max Marks(TH)";
            dgview.Columns[4].HeaderText = "Obtained Marks(TH)";
            dgview.Columns[5].HeaderText = "Max Marks(LB)";
            dgview.Columns[6].HeaderText = "Obtained Marks(LB)";
            dgview.Columns[7].HeaderText = "Total";
            dgview.Columns[8].HeaderText = "TeacherID";
            dgview.Columns[8].Visible = false;
            dgview.Columns[9].Visible = false;
            dgview.Columns[10].HeaderText = "Students Name";
            dgview.Columns[10].DisplayIndex = 2;
            dgview.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void mnusearch_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void mnuprint_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT t_name FROM faculty WHERE tid = '" + dt.Rows[0]["t_id"] + "'";
            cmd.Connection = database.conn;
            string tname = cmd.ExecuteScalar().ToString();

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
            dgview.ReadOnly = false;
            mnusave.Enabled = true;
            mnuedit.Enabled = false;
        }

        private void mnusave_Click(object sender, EventArgs e)
        {
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

        private void mnucreate_Click(object sender, EventArgs e)
        {
            var da = new MySqlDataAdapter();

            da.InsertCommand =
                new MySqlCommand(
                    "INSERT INTO result(seatno, c_no, max_th, obt_th, max_lab, obt_lab, total, t_id, section, year, semester) VALUES(@seatno, @course_no, @max_th, @obt_th, @max_lab, @obt_lab, @total, @t_id, @section, @year, @semester);",
                    database.conn);
            da.InsertCommand.Parameters.Add("@seatno", MySqlDbType.VarChar, 50, "seatno");
            da.InsertCommand.Parameters.Add("@course_no", MySqlDbType.VarChar, 50, "c_no");
            da.InsertCommand.Parameters.Add("@max_th", MySqlDbType.Int16, 3, "max_th");
            da.InsertCommand.Parameters.Add("@obt_th", MySqlDbType.Int16, 3, "obt_th");
            da.InsertCommand.Parameters.Add("@max_lab", MySqlDbType.Int16, 3, "max_lab");
            da.InsertCommand.Parameters.Add("@obt_lab", MySqlDbType.Int16, 3, "obt_lab");
            da.InsertCommand.Parameters.Add("@total", MySqlDbType.VarChar, 50, "total");
            da.InsertCommand.Parameters.Add("@t_id", MySqlDbType.VarChar, 50, "t_id");
            da.InsertCommand.Parameters.Add("@section", MySqlDbType.VarChar, 50, "section");
            da.InsertCommand.Parameters.Add("@year", MySqlDbType.Int16, 11, "year");
            da.InsertCommand.Parameters.Add("@semester", MySqlDbType.Int16, 11, "semester");

            da.Update(dt);
            Close();
        }
        private void viewres_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgview.Columns[e.ColumnIndex].Index == 3 || dgview.Columns[e.ColumnIndex].Index == 5)
                {
                    dgview[6, e.RowIndex].Value = Convert.ToString(
                        Convert.ToInt32(dgview[3, e.RowIndex].Value) +
                        Convert.ToInt32(dgview[5, e.RowIndex].Value));
                }
            }
            catch (ArgumentOutOfRangeException)
            {
            }
            catch (FormatException)
            {
                MessageBox.Show("You have entered a value that is not allowed.\n Please enter an INTEGER value.",
                                "Invalid entry.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtsearch_Click(object sender, EventArgs e)
        {

        }

        private void mnucancel_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Are you sure you want to cancel the result?", "RMS", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Exclamation) == DialogResult.Yes)
                Close();
        }
    }
}