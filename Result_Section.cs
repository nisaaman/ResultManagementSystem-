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
    public partial class Result_Section : Form
    {
        public Result_Section()
        {
            InitializeComponent();
        }

       private void resultmakingbtn_Click(object sender, EventArgs e)
        {
            ResultMaking_Form f3 = new ResultMaking_Form();
            f3.Show();
            this.Hide();
        }

        private void stinfobtn_Click(object sender, EventArgs e)
        {
            Student_Info f1 = new Student_Info();
            f1.Show();
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

        private void Result_Section_Load(object sender, EventArgs e)
        {

        }

        private void CourseInfoBtn_Click(object sender, EventArgs e)
        {
            CourseCodeCourseTitleCreditHour c = new CourseCodeCourseTitleCreditHour();
            c.Show();
            this.Hide();
        }

      

     
       
    }
}
