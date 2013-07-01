using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ResultManagementSystem
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loginas.SelectedItem == loginas.Items[0])
                label2.Text = "SeatNo";


            if (loginas.SelectedItem == loginas.Items[1])
                label2.Text = "TID";
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            loginas.SelectedItem = loginas.Items[0];
            AcceptButton = btnlogin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> results = database.login_check(loginas.Text.ToLower(), label2.Text.ToLower(), txtusrname.Text,txtpass.Text);

            if (results.Count != 0)
            {
                MdiParent.MainMenuStrip.Enabled = true;
                MdiParent.MainMenuStrip.Items["mnusrname"].Text = (results[1]);
                common.main.SetLoginUser(results[0]);
                if (results[5] == "1")
                {
                    MdiParent.MainMenuStrip.Items["mnuadd"].Visible = true;
                    MdiParent.MainMenuStrip.Items["mnusearch"].Visible = true;
                }


                var sidebar = new frmsidebar();
                sidebar.MdiParent = MdiParent;
                sidebar.Dock = DockStyle.Left;
                common.sidebar = sidebar;
                common.sidebar.SetValues(results);
                common.sidebar.Show();
                Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}