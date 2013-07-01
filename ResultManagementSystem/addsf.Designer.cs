namespace ResultManagementSystem
{
    partial class frmaddsf
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcursem = new System.Windows.Forms.ComboBox();
            this.txtsec = new System.Windows.Forms.ComboBox();
            this.txtfield = new System.Windows.Forms.ComboBox();
            this.yoepick = new System.Windows.Forms.DateTimePicker();
            this.dobpick = new System.Windows.Forms.DateTimePicker();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtseat = new System.Windows.Forms.TextBox();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.s_name = new System.Windows.Forms.Label();
            this.field = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.Label();
            this.semes = new System.Windows.Forms.Label();
            this.yoe = new System.Windows.Forms.Label();
            this.fthname = new System.Windows.Forms.Label();
            this.seatno = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fof = new System.Windows.Forms.ComboBox();
            this.quali = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 284);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtcursem);
            this.tabPage1.Controls.Add(this.txtsec);
            this.tabPage1.Controls.Add(this.txtfield);
            this.tabPage1.Controls.Add(this.yoepick);
            this.tabPage1.Controls.Add(this.dobpick);
            this.tabPage1.Controls.Add(this.txtfname);
            this.tabPage1.Controls.Add(this.txtseat);
            this.tabPage1.Controls.Add(this.txtsname);
            this.tabPage1.Controls.Add(this.s_name);
            this.tabPage1.Controls.Add(this.field);
            this.tabPage1.Controls.Add(this.dob);
            this.tabPage1.Controls.Add(this.sec);
            this.tabPage1.Controls.Add(this.semes);
            this.tabPage1.Controls.Add(this.yoe);
            this.tabPage1.Controls.Add(this.fthname);
            this.tabPage1.Controls.Add(this.seatno);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(352, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Student Record";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.button2.Location = new System.Drawing.Point(143, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 56;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.button1.Location = new System.Drawing.Point(258, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcursem
            // 
            this.txtcursem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcursem.FormattingEnabled = true;
            this.txtcursem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.txtcursem.Location = new System.Drawing.Point(143, 162);
            this.txtcursem.Name = "txtcursem";
            this.txtcursem.Size = new System.Drawing.Size(201, 23);
            this.txtcursem.TabIndex = 54;
            // 
            // txtsec
            // 
            this.txtsec.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsec.FormattingEnabled = true;
            this.txtsec.Items.AddRange(new object[] {
            "A",
            "B"});
            this.txtsec.Location = new System.Drawing.Point(143, 136);
            this.txtsec.Name = "txtsec";
            this.txtsec.Size = new System.Drawing.Size(201, 23);
            this.txtsec.TabIndex = 53;
            // 
            // txtfield
            // 
            this.txtfield.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfield.FormattingEnabled = true;
            this.txtfield.Items.AddRange(new object[] {
            "BSCS",
            "BSSE"});
            this.txtfield.Location = new System.Drawing.Point(141, 110);
            this.txtfield.Name = "txtfield";
            this.txtfield.Size = new System.Drawing.Size(201, 23);
            this.txtfield.TabIndex = 52;
            // 
            // yoepick
            // 
            this.yoepick.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yoepick.Location = new System.Drawing.Point(143, 188);
            this.yoepick.Name = "yoepick";
            this.yoepick.Size = new System.Drawing.Size(201, 23);
            this.yoepick.TabIndex = 51;
            this.yoepick.ValueChanged += new System.EventHandler(this.yoepick_ValueChanged);
            // 
            // dobpick
            // 
            this.dobpick.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobpick.Location = new System.Drawing.Point(141, 84);
            this.dobpick.Name = "dobpick";
            this.dobpick.Size = new System.Drawing.Size(201, 23);
            this.dobpick.TabIndex = 50;
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(141, 58);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(201, 23);
            this.txtfname.TabIndex = 49;
            // 
            // txtseat
            // 
            this.txtseat.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtseat.Location = new System.Drawing.Point(141, 32);
            this.txtseat.Name = "txtseat";
            this.txtseat.Size = new System.Drawing.Size(201, 23);
            this.txtseat.TabIndex = 48;
            // 
            // txtsname
            // 
            this.txtsname.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsname.Location = new System.Drawing.Point(141, 6);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(201, 23);
            this.txtsname.TabIndex = 47;
            // 
            // s_name
            // 
            this.s_name.AutoSize = true;
            this.s_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_name.Location = new System.Drawing.Point(6, 9);
            this.s_name.Name = "s_name";
            this.s_name.Size = new System.Drawing.Size(76, 17);
            this.s_name.TabIndex = 46;
            this.s_name.Text = "Full Name:";
            // 
            // field
            // 
            this.field.AutoSize = true;
            this.field.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field.Location = new System.Drawing.Point(6, 112);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(45, 17);
            this.field.TabIndex = 45;
            this.field.Text = "Field: ";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(6, 89);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(96, 17);
            this.dob.TabIndex = 44;
            this.dob.Text = "Date of Birth: ";
            // 
            // sec
            // 
            this.sec.AutoSize = true;
            this.sec.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec.Location = new System.Drawing.Point(6, 138);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(63, 17);
            this.sec.TabIndex = 43;
            this.sec.Text = "Section: ";
            // 
            // semes
            // 
            this.semes.AutoSize = true;
            this.semes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semes.Location = new System.Drawing.Point(6, 164);
            this.semes.Name = "semes";
            this.semes.Size = new System.Drawing.Size(125, 17);
            this.semes.TabIndex = 42;
            this.semes.Text = "Current Semester: ";
            // 
            // yoe
            // 
            this.yoe.AutoSize = true;
            this.yoe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yoe.Location = new System.Drawing.Point(3, 193);
            this.yoe.Name = "yoe";
            this.yoe.Size = new System.Drawing.Size(130, 17);
            this.yoe.TabIndex = 41;
            this.yoe.Text = "Year of Enrolment: ";
            // 
            // fthname
            // 
            this.fthname.AutoSize = true;
            this.fthname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fthname.Location = new System.Drawing.Point(6, 60);
            this.fthname.Name = "fthname";
            this.fthname.Size = new System.Drawing.Size(105, 17);
            this.fthname.TabIndex = 40;
            this.fthname.Text = "Fathers Name: ";
            // 
            // seatno
            // 
            this.seatno.AutoSize = true;
            this.seatno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatno.Location = new System.Drawing.Point(6, 34);
            this.seatno.Name = "seatno";
            this.seatno.Size = new System.Drawing.Size(71, 17);
            this.seatno.TabIndex = 39;
            this.seatno.Text = "Seat No.: ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage2.Controls.Add(this.fof);
            this.tabPage2.Controls.Add(this.quali);
            this.tabPage2.Controls.Add(this.email);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.tname);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(352, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Faculty Record";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // fof
            // 
            this.fof.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fof.FormattingEnabled = true;
            this.fof.Items.AddRange(new object[] {
            "Morning",
            "Evening",
            "Both"});
            this.fof.Location = new System.Drawing.Point(146, 96);
            this.fof.Name = "fof";
            this.fof.Size = new System.Drawing.Size(198, 23);
            this.fof.TabIndex = 66;
            // 
            // quali
            // 
            this.quali.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quali.Location = new System.Drawing.Point(146, 67);
            this.quali.Name = "quali";
            this.quali.Size = new System.Drawing.Size(198, 23);
            this.quali.TabIndex = 65;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(146, 38);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(198, 23);
            this.email.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "Faculty of:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Qualification:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "E-Mail:";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.button3.Location = new System.Drawing.Point(146, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 22);
            this.button3.TabIndex = 60;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.button4.Location = new System.Drawing.Point(258, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 22);
            this.button4.TabIndex = 59;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tname
            // 
            this.tname.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tname.Location = new System.Drawing.Point(146, 9);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(198, 23);
            this.tname.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Faculty Name:";
            // 
            // frmaddsf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(360, 284);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmaddsf";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmaddstu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtcursem;
        private System.Windows.Forms.ComboBox txtsec;
        private System.Windows.Forms.ComboBox txtfield;
        private System.Windows.Forms.DateTimePicker yoepick;
        private System.Windows.Forms.DateTimePicker dobpick;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtseat;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.Label s_name;
        private System.Windows.Forms.Label field;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label sec;
        private System.Windows.Forms.Label semes;
        private System.Windows.Forms.Label yoe;
        private System.Windows.Forms.Label fthname;
        private System.Windows.Forms.Label seatno;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fof;
        private System.Windows.Forms.TextBox quali;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;

    }
}