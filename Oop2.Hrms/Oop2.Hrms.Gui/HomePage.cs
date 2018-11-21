using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oop2.Hrms.Gui
{
    public partial class HomePage : MetroFramework.Forms.MetroForm
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            menuStripHome.PerformClick();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpInfo ei = new EmpInfo();
            ei.TopLevel = false;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(ei);
            ei.FormBorderStyle = FormBorderStyle.None;
            ei.Dock = DockStyle.Fill;
            ei.Show();
        }

        private void employeeSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpSalary ei = new EmpSalary();
            ei.TopLevel = false;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(ei);
            ei.FormBorderStyle = FormBorderStyle.None;
            ei.Dock = DockStyle.Fill;
            ei.Show();
        }

        private void paySlipToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PaySlipInfo ei = new PaySlipInfo();
            ei.TopLevel = false;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(ei);
            ei.FormBorderStyle = FormBorderStyle.None;
            ei.Dock = DockStyle.Fill;
            ei.Show();
        }

        private void departmentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DepartmentInfo ei = new DepartmentInfo();
            ei.TopLevel = false;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(ei);
            ei.FormBorderStyle = FormBorderStyle.None;
            ei.Dock = DockStyle.Fill;
            ei.Show();
        }

        private void designationInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DesignationInfo ei = new DesignationInfo();
            ei.TopLevel = false;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(ei);
            ei.FormBorderStyle = FormBorderStyle.None;
            ei.Dock = DockStyle.Fill;
            ei.Show();
        }

        private void payrollToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PayRolInfo ei = new PayRolInfo();
            ei.TopLevel = false;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(ei);
            ei.FormBorderStyle = FormBorderStyle.None;
            ei.Dock = DockStyle.Fill;
            ei.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage p = new LoginPage();
            p.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AdminHomeImage ei = new AdminHomeImage();
            ei.TopLevel = false;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(ei);
            ei.FormBorderStyle = FormBorderStyle.None;
            ei.Dock = DockStyle.Fill;
            ei.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
