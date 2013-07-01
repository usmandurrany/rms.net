namespace ResultManagementSystem
{
    partial class frmsidebar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsidebar));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.resfilter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reslist = new System.Windows.Forms.ListBox();
            this.usrdetails = new System.Windows.Forms.GroupBox();
            this.btngpa = new System.Windows.Forms.Button();
            this.field = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.Label();
            this.semes = new System.Windows.Forms.Label();
            this.yoe = new System.Windows.Forms.Label();
            this.fthname = new System.Windows.Forms.Label();
            this.seatno = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.usrdetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.usrdetails, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(306, 600);
            this.tableLayoutPanel1.TabIndex = 20;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.resfilter);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(3, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 59);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter Results:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Course No.:";
            this.label10.Click += new System.EventHandler(this.label10_Click_1);
            // 
            // resfilter
            // 
            this.resfilter.Location = new System.Drawing.Point(98, 22);
            this.resfilter.Name = "resfilter";
            this.resfilter.Size = new System.Drawing.Size(196, 23);
            this.resfilter.TabIndex = 20;
            this.resfilter.TextChanged += new System.EventHandler(this.resfilter_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.reslist);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 262);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Results:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.button1.Size = new System.Drawing.Size(294, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reslist
            // 
            this.reslist.BackColor = System.Drawing.SystemColors.Control;
            this.reslist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reslist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reslist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reslist.ForeColor = System.Drawing.Color.Black;
            this.reslist.FormattingEnabled = true;
            this.reslist.ItemHeight = 17;
            this.reslist.Location = new System.Drawing.Point(3, 19);
            this.reslist.Name = "reslist";
            this.reslist.Size = new System.Drawing.Size(294, 240);
            this.reslist.TabIndex = 14;
            this.reslist.SelectedIndexChanged += new System.EventHandler(this.reslist_SelectedIndexChanged_2);
            this.reslist.DoubleClick += new System.EventHandler(this.reslist_SelectedIndexChanged);
            // 
            // usrdetails
            // 
            this.usrdetails.BackColor = System.Drawing.Color.Transparent;
            this.usrdetails.Controls.Add(this.btngpa);
            this.usrdetails.Controls.Add(this.field);
            this.usrdetails.Controls.Add(this.dob);
            this.usrdetails.Controls.Add(this.sec);
            this.usrdetails.Controls.Add(this.semes);
            this.usrdetails.Controls.Add(this.yoe);
            this.usrdetails.Controls.Add(this.fthname);
            this.usrdetails.Controls.Add(this.seatno);
            this.usrdetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usrdetails.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrdetails.ForeColor = System.Drawing.Color.Black;
            this.usrdetails.Location = new System.Drawing.Point(3, 105);
            this.usrdetails.Name = "usrdetails";
            this.usrdetails.Size = new System.Drawing.Size(300, 159);
            this.usrdetails.TabIndex = 16;
            this.usrdetails.TabStop = false;
            this.usrdetails.Text = "Name:";
            this.usrdetails.Enter += new System.EventHandler(this.usrdetails_Enter_1);
            // 
            // btngpa
            // 
            this.btngpa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.btngpa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btngpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngpa.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngpa.ForeColor = System.Drawing.Color.White;
            this.btngpa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btngpa.Location = new System.Drawing.Point(204, 130);
            this.btngpa.Name = "btngpa";
            this.btngpa.Size = new System.Drawing.Size(90, 23);
            this.btngpa.TabIndex = 19;
            this.btngpa.Text = "Calc. GPA";
            this.btngpa.UseVisualStyleBackColor = false;
            this.btngpa.Click += new System.EventHandler(this.btngpa_Click);
            // 
            // field
            // 
            this.field.AutoSize = true;
            this.field.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field.ForeColor = System.Drawing.Color.Black;
            this.field.Location = new System.Drawing.Point(6, 62);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(45, 17);
            this.field.TabIndex = 18;
            this.field.Text = "Field: ";
            this.field.Click += new System.EventHandler(this.field_Click);
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.ForeColor = System.Drawing.Color.Black;
            this.dob.Location = new System.Drawing.Point(6, 43);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(96, 17);
            this.dob.TabIndex = 17;
            this.dob.Text = "Date of Birth: ";
            this.dob.Click += new System.EventHandler(this.dob_Click);
            // 
            // sec
            // 
            this.sec.AutoSize = true;
            this.sec.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec.ForeColor = System.Drawing.Color.Black;
            this.sec.Location = new System.Drawing.Point(6, 81);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(63, 17);
            this.sec.TabIndex = 16;
            this.sec.Text = "Section: ";
            this.sec.Click += new System.EventHandler(this.sec_Click);
            // 
            // semes
            // 
            this.semes.AutoSize = true;
            this.semes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semes.ForeColor = System.Drawing.Color.Black;
            this.semes.Location = new System.Drawing.Point(6, 100);
            this.semes.Name = "semes";
            this.semes.Size = new System.Drawing.Size(125, 17);
            this.semes.TabIndex = 15;
            this.semes.Text = "Current Semester: ";
            this.semes.Click += new System.EventHandler(this.semes_Click);
            // 
            // yoe
            // 
            this.yoe.AutoSize = true;
            this.yoe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yoe.ForeColor = System.Drawing.Color.Black;
            this.yoe.Location = new System.Drawing.Point(6, 119);
            this.yoe.Name = "yoe";
            this.yoe.Size = new System.Drawing.Size(130, 17);
            this.yoe.TabIndex = 14;
            this.yoe.Text = "Year of Enrolment: ";
            this.yoe.Click += new System.EventHandler(this.yoe_Click);
            // 
            // fthname
            // 
            this.fthname.AutoSize = true;
            this.fthname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fthname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fthname.ForeColor = System.Drawing.Color.Black;
            this.fthname.Location = new System.Drawing.Point(6, 23);
            this.fthname.Name = "fthname";
            this.fthname.Size = new System.Drawing.Size(105, 17);
            this.fthname.TabIndex = 13;
            this.fthname.Text = "Fathers Name: ";
            this.fthname.Click += new System.EventHandler(this.fthname_Click);
            // 
            // seatno
            // 
            this.seatno.AutoSize = true;
            this.seatno.BackColor = System.Drawing.Color.Transparent;
            this.seatno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatno.ForeColor = System.Drawing.Color.Black;
            this.seatno.Location = new System.Drawing.Point(227, 1);
            this.seatno.Name = "seatno";
            this.seatno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.seatno.Size = new System.Drawing.Size(0, 17);
            this.seatno.TabIndex = 11;
            this.seatno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.seatno.Click += new System.EventHandler(this.seatno_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // frmsidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(306, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmsidebar";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmsidebar_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.usrdetails.ResumeLayout(false);
            this.usrdetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox resfilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox reslist;
        private System.Windows.Forms.GroupBox usrdetails;
        private System.Windows.Forms.Label field;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label sec;
        private System.Windows.Forms.Label semes;
        private System.Windows.Forms.Label yoe;
        private System.Windows.Forms.Label fthname;
        private System.Windows.Forms.Label seatno;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btngpa;


    }
}