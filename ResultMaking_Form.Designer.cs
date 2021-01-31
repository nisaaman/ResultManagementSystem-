namespace print
{
    partial class ResultMaking_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultMaking_Form));
            this.selectbtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.regtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.semcmb = new System.Windows.Forms.ComboBox();
            this.SemesterLabel = new System.Windows.Forms.Label();
            this.facultycmb = new System.Windows.Forms.ComboBox();
            this.FacultyNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectbtn
            // 
            this.selectbtn.Image = ((System.Drawing.Image)(resources.GetObject("selectbtn.Image")));
            this.selectbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.selectbtn.Location = new System.Drawing.Point(211, 163);
            this.selectbtn.Name = "selectbtn";
            this.selectbtn.Size = new System.Drawing.Size(64, 24);
            this.selectbtn.TabIndex = 15;
            this.selectbtn.Text = "Select";
            this.selectbtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.selectbtn.UseVisualStyleBackColor = true;
            this.selectbtn.Click += new System.EventHandler(this.selectbtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.searchbtn);
            this.groupBox4.Controls.Add(this.logoutbtn);
            this.groupBox4.Controls.Add(this.backbtn);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Navy;
            this.groupBox4.Location = new System.Drawing.Point(216, 340);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 87);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Back/Logout";
            // 
            // searchbtn
            // 
            this.searchbtn.Image = ((System.Drawing.Image)(resources.GetObject("searchbtn.Image")));
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.searchbtn.Location = new System.Drawing.Point(50, 57);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(71, 23);
            this.searchbtn.TabIndex = 23;
            this.searchbtn.Text = " Search";
            this.searchbtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.selectbtn);
            this.groupBox1.Controls.Add(this.regtxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.semcmb);
            this.groupBox1.Controls.Add(this.SemesterLabel);
            this.groupBox1.Controls.Add(this.facultycmb);
            this.groupBox1.Controls.Add(this.FacultyNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(79, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 205);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result Making";
            // 
            // regtxt
            // 
            this.regtxt.Location = new System.Drawing.Point(154, 39);
            this.regtxt.Name = "regtxt";
            this.regtxt.Size = new System.Drawing.Size(121, 20);
            this.regtxt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Registration";
            // 
            // semcmb
            // 
            this.semcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semcmb.FormattingEnabled = true;
            this.semcmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.semcmb.Location = new System.Drawing.Point(154, 114);
            this.semcmb.Name = "semcmb";
            this.semcmb.Size = new System.Drawing.Size(121, 21);
            this.semcmb.TabIndex = 12;
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterLabel.Location = new System.Drawing.Point(52, 114);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(86, 20);
            this.SemesterLabel.TabIndex = 11;
            this.SemesterLabel.Text = "Semester";
            // 
            // facultycmb
            // 
            this.facultycmb.AllowDrop = true;
            this.facultycmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultycmb.FormattingEnabled = true;
            this.facultycmb.Items.AddRange(new object[] {
            "AG",
            "BBA",
            "CSE",
            "DVM",
            "Disaster Management",
            "Fisheries",
            "Others"});
            this.facultycmb.Location = new System.Drawing.Point(154, 77);
            this.facultycmb.MaxLength = 20;
            this.facultycmb.Name = "facultycmb";
            this.facultycmb.Size = new System.Drawing.Size(121, 21);
            this.facultycmb.TabIndex = 10;
            // 
            // FacultyNameLabel
            // 
            this.FacultyNameLabel.AutoSize = true;
            this.FacultyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyNameLabel.Location = new System.Drawing.Point(20, 77);
            this.FacultyNameLabel.Name = "FacultyNameLabel";
            this.FacultyNameLabel.Size = new System.Drawing.Size(118, 20);
            this.FacultyNameLabel.TabIndex = 9;
            this.FacultyNameLabel.Text = "Faculty Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(124, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "Result Making";
            // 
            // ResultMaking_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(485, 485);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ResultMaking_Form";
            this.Text = "ResultMaking_Form";
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectbtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox regtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox semcmb;
        private System.Windows.Forms.Label SemesterLabel;
        private System.Windows.Forms.ComboBox facultycmb;
        private System.Windows.Forms.Label FacultyNameLabel;
        private System.Windows.Forms.Label label1;
    }
}