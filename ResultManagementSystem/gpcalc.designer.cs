namespace ResultManagementSystem
{
    partial class frmgpcalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.semes = new System.Windows.Forms.ComboBox();
            this.calgpa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totpap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Semester :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "GPA Calcualtion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // calc
            // 
            this.calc.BackColor = System.Drawing.Color.White;
            this.calc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.calc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.calc.Location = new System.Drawing.Point(152, 141);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(75, 23);
            this.calc.TabIndex = 4;
            this.calc.Text = "Calculate";
            this.calc.UseVisualStyleBackColor = false;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.White;
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancel.Location = new System.Drawing.Point(25, 141);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // semes
            // 
            this.semes.FormattingEnabled = true;
            this.semes.Location = new System.Drawing.Point(106, 41);
            this.semes.Name = "semes";
            this.semes.Size = new System.Drawing.Size(121, 21);
            this.semes.TabIndex = 6;
            // 
            // calgpa
            // 
            this.calgpa.AutoSize = true;
            this.calgpa.Location = new System.Drawing.Point(136, 108);
            this.calgpa.Name = "calgpa";
            this.calgpa.Size = new System.Drawing.Size(0, 13);
            this.calgpa.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Calculated GPA:";
            // 
            // totpap
            // 
            this.totpap.AutoSize = true;
            this.totpap.Location = new System.Drawing.Point(158, 81);
            this.totpap.Name = "totpap";
            this.totpap.Size = new System.Drawing.Size(0, 13);
            this.totpap.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total no. of papers:";
            // 
            // frmgpcalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(241, 176);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totpap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calgpa);
            this.Controls.Add(this.semes);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmgpcalc";
            this.Text = "gpacalc";
            this.Load += new System.EventHandler(this.gpacalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox semes;
        private System.Windows.Forms.Label calgpa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totpap;
        private System.Windows.Forms.Label label4;



    }
}