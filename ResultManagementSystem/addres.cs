using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ResultManagementSystem
{
    public partial class frmaddres : Form
    {
        private readonly string course;
        private readonly DataTable dt = new DataTable();
        private readonly string maxlab;
        private readonly string maxth;
        private readonly string seatend;
        private readonly string seatst;
        private readonly string seattype;
        private readonly string sec;
        private readonly string semes;
        private readonly string tid;
        private readonly string year;
        private string field;

        public frmaddres(params string[] values)
        {
            InitializeComponent();
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
        }


        private void Form1_Load(object sender, EventArgs e)
        {
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


            //addres.Columns[7].Visible = false;
            //addres.Columns[8].Visible = false;
            //viewres.Columns[9].Visible = false;
            //MySqlCommand cmd = new MySqlCommand();
            //cmd.CommandText = "SELECT seatno, s_name FROM student WHERE seatno BETWEEN '" + (seattype + seatno[0]) + "' AND '" + (seattype + seatno[1]) + "'";
            //cmd.Connection = database.conn;
            //MySqlDataReader reader = cmd.ExecuteReader();
            //List<string> s_name = new List<string>();
            //List<string> seat_no = new List<string>();

            //while (reader.Read())
            //{
            //    seat_no.ad
            //    s_name.Add(reader[1].ToString());
            //}
            //reader.Close();
            try
            {
                for (int i = 0; i <= (Convert.ToInt32(seatno[1]) - Convert.ToInt32(seatno[0])); i++)
                {
                    dt.Rows.Add(seattype + "" + (Convert.ToInt32(seatno[0]) + i), course, maxth, "0", maxlab, "0", "0",tid, sec, year, semes);
                }
            }
            catch (IndexOutOfRangeException)
            {
            }

            addres.DataSource = dt;
            addres.Columns[0].HeaderText = "Seat #";
            addres.Columns[1].HeaderText = "Course #";
            addres.Columns[2].HeaderText = "Max Marks (TH)";
            addres.Columns[3].HeaderText = "Obtained Marks (TH)";
            addres.Columns[4].HeaderText = "Max Marks (LAB)";
            addres.Columns[5].HeaderText = "Obatained Marks (LAB)";
            addres.Columns[6].HeaderText = "Total Marks (TH + LAB)";
            addres.Columns[7].HeaderText = "Teacher ID";
            addres.Columns[8].HeaderText = "Section";
            addres.Columns[9].HeaderText = "Year";
            addres.Columns[10].HeaderText = "Semester";

            addres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            addres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void mnuaddres_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void addres_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (addres.Columns[e.ColumnIndex].Index == 3 || addres.Columns[e.ColumnIndex].Index == 5)
                {
                    addres[6, e.RowIndex].Value = Convert.ToString(
                        Convert.ToInt32(addres[3, e.RowIndex].Value) +
                        Convert.ToInt32(addres[5, e.RowIndex].Value));
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void addres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}