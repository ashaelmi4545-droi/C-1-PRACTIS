namespace TIJAABO
{
    partial class Form1
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdepartement = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.btnshowinformatio = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(-2, 113);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(265, 28);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter the student name";
            // 
            // lblstudentid
            // 
            this.lblstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentid.Location = new System.Drawing.Point(12, 191);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(251, 31);
            this.lblstudentid.TabIndex = 1;
            this.lblstudentid.Text = "Enter the student ID";
            // 
            // lbldepartment
            // 
            this.lbldepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartment.Location = new System.Drawing.Point(12, 265);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(251, 28);
            this.lbldepartment.TabIndex = 2;
            this.lbldepartment.Text = "Enter the department";
            // 
            // lblsemester
            // 
            this.lblsemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsemester.Location = new System.Drawing.Point(12, 336);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(251, 27);
            this.lblsemester.TabIndex = 3;
            this.lblsemester.Text = "Enter the semster";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(345, 97);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(217, 44);
            this.txtname.TabIndex = 4;
            // 
            // txtdepartement
            // 
            this.txtdepartement.Location = new System.Drawing.Point(345, 252);
            this.txtdepartement.Multiline = true;
            this.txtdepartement.Name = "txtdepartement";
            this.txtdepartement.Size = new System.Drawing.Size(213, 41);
            this.txtdepartement.TabIndex = 5;
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(340, 336);
            this.txtsemester.Multiline = true;
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(218, 39);
            this.txtsemester.TabIndex = 6;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(349, 170);
            this.txtstudentid.Multiline = true;
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(218, 41);
            this.txtstudentid.TabIndex = 7;
            // 
            // btnshowinformatio
            // 
            this.btnshowinformatio.Location = new System.Drawing.Point(111, 493);
            this.btnshowinformatio.Name = "btnshowinformatio";
            this.btnshowinformatio.Size = new System.Drawing.Size(197, 45);
            this.btnshowinformatio.TabIndex = 8;
            this.btnshowinformatio.Text = "show informatio";
            this.btnshowinformatio.UseVisualStyleBackColor = true;
            this.btnshowinformatio.Click += new System.EventHandler(this.btnshowinformatio_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(349, 493);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(218, 45);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(642, 493);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(214, 45);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(271, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(441, 59);
            this.label5.TabIndex = 11;
            this.label5.Text = "STUDENT INFORMATION";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbloutput.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbloutput.Location = new System.Drawing.Point(170, 391);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(581, 82);
            this.lbloutput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 550);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowinformatio);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtdepartement);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "student information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdepartement;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.Button btnshowinformatio;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbloutput;
    }
}

