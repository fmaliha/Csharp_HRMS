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
    public partial class PersonalSalaryPage : Form
    {
        private HRDBEntities _context = new HRDBEntities();
        public PersonalSalaryPage()
        {
            InitializeComponent();
        }

        private void PersonalSalaryPage_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        private void Init()
        {
            dgvEmployeeSal.AutoGenerateColumns = false;
            dgvEmployeeSal.DataSource = _context.EmployeeSalaries.Where(e=>e.EmployeeID==LoginHelper.UserID).ToList();
            dgvEmployeeSal.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
