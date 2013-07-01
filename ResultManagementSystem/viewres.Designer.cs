namespace ResultManagementSystem
{
    partial class frmviewres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewres = new System.Windows.Forms.DataGridView();
            this.mnusearch = new System.Windows.Forms.MenuStrip();
            this.txtsearch = new System.Windows.Forms.ToolStripTextBox();
            this.mnuprint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuanares = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuedit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusave = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.viewres)).BeginInit();
            this.mnusearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewres
            // 
            this.viewres.AllowUserToAddRows = false;
            this.viewres.AllowUserToDeleteRows = false;
            this.viewres.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.viewres.BackgroundColor = System.Drawing.Color.White;
            this.viewres.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.viewres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewres.DefaultCellStyle = dataGridViewCellStyle4;
            this.viewres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewres.GridColor = System.Drawing.Color.White;
            this.viewres.Location = new System.Drawing.Point(0, 0);
            this.viewres.Name = "viewres";
            this.viewres.ReadOnly = true;
            this.viewres.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.viewres.RowHeadersVisible = false;
            this.viewres.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.viewres.Size = new System.Drawing.Size(657, 545);
            this.viewres.TabIndex = 0;
            // 
            // mnusearch
            // 
            this.mnusearch.Dock = System.Windows.Forms.DockStyle.None;
            this.mnusearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtsearch,
            this.mnuprint,
            this.mnuanares,
            this.mnuedit,
            this.mnusave});
            this.mnusearch.Location = new System.Drawing.Point(0, 0);
            this.mnusearch.Name = "mnusearch";
            this.mnusearch.Size = new System.Drawing.Size(422, 27);
            this.mnusearch.TabIndex = 1;
            this.mnusearch.Text = "mnusearch";
            this.mnusearch.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnusearch_ItemClicked);
            // 
            // txtsearch
            // 
            this.txtsearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtsearch.AutoSize = false;
            this.txtsearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtsearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtsearch.Margin = new System.Windows.Forms.Padding(1, 0, 5, 0);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(150, 23);
            this.txtsearch.Text = "filter using seat no.";
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // mnuprint
            // 
            this.mnuprint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuprint.ForeColor = System.Drawing.Color.White;
            this.mnuprint.Name = "mnuprint";
            this.mnuprint.Size = new System.Drawing.Size(79, 23);
            this.mnuprint.Text = "Print Result";
            this.mnuprint.Click += new System.EventHandler(this.mnuprint_Click);
            // 
            // mnuanares
            // 
            this.mnuanares.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuanares.ForeColor = System.Drawing.Color.White;
            this.mnuanares.Name = "mnuanares";
            this.mnuanares.Size = new System.Drawing.Size(97, 23);
            this.mnuanares.Text = "Result Analysis";
            this.mnuanares.Click += new System.EventHandler(this.mnuanares_Click);
            // 
            // mnuedit
            // 
            this.mnuedit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuedit.ForeColor = System.Drawing.Color.White;
            this.mnuedit.Name = "mnuedit";
            this.mnuedit.Size = new System.Drawing.Size(39, 23);
            this.mnuedit.Text = "Edit";
            this.mnuedit.Click += new System.EventHandler(this.mnuedit_Click);
            // 
            // mnusave
            // 
            this.mnusave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnusave.Enabled = false;
            this.mnusave.ForeColor = System.Drawing.Color.White;
            this.mnusave.Name = "mnusave";
            this.mnusave.Size = new System.Drawing.Size(43, 23);
            this.mnusave.Text = "Save";
            this.mnusave.Click += new System.EventHandler(this.mnusave_Click);
            // 
            // frmviewres
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(657, 545);
            this.Controls.Add(this.viewres);
            this.Controls.Add(this.mnusearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmviewres";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmviewres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewres)).EndInit();
            this.mnusearch.ResumeLayout(false);
            this.mnusearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewres;
        private System.Windows.Forms.MenuStrip mnusearch;
        private System.Windows.Forms.ToolStripTextBox txtsearch;
        private System.Windows.Forms.ToolStripMenuItem mnuprint;
        private System.Windows.Forms.ToolStripMenuItem mnuanares;
        private System.Windows.Forms.ToolStripMenuItem mnuedit;
        private System.Windows.Forms.ToolStripMenuItem mnusave;
    }
}