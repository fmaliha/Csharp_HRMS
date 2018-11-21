using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oop2.Hrms.Data;

namespace Oop2.Hrms.Gui
{

    public partial class EmployeeHomePage : MetroFramework.Forms.MetroForm
    {
        HRDBEntities _context = new HRDBEntities();

        public EmployeeHomePage()
        {
            InitializeComponent();
        }

        private void EmployeePage1_Load(object sender, EventArgs e)
        {
            metroButton1.PerformClick();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            PersonalSalaryPage ei = new PersonalSalaryPage();
            ei.TopLevel = false;
            this.metroPanel2.Controls.Clear();
            this.metroPanel2.Controls.Add(ei);
            ei.FormBorderStyle = FormBorderStyle.None;
            ei.Dock = DockStyle.Fill;
            ei.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            PersonalPaySlip ei = new PersonalPaySlip();
            ei.TopLevel = false;
            this.metroPanel2.Controls.Clear();
            this.metroPanel2.Controls.Add(ei);
            ei.FormBorderStyle = FormBorderStyle.None;
            ei.Dock = DockStyle.Fill;
            ei.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            PersonalProfile ei = new PersonalProfile();
            ei.TopLevel = false;
            this.metroPanel2.Controls.Clear();
            this.metroPanel2.Controls.Add(ei);
            ei.FormBorderStyle = FormBorderStyle.None;
            ei.Dock = DockStyle.Fill;
            ei.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            LoginPage p=new LoginPage();
            p.Show();
            this.Hide();
        }
    }
}
