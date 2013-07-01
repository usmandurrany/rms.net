namespace ResultManagementSystem
{
    partial class frmaddres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addres = new System.Windows.Forms.DataGridView();
            this.mnuaddres = new System.Windows.Forms.MenuStrip();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.addres)).BeginInit();
            this.mnuaddres.SuspendLayout();
            this.SuspendLayout();
            // 
            // addres
            // 
            this.addres.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.addres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.addres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addres.Location = new System.Drawing.Point(0, 0);
            this.addres.Name = "addres";
            this.addres.Size = new System.Drawing.Size(453, 358);
            this.addres.TabIndex = 0;
            this.addres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addres_CellContentClick);
            this.addres.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.addres_CellValueChanged);
            // 
            // mnuaddres
            // 
            this.mnuaddres.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuaddres.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.mnuaddres.Location = new System.Drawing.Point(0, 0);
            this.mnuaddres.Name = "mnuaddres";
            this.mnuaddres.Size = new System.Drawing.Size(106, 24);
            this.mnuaddres.TabIndex = 1;
            this.mnuaddres.Text = "menuStrip1";
            this.mnuaddres.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuaddres_ItemClicked);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cancelToolStripMenuItem.Text = "Cancel";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // frmaddres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 358);
            this.Controls.Add(this.addres);
            this.Controls.Add(this.mnuaddres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mnuaddres;
            this.Name = "frmaddres";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addres)).EndInit();
            this.mnuaddres.ResumeLayout(false);
            this.mnuaddres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView addres;
        private System.Windows.Forms.MenuStrip mnuaddres;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    }
}