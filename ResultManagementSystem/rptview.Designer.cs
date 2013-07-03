namespace ResultManagementSystem
{
    partial class frmrptview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rptview = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new ResultManagementSystem.resrpt();
            this.SuspendLayout();
            // 
            // rptview
            // 
            this.rptview.ActiveViewIndex = 0;
            this.rptview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptview.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptview.Location = new System.Drawing.Point(0, 0);
            this.rptview.Name = "rptview";
            this.rptview.ReportSource = this.CrystalReport11;
            this.rptview.Size = new System.Drawing.Size(871, 774);
            this.rptview.TabIndex = 0;
            this.rptview.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmrptview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 774);
            this.Controls.Add(this.rptview);
            this.Name = "frmrptview";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmrptview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptview;
        private resrpt CrystalReport11;
    }
}