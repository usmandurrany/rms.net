namespace ResultManagementSystem
{
    partial class frmanares
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
            this.dob = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totstu = new System.Windows.Forms.Label();
            this.stupass = new System.Windows.Forms.Label();
            this.passth = new System.Windows.Forms.Label();
            this.passlab = new System.Windows.Forms.Label();
            this.stufail = new System.Windows.Forms.Label();
            this.failth = new System.Windows.Forms.Label();
            this.faillab = new System.Windows.Forms.Label();
            this.avgmarks = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(12, 9);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(142, 17);
            this.dob.TabIndex = 45;
            this.dob.Text = "Total no. of students:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 34);
            this.label1.TabIndex = 46;
            this.label1.Text = "No. of students passed:\r\n(TH/LAB):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 34);
            this.label2.TabIndex = 47;
            this.label2.Text = "No. of students failed:\r\n(TH/LAB):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Average marks:";
            // 
            // totstu
            // 
            this.totstu.AutoSize = true;
            this.totstu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totstu.Location = new System.Drawing.Point(208, 9);
            this.totstu.Name = "totstu";
            this.totstu.Size = new System.Drawing.Size(45, 17);
            this.totstu.TabIndex = 49;
            this.totstu.Text = "totstu";
            // 
            // stupass
            // 
            this.stupass.AutoSize = true;
            this.stupass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stupass.Location = new System.Drawing.Point(208, 36);
            this.stupass.Name = "stupass";
            this.stupass.Size = new System.Drawing.Size(47, 17);
            this.stupass.TabIndex = 50;
            this.stupass.Text = "label4";
            // 
            // passth
            // 
            this.passth.AutoSize = true;
            this.passth.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passth.Location = new System.Drawing.Point(208, 53);
            this.passth.Name = "passth";
            this.passth.Size = new System.Drawing.Size(47, 17);
            this.passth.TabIndex = 51;
            this.passth.Text = "label5";
            // 
            // passlab
            // 
            this.passlab.AutoSize = true;
            this.passlab.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlab.Location = new System.Drawing.Point(261, 53);
            this.passlab.Name = "passlab";
            this.passlab.Size = new System.Drawing.Size(47, 17);
            this.passlab.TabIndex = 52;
            this.passlab.Text = "label6";
            // 
            // stufail
            // 
            this.stufail.AutoSize = true;
            this.stufail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stufail.Location = new System.Drawing.Point(208, 80);
            this.stufail.Name = "stufail";
            this.stufail.Size = new System.Drawing.Size(47, 17);
            this.stufail.TabIndex = 53;
            this.stufail.Text = "label7";
            // 
            // failth
            // 
            this.failth.AutoSize = true;
            this.failth.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failth.Location = new System.Drawing.Point(208, 97);
            this.failth.Name = "failth";
            this.failth.Size = new System.Drawing.Size(47, 17);
            this.failth.TabIndex = 54;
            this.failth.Text = "label8";
            this.failth.Click += new System.EventHandler(this.label8_Click);
            // 
            // faillab
            // 
            this.faillab.AutoSize = true;
            this.faillab.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faillab.Location = new System.Drawing.Point(261, 97);
            this.faillab.Name = "faillab";
            this.faillab.Size = new System.Drawing.Size(47, 17);
            this.faillab.TabIndex = 55;
            this.faillab.Text = "label9";
            this.faillab.Click += new System.EventHandler(this.label9_Click);
            // 
            // avgmarks
            // 
            this.avgmarks.AutoSize = true;
            this.avgmarks.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgmarks.Location = new System.Drawing.Point(207, 124);
            this.avgmarks.Name = "avgmarks";
            this.avgmarks.Size = new System.Drawing.Size(54, 17);
            this.avgmarks.TabIndex = 56;
            this.avgmarks.Text = "label10";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.button2.Location = new System.Drawing.Point(211, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 57;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmanares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(318, 185);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.avgmarks);
            this.Controls.Add(this.faillab);
            this.Controls.Add(this.failth);
            this.Controls.Add(this.stufail);
            this.Controls.Add(this.passlab);
            this.Controls.Add(this.passth);
            this.Controls.Add(this.stupass);
            this.Controls.Add(this.totstu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dob);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmanares";
            this.Text = "Result Analysis";
            this.Load += new System.EventHandler(this.frmanares_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totstu;
        private System.Windows.Forms.Label stupass;
        private System.Windows.Forms.Label passth;
        private System.Windows.Forms.Label passlab;
        private System.Windows.Forms.Label stufail;
        private System.Windows.Forms.Label failth;
        private System.Windows.Forms.Label faillab;
        private System.Windows.Forms.Label avgmarks;
        private System.Windows.Forms.Button button2;
    }
}