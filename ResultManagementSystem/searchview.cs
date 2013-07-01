using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ResultManagementSystem
{
    public partial class frmsearchview : Form
    {
        public frmsearchview(DataTable dt)
        {
            InitializeComponent();
            searchres.DataSource = dt;
            searchres.Columns[0].HeaderText = "Seat #";
            searchres.Columns[1].HeaderText = "Student Name";
            searchres.Columns[2].HeaderText = "Father Name";
            searchres.Columns[3].HeaderText = "Date of Birth";
            searchres.Columns[4].HeaderText = "Field";
            searchres.Columns[5].HeaderText = "Section";
            searchres.Columns[6].HeaderText = "Semester";
            searchres.Columns[7].HeaderText = "Admission Date";
            searchres.Columns[8].Visible = false;
            searchres.Columns[9].Visible = false;
            //earchres.Columns[10].HeaderText = "Students Name";
            //searchres.Columns[10].DisplayIndex = 2;
            searchres.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            searchres.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public frmsearchview(DataTable dt, string type)
        {
            InitializeComponent();
            searchres.DataSource = dt;
            searchres.Columns[0].HeaderText = "Teacher ID";
            searchres.Columns[1].HeaderText = "Teacher Name";
            searchres.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //searchres.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            searchres.Columns[2].HeaderText = "Email";
            searchres.Columns[3].HeaderText = "Qualification";
            searchres.Columns[4].HeaderText = "Faculty of";


            searchres.Columns[5].Visible = false;
            searchres.Columns[6].Visible = false;
        }

        private void frmsearchview_Load(object sender, EventArgs e)
        {
            MdiParent = common.main;
            Dock = DockStyle.Right;
            Location = new Point(307, 0);
            Width = (MdiParent.Width - 309);
            Height = (MdiParent.Height - 25);
        }

        private void searchres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}