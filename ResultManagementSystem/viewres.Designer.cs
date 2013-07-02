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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewres = new System.Windows.Forms.DataGridView();
            this.mnusearch = new System.Windows.Forms.MenuStrip();
            this.txtsearch = new System.Windows.Forms.ToolStripTextBox();
            this.mnuprint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuanares = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuedit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnucreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnucancel = new System.Windows.Forms.ToolStripMenuItem();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewres.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.viewres.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewres_CellValueChanged);
            // 
            // mnusearch
            // 
            this.mnusearch.Dock = System.Windows.Forms.DockStyle.None;
            this.mnusearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtsearch,
            this.mnuprint,
            this.mnuanares,
            this.mnuedit,
            this.mnusave,
            this.mnucreate,
            this.mnucancel});
            this.mnusearch.Location = new System.Drawing.Point(0, 0);
            this.mnusearch.Name = "mnusearch";
            this.mnusearch.Size = new System.Drawing.Size(530, 27);
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
            this.txtsearch.Click += new System.EventHandler(this.txtsearch_Click);
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
            // mnucreate
            // 
            this.mnucreate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnucreate.ForeColor = System.Drawing.Color.White;
            this.mnucreate.Name = "mnucreate";
            this.mnucreate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnucreate.Size = new System.Drawing.Size(53, 23);
            this.mnucreate.Text = "Create";
            this.mnucreate.Click += new System.EventHandler(this.mnucreate_Click);
            // 
            // mnucancel
            // 
            this.mnucancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnucancel.ForeColor = System.Drawing.Color.White;
            this.mnucancel.Name = "mnucancel";
            this.mnucancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnucancel.Size = new System.Drawing.Size(55, 23);
            this.mnucancel.Text = "Cancel";
            this.mnucancel.Click += new System.EventHandler(this.mnucancel_Click);
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
        private System.Windows.Forms.ToolStripMenuItem mnucreate;
        private System.Windows.Forms.ToolStripMenuItem mnucancel;
    }
}