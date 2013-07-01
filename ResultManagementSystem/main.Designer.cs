namespace ResultManagementSystem
{
    partial class frmmain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mnubar = new System.Windows.Forms.MenuStrip();
            this.mnusrname = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuadd = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mnubar
            // 
            this.mnubar.BackColor = System.Drawing.Color.Transparent;
            this.mnubar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnubar.BackgroundImage")));
            this.mnubar.Enabled = false;
            this.mnubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnusrname,
            this.mnuadd,
            this.mnusearch});
            this.mnubar.Location = new System.Drawing.Point(0, 0);
            this.mnubar.Name = "mnubar";
            this.mnubar.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.mnubar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnubar.Size = new System.Drawing.Size(632, 40);
            this.mnubar.TabIndex = 1;
            this.mnubar.Text = "menuStrip1";
            this.mnubar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnubar_ItemClicked);
            // 
            // mnusrname
            // 
            this.mnusrname.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnusrname.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnusrname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnusrname.ForeColor = System.Drawing.Color.White;
            this.mnusrname.Image = ((System.Drawing.Image)(resources.GetObject("mnusrname.Image")));
            this.mnusrname.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mnusrname.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnusrname.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnusrname.Name = "mnusrname";
            this.mnusrname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnusrname.Size = new System.Drawing.Size(44, 36);
            this.mnusrname.Click += new System.EventHandler(this.mnusrname_Click_1);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exitToolStripMenuItem.Text = "Exit ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuadd
            // 
            this.mnuadd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.mnuadd.ForeColor = System.Drawing.Color.White;
            this.mnuadd.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuadd.Name = "mnuadd";
            this.mnuadd.Size = new System.Drawing.Size(68, 36);
            this.mnuadd.Text = "Add New";
            this.mnuadd.Visible = false;
            this.mnuadd.Click += new System.EventHandler(this.mnuadd_Click);
            // 
            // resultToolStripMenuItem
            // 
            this.resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            this.resultToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.resultToolStripMenuItem.Text = "Result / Course";
            this.resultToolStripMenuItem.Click += new System.EventHandler(this.resultToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.studentToolStripMenuItem.Text = "Student / Faculty Record";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // mnusearch
            // 
            this.mnusearch.ForeColor = System.Drawing.Color.White;
            this.mnusearch.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnusearch.Name = "mnusearch";
            this.mnusearch.Size = new System.Drawing.Size(54, 36);
            this.mnusearch.Text = "Search";
            this.mnusearch.Visible = false;
            this.mnusearch.Click += new System.EventHandler(this.mnusearch_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.mnubar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnubar;
            this.MaximizeBox = false;
            this.Name = "frmmain";
            this.Text = "Result Management System";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.mnubar.ResumeLayout(false);
            this.mnubar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip mnubar;
        private System.Windows.Forms.ToolStripMenuItem mnusrname;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuadd;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnusearch;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

    }
}



