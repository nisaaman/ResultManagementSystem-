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
    public partial class AccountingSection : Form
    {
        public AccountingSection()
        {
            InitializeComponent();
        }

    private void teacherInfobtn_Click(object sender, EventArgs e)
        {
            TeacherInformationInput t = new TeacherInformationInput();
            t.Show();
            this.Hide();
        }

    private void billmakingbtn_Click(object sender, EventArgs e)
    {
        BillMakingForm b = new BillMakingForm();
        b.Show();
        this.Hide();

    }

    private void backbtn_Click(object sender, EventArgs e)
    {
        Overview f2 = new Overview();
        f2.Show();
        this.Hide();
    }

    private void logoutbtn_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
    }
}
