using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ResultManagementSystem
{
    public partial class frmmain : Form
    {
        private common comm = new common();
        private database db = new database();
        private string tid;


        public frmmain()
        {
            InitializeComponent();
        }


        private void frmmain_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            timer1.Enabled = true;
            common.main = this;
            var sidebar = new frmsidebar();
            var login = new frmlogin();
            var viewres = new frmdgview();

            common.mnubar = mnubar;
            common.login = login;
            common.sidebar = sidebar;
            common.viewres = viewres;

            common.login.MdiParent = this;

            Location = new Point(0, 0);
            Size = Screen.PrimaryScreen.WorkingArea.Size;


            sidebar.MdiParent = this;

            viewres.MdiParent = this;
            //f1.MdiParent = this;


            sidebar.Dock = DockStyle.Left; //Sidebar
            viewres.Dock = DockStyle.Right;

            common.login.Show();
        }

        public void SetLoginUser(string id)
        {
            tid = id;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += 0.07;
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form

            switch (m.Msg)
            {
                case WM_SYSCOMMAND: //preventing the form from being moved by the mouse.
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            if (m.Msg == WM_NCLBUTTONDBLCLK)
                //preventing the form being resized by the mouse double click on the title bar.
            {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "frmmain")
                    Application.OpenForms[i].Close();
            }
            mnubar.Items["mnuadd"].Visible = false;
            mnubar.Items["mnusearch"].Visible = false;
            mnubar.Enabled = false;
            mnusrname.Text = "";
            var login = new frmlogin();
            login.MdiParent = this;
            common.login = login;
            common.login.Show();
        }

        private void rEPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void mnubar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void mnusrname_Click_1(object sender, EventArgs e)
        {
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addstu = new frmaddsf();
            addstu.MdiParent = this;
            addstu.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Are you sure want to exit ? ", "Exit RMS", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Exclamation) == DialogResult.Yes)
                Application.Exit();
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resdet = new frmaddrc();
            resdet.MdiParent = this;
            var cmd = new MySqlCommand();
            cmd.CommandText = "SELECT tid, t_name FROM faculty WHERE tid ='" + tid + "'";
            cmd.Connection = database.conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                resdet.GetTID(reader[1].ToString(), reader[0].ToString());
            }
            reader.Close();
            resdet.Show();
        }

        private void mnusearch_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "frmsearch")
                    Application.OpenForms[i].Close();
            }
            var search = new frmsearch();
            search.MdiParent = this;
            search.Show();
        }

        private void mnuadd_Click(object sender, EventArgs e)
        {
        }
    }
}