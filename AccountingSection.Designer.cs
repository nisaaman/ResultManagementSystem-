namespace print
{
    partial class AccountingSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountingSection));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teacherInfobtn = new System.Windows.Forms.Button();
            this.billmakingbtn = new System.Windows.Forms.Button();
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
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(82, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Accounting Section";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.teacherInfobtn);
            this.groupBox1.Controls.Add(this.billmakingbtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(88, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 172);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill For Remuneration Making";
            // 
            // teacherInfobtn
            // 
            this.teacherInfobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherInfobtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.teacherInfobtn.Location = new System.Drawing.Point(46, 97);
            this.teacherInfobtn.Name = "teacherInfobtn";
            this.teacherInfobtn.Size = new System.Drawing.Size(179, 31);
            this.teacherInfobtn.TabIndex = 7;
            this.teacherInfobtn.Text = "Teacher Information";
            this.teacherInfobtn.UseVisualStyleBackColor = true;
            this.teacherInfobtn.Click += new System.EventHandler(this.teacherInfobtn_Click);
            // 
            // billmakingbtn
            // 
            this.billmakingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billmakingbtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.billmakingbtn.Location = new System.Drawing.Point(46, 39);
            this.billmakingbtn.Name = "billmakingbtn";
            this.billmakingbtn.Size = new System.Drawing.Size(179, 31);
            this.billmakingbtn.TabIndex = 6;
            this.billmakingbtn.Text = "Bill  Making";
            this.billmakingbtn.UseVisualStyleBackColor = true;
            this.billmakingbtn.Click += new System.EventHandler(this.billmakingbtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.logoutbtn);
            this.groupBox4.Controls.Add(this.backbtn);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox4.Location = new System.Drawing.Point(121, 344);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(192, 73);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Back/Logout";
            // 
            // logoutbtn
            // 
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.logoutbtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutbtn.Image")));
            this.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.logoutbtn.Location = new System.Drawing.Point(106, 28);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(80, 28);
            this.logoutbtn.TabIndex = 21;
            this.logoutbtn.Text = "Exit";
            this.logoutbtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.backbtn.Location = new System.Drawing.Point(13, 28);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 28);
            this.backbtn.TabIndex = 20;
            this.backbtn.Text = "Back";
            this.backbtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // AccountingSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::print.Properties.Resources.green__5_;
            this.ClientSize = new System.Drawing.Size(463, 457);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "AccountingSection";
            this.Text = "AccountingSection";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button teacherInfobtn;
        private System.Windows.Forms.Button billmakingbtn;
    }
}