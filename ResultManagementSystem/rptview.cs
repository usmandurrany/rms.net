using System;
using System.Data;
using System.Windows.Forms;

namespace ResultManagementSystem
{
    public partial class frmrptview : Form
    {
        private readonly resrpt rpt = new resrpt();
        private readonly string tname;

        public frmrptview(DataTable dt, string tname)
        {
            InitializeComponent();
            rpt.SetDataSource(dt);
            this.tname = tname;
        }

        private void frmrptview_Load(object sender, EventArgs e)
        {
            rptview.ReportSource = rpt;
            rpt.SummaryInfo.ReportTitle = tname;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }
    }
}