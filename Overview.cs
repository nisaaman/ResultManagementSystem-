using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace print
{
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
        }

        private void cmdExam_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdResult_Click(object sender, EventArgs e)
        {
            Result_Section f2 = new Result_Section();
            f2.Show();
            this.Hide();
        }

        private void Overview_Load(object sender, EventArgs e)
        {

        }

        private void cmdAccount_Click(object sender, EventArgs e)
        {
            AccountingSection n1 = new AccountingSection();
            n1.Show();
            this.Hide();
        }

        private void cmdCommunication_Click(object sender, EventArgs e)
        {
            TeacherInformationInput t1 = new TeacherInformationInput();
            t1.Show();
            this.Hide();
        }
    }
}
