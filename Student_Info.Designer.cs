namespace print
{
    partial class Student_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Info));
            this.facultycmb = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.stnametxt = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stregtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.stsessiontxt = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // facultycmb
            // 
            this.facultycmb.FormattingEnabled = true;
            this.facultycmb.Items.AddRange(new object[] {
            "AG",
            "BBA",
            "CSE",
            "DVM",
            "Disaster Management",
            "Fisheries",
            "Others"});
            this.facultycmb.Location = new System.Drawing.Point(91, 102);
            this.facultycmb.Name = "facultycmb";
            this.facultycmb.Size = new System.Drawing.Size(175, 21);
            this.facultycmb.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.searchbtn);
            this.groupBox2.Controls.Add(this.updatebtn);
            this.groupBox2.Controls.Add(this.deletebtn);
            this.groupBox2.Controls.Add(this.savebtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(64, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 91);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update/Delete";
            // 
            // searchbtn
            // 
            this.searchbtn.ForeColor = System.Drawing.Color.Navy;
            this.searchbtn.Image = ((System.Drawing.Image)(resources.GetObject("searchbtn.Image")));
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.searchbtn.Location = new System.Drawing.Point(13, 19);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(69, 23);
            this.searchbtn.TabIndex = 19;
            this.searchbtn.Text = "Search";
            this.searchbtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.ForeColor = System.Drawing.Color.Navy;
            this.updatebtn.Image = ((System.Drawing.Image)(resources.GetObject("updatebtn.Image")));
            this.updatebtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.updatebtn.Location = new System.Drawing.Point(94, 19);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(72, 23);
            this.updatebtn.TabIndex = 16;
            this.updatebtn.Text = "Update";
            this.updatebtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.ForeColor = System.Drawing.Color.Navy;
            this.deletebtn.Image = ((System.Drawing.Image)(resources.GetObject("deletebtn.Image")));
            this.deletebtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.deletebtn.Location = new System.Drawing.Point(94, 48);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(72, 23);
            this.deletebtn.TabIndex = 15;
            this.deletebtn.Text = "Delete";
            this.deletebtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.ForeColor = System.Drawing.Color.Navy;
            this.savebtn.Image = ((System.Drawing.Image)(resources.GetObject("savebtn.Image")));
            this.savebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savebtn.Location = new System.Drawing.Point(13, 48);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(59, 23);
            this.savebtn.TabIndex = 13;
            this.savebtn.Text = "Save";
            this.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // stnametxt
            // 
            this.stnametxt.Location = new System.Drawing.Point(91, 29);
            this.stnametxt.Name = "stnametxt";
            this.stnametxt.Size = new System.Drawing.Size(175, 20);
            this.stnametxt.TabIndex = 0;
            // 
            // backbtn
            // 
            this.backbtn.ForeColor = System.Drawing.Color.Navy;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.backbtn.Location = new System.Drawing.Point(14, 28);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(63, 23);
            this.backbtn.TabIndex = 20;
            this.backbtn.Text = "Back";
            this.backbtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.logoutbtn);
            this.groupBox4.Controls.Add(this.backbtn);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox4.Location = new System.Drawing.Point(322, 351);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 91);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Back/Delete";
            // 
            // logoutbtn
            // 
            this.logoutbtn.ForeColor = System.Drawing.Color.Navy;
            this.logoutbtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutbtn.Image")));
            this.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.logoutbtn.Location = new System.Drawing.Point(89, 28);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(67, 23);
            this.logoutbtn.TabIndex = 21;
            this.logoutbtn.Text = "Exit";
            this.logoutbtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.stsessiontxt);
            this.groupBox1.Controls.Add(this.facultycmb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.stregtxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stnametxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(144, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 184);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(18, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Session :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(18, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reg No :";
            // 
            // stregtxt
            // 
            this.stregtxt.Location = new System.Drawing.Point(91, 66);
            this.stregtxt.Name = "stregtxt";
            this.stregtxt.Size = new System.Drawing.Size(175, 20);
            this.stregtxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(21, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Faculty :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(131, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(298, 31);
            this.label7.TabIndex = 22;
            this.label7.Text = "Student Information";
            // 
            // stsessiontxt
            // 
            this.stsessiontxt.FormattingEnabled = true;
            this.stsessiontxt.Items.AddRange(new object[] {
            "01-02",
            "02-03",
            "03-04",
            "04-05",
            "05-06",
            "06-07",
            "07-08",
            "08-09",
            "09-10",
            "10-11",
            "11-12",
            "12-13",
            "13-14",
            "14-15",
            "15-16",
            "16-17",
            "17-18",
            "18-19",
            "19-20",
            "20-21",
            "21-22",
            "22-23",
            "23-24",
            "24-25"});
            this.stsessiontxt.Location = new System.Drawing.Point(91, 143);
            this.stsessiontxt.Name = "stsessiontxt";
            this.stsessiontxt.Size = new System.Drawing.Size(175, 21);
            this.stsessiontxt.TabIndex = 13;
            // 
            // Student_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(562, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "Student_Info";
            this.Text = "Student_Info";
            this.Load += new System.EventHandler(this.Student_Info_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox facultycmb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.TextBox stnametxt;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stregtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox stsessiontxt;
    }
}