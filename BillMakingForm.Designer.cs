namespace print
{
    partial class BillMakingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillMakingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TeacherNamTxt = new System.Windows.Forms.TextBox();
            this.CourseCodeTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SemsCmbBox = new System.Windows.Forms.ComboBox();
            this.SemesterLabel = new System.Windows.Forms.Label();
            this.facultyCmbBox = new System.Windows.Forms.ComboBox();
            this.FacultyNameLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(150, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Bill Making Form";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TeacherNamTxt);
            this.groupBox1.Controls.Add(this.CourseCodeTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.selectbtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SemsCmbBox);
            this.groupBox1.Controls.Add(this.SemesterLabel);
            this.groupBox1.Controls.Add(this.facultyCmbBox);
            this.groupBox1.Controls.Add(this.FacultyNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(108, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 293);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill Making";
            // 
            // TeacherNamTxt
            // 
            this.TeacherNamTxt.Location = new System.Drawing.Point(175, 39);
            this.TeacherNamTxt.Name = "TeacherNamTxt";
            this.TeacherNamTxt.Size = new System.Drawing.Size(121, 20);
            this.TeacherNamTxt.TabIndex = 18;
            this.TeacherNamTxt.TextChanged += new System.EventHandler(this.TeacherNamTxt_TextChanged);
            // 
            // CourseCodeTxt
            // 
            this.CourseCodeTxt.Location = new System.Drawing.Point(175, 165);
            this.CourseCodeTxt.Name = "CourseCodeTxt";
            this.CourseCodeTxt.Size = new System.Drawing.Size(121, 20);
            this.CourseCodeTxt.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Course Code";
            // 
            // selectbtn
            // 
            this.selectbtn.Image = ((System.Drawing.Image)(resources.GetObject("selectbtn.Image")));
            this.selectbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.selectbtn.Location = new System.Drawing.Point(209, 237);
            this.selectbtn.Name = "selectbtn";
            this.selectbtn.Size = new System.Drawing.Size(64, 24);
            this.selectbtn.TabIndex = 15;
            this.selectbtn.Text = "Select";
            this.selectbtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.selectbtn.UseVisualStyleBackColor = true;
            this.selectbtn.Click += new System.EventHandler(this.selectbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Teacher Name";
            // 
            // SemsCmbBox
            // 
            this.SemsCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SemsCmbBox.FormattingEnabled = true;
            this.SemsCmbBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.SemsCmbBox.Location = new System.Drawing.Point(175, 124);
            this.SemsCmbBox.Name = "SemsCmbBox";
            this.SemsCmbBox.Size = new System.Drawing.Size(121, 21);
            this.SemsCmbBox.TabIndex = 12;
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterLabel.Location = new System.Drawing.Point(34, 124);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(86, 20);
            this.SemesterLabel.TabIndex = 11;
            this.SemesterLabel.Text = "Semester";
            // 
            // facultyCmbBox
            // 
            this.facultyCmbBox.AllowDrop = true;
            this.facultyCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyCmbBox.FormattingEnabled = true;
            this.facultyCmbBox.Items.AddRange(new object[] {
            "AG",
            "BBA",
            "CSE",
            "DVM",
            "Disaster Management",
            "Fisheries",
            "Others"});
            this.facultyCmbBox.Location = new System.Drawing.Point(175, 87);
            this.facultyCmbBox.MaxLength = 20;
            this.facultyCmbBox.Name = "facultyCmbBox";
            this.facultyCmbBox.Size = new System.Drawing.Size(121, 21);
            this.facultyCmbBox.TabIndex = 10;
            // 
            // FacultyNameLabel
            // 
            this.FacultyNameLabel.AutoSize = true;
            this.FacultyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyNameLabel.Location = new System.Drawing.Point(34, 87);
            this.FacultyNameLabel.Name = "FacultyNameLabel";
            this.FacultyNameLabel.Size = new System.Drawing.Size(118, 20);
            this.FacultyNameLabel.TabIndex = 9;
            this.FacultyNameLabel.Text = "Faculty Name";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.logoutbtn);
            this.groupBox4.Controls.Add(this.backbtn);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Navy;
            this.groupBox4.Location = new System.Drawing.Point(224, 453);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 84);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Back/Logout";
            // 
            // logoutbtn
            // 
            this.logoutbtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutbtn.Image")));
            this.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.logoutbtn.Location = new System.Drawing.Point(93, 28);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(73, 23);
            this.logoutbtn.TabIndex = 21;
            this.logoutbtn.Text = "Exit";
            this.logoutbtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.backbtn.Location = new System.Drawing.Point(16, 28);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(64, 23);
            this.backbtn.TabIndex = 20;
            this.backbtn.Text = "Back";
            this.backbtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // BillMakingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::print.Properties.Resources.HUA0071;
            this.ClientSize = new System.Drawing.Size(627, 562);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "BillMakingForm";
            this.Text = "BillMakingForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SemsCmbBox;
        private System.Windows.Forms.Label SemesterLabel;
        private System.Windows.Forms.ComboBox facultyCmbBox;
        private System.Windows.Forms.Label FacultyNameLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox CourseCodeTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TeacherNamTxt;
    }
}