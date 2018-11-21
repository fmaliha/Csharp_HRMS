using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oop2.Hrms.BL;
using Oop2.Hrms.Data;
using Oop2.Hrms.Framework;

namespace Oop2.Hrms.Gui
{
    public partial class EmpSalary : Form
    {
        private HRDBEntities _context = new HRDBEntities();
        EmployeeSalaryBL _employeeSalaryBL = new EmployeeSalaryBL();
        List<EmployeeSalary> _employeeSalaries = new List<EmployeeSalary>();
        EmployeeSalary _selectedEmployeeSalary = null;
        private int _selectIndex = 0;


        public EmpSalary()
        {
            InitializeComponent();
        }

        private void EmpSalary_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        private void Init()
        {
            try
            {
                ddlSalaryStatus.DataSource = EnumCollection.EmpSalaryStatusList();
                ddlSalaryStatus.DisplayMember = "Name";
                ddlSalaryStatus.ValueMember = "ID";

                ddlEmpID.DataSource = _context.EmployeeInfoes.ToList();
                ddlEmpID.DisplayMember = "ID";
                ddlEmpID.ValueMember = "ID";

                txtSearch.Text = "";

                this.loadEmpSalary();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void loadEmpSalary()
        {
            _employeeSalaries = _employeeSalaryBL.GetAll(txtSearch.Text);

            if (_employeeSalaries.Count > 0)
            {
                _selectedEmployeeSalary = _employeeSalaries[0];
                _selectIndex = 0;

            }
            else
            {
                _selectedEmployeeSalary = new EmployeeSalary();
            }
            this.Populate();
            this.RefreshDgv();
        }


        private void Populate()
        {
            txtBoxID.Text = _selectedEmployeeSalary.ID.ToString();
            ddlEmpID.SelectedValue = _selectedEmployeeSalary.EmployeeID;
            txtBoxBasic.Text = _selectedEmployeeSalary.Basic.ToString();
            txtboxHouse.Text = _selectedEmployeeSalary.HouseAlignment.ToString();
            txtBoxMedical.Text = _selectedEmployeeSalary.MedicalFacilities.ToString();
            ddlSalaryStatus.SelectedText = _selectedEmployeeSalary.IsCurrent.ToString();

        }

        private void RefreshDgv()
        {
            dgvEmployeeSal.AutoGenerateColumns = false;
            dgvEmployeeSal.DataSource = _employeeSalaries.ToList();
            dgvEmployeeSal.Refresh();

            dgvEmployeeSal.ClearSelection();

            for (int i = 0; i < dgvEmployeeSal.Rows.Count; i++)
            {
                if (dgvEmployeeSal.Rows[i].Cells[0].Value.ToString() == _selectedEmployeeSalary.ID.ToString())
                {
                    dgvEmployeeSal.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Init();

        }

        private void mbtnSearch_Click(object sender, EventArgs e)
        {
            this.loadEmpSalary();
        }

        private void dgvEmployeeSal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedEmployeeSalary = _employeeSalaries[e.RowIndex];
                _selectIndex = e.RowIndex;
                this.Populate();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _selectedEmployeeSalary=new EmployeeSalary();
            this.Populate();
            dgvEmployeeSal.ClearSelection();
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (_selectedEmployeeSalary.ID == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Select A Row First");
                return;
            }

            if (MetroFramework.MetroMessageBox.Show(this, "Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) ==
                DialogResult.No)
            {
                return;
            }

            string error;
            if (_employeeSalaryBL.Delete(_selectedEmployeeSalary.ID, out error) == false)
            {
                MetroFramework.MetroMessageBox.Show(this, error);
                return;
            }

            _employeeSalaries.Remove(_selectedEmployeeSalary);
            this.RefreshDgv();
            MetroFramework.MetroMessageBox.Show(this, "Operation Completed.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedEmployeeSalary.EmployeeID = Int32.Parse(ddlEmpID.SelectedValue.ToString());
                _selectedEmployeeSalary.HouseAlignment = Int32.Parse(txtboxHouse.Text);
                _selectedEmployeeSalary.Basic = Int32.Parse(txtBoxBasic.Text);
                _selectedEmployeeSalary.MedicalFacilities = Int32.Parse(txtBoxMedical.Text);
                _selectedEmployeeSalary.IsCurrent = ddlSalaryStatus.SelectedValue.ToString().Equals("1");

                bool isNew = _selectedEmployeeSalary.ID == 0;

                string error;
                _selectedEmployeeSalary = _employeeSalaryBL.Save(_selectedEmployeeSalary, out error);

                if (string.IsNullOrEmpty(error) == false)
                {
                    MetroFramework.MetroMessageBox.Show(this, error);
                    return;
                }

                this.Populate();

                if (isNew)
                    _employeeSalaries.Add(_selectedEmployeeSalary);
                else
                {
                    _employeeSalaries[_selectIndex] = _selectedEmployeeSalary;
                }

                MetroFramework.MetroMessageBox.Show(this, "Operation Completed");
                RefreshDgv();
            }
            catch (Exception exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Input is not correct");
            }
        }

        private void dgvEmployeeSal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroPanal4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
