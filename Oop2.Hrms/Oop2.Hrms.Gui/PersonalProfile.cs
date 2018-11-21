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
using Oop2.Hrms.Framework;

namespace Oop2.Hrms.Gui
{
    public partial class PersonalProfile : Form
    {
        private HRDBEntities _context = new HRDBEntities();
       

        public PersonalProfile()
        {
            InitializeComponent();
        }

        private void PersonalSalaryPage_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        private void Init()
        {
            var employee = _context.EmployeeInfoes.FirstOrDefault(e => e.ID == LoginHelper.UserID);
            if (employee == null)
                return;

            txtBoxID.Text = employee.ID.ToString();
            txtBoxFn.Text = employee.UserInfo.FirstName;
            txtBoxLn.Text = employee.UserInfo.LastName;
            txtboxEmail.Text = employee.UserInfo.Email;
            txtBoxPhone.Text = employee.UserInfo.Phone;
            txtBoxDOB.Text = employee.UserInfo.DOB.ToString();
            txtBoxJoin.Text = employee.JoinDate.ToString();
            txtBoxGender.Text = employee.UserInfo.Gender;
            txtBoxDesig.Text = employee.DesiInfo.Name.ToString();
            txtBoxDept.Text = employee.DeptInfo.Name.ToString();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
