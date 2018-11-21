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

namespace Oop2.Hrms.Gui
{
    public partial class PaySlipInfo : Form
    {
        HRDBEntities _context = new HRDBEntities();
        PaySlipBL _paySlipBL = new PaySlipBL();
        List<PaySlip> _paySlipInfos = new List<PaySlip>();
        PaySlip _selectedPaySlip = null;
        private int _selectIndex = 0;

        public PaySlipInfo()
        {
            InitializeComponent();
        }

        private void PaySlip_Load(object sender, EventArgs e)
        {
            this.Init();
        }


        private void Init()
        {
            try
            {
                ddlEmpID.DataSource = _context.EmployeeInfoes.ToList();
                ddlEmpID.DisplayMember = "ID";
                ddlEmpID.ValueMember = "ID";


                ddlPayRolID.DataSource = _context.PayRols.ToList();
                ddlPayRolID.DisplayMember = "ID";
                ddlPayRolID.ValueMember = "ID";



                txtSearch.Text = "";
                this.loadPaySlip();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void loadPaySlip()
        {
            _paySlipInfos = _paySlipBL.GetAll(txtSearch.Text);

            if (_paySlipInfos.Count > 0)
            {
                _selectedPaySlip = _paySlipInfos[0];
                _selectIndex = 0;

            }
            else
            {
                _selectedPaySlip = new PaySlip();
            }
            this.Populate();
            this.RefreshDgv();
        }


        private void Populate()
        {
            txtBoxID.Text = _selectedPaySlip.ID.ToString();
            ddlEmpID.SelectedValue = _selectedPaySlip.EmployeeID;
            ddlPayRolID.SelectedValue = _selectedPaySlip.PayrolID;
            txtBoxBasic.Text = _selectedPaySlip.Basic.ToString();
            txtBoxHouse.Text = _selectedPaySlip.HouseAlignment.ToString();
            txtBoxMedical.Text = _selectedPaySlip.MedicalFacilities.ToString();
            txtBoxAdd.Text = _selectedPaySlip.Addition.ToString();
            txtBoxDeduction.Text = _selectedPaySlip.Deduction.ToString();
        }

        private void RefreshDgv()
        {
            dgvPaySlipList.AutoGenerateColumns = false;
            dgvPaySlipList.DataSource = _paySlipInfos.ToList();
            dgvPaySlipList.Refresh();

            dgvPaySlipList.ClearSelection();

            for (int i = 0; i < dgvPaySlipList.Rows.Count; i++)
            {
                if (dgvPaySlipList.Rows[i].Cells[0].Value.ToString() == _selectedPaySlip.ID.ToString())
                {
                    dgvPaySlipList.Rows[i].Selected = true;
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
            this.loadPaySlip();
        }

        private void dgvDeptList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedPaySlip = _paySlipInfos[e.RowIndex];
                _selectIndex = e.RowIndex;
                this.Populate();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _selectedPaySlip = new PaySlip();
            this.Populate();
            dgvPaySlipList.ClearSelection();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (_selectedPaySlip.ID == 0)
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
            if (_paySlipBL.Delete(_selectedPaySlip.ID, out error) == false)
            {
                MetroFramework.MetroMessageBox.Show(this, error);
                return;
            }

            _paySlipInfos.Remove(_selectedPaySlip);
            this.RefreshDgv();
            MetroFramework.MetroMessageBox.Show(this, "Operation Completed.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedPaySlip.EmployeeID = Int32.Parse(ddlEmpID.SelectedValue.ToString());
                _selectedPaySlip.PayrolID = Int32.Parse(ddlPayRolID.SelectedText.ToString());
                _selectedPaySlip.Basic = Int32.Parse(lblBasic.Text);
                _selectedPaySlip.HouseAlignment = Int32.Parse(lblHouse.Text);
                _selectedPaySlip.MedicalFacilities = Int32.Parse(lblMedical.Text);
                _selectedPaySlip.Addition = Int32.Parse(lblAdd.Text);
                _selectedPaySlip.Deduction = Int32.Parse(lblDeduction.Text);

                bool isNew = _selectedPaySlip.ID == 0;

                string error;
                _selectedPaySlip = _paySlipBL.Save(_selectedPaySlip, out error);

                if (string.IsNullOrEmpty(error) == false)
                {
                    MetroFramework.MetroMessageBox.Show(this, error);
                    return;
                }

                this.Populate();

                if (isNew)
                    _paySlipInfos.Add(_selectedPaySlip);
                else
                {
                    _paySlipInfos[_selectIndex] = _selectedPaySlip;
                }

                MetroFramework.MetroMessageBox.Show(this, "Operation Completed");
                RefreshDgv();
            }
            catch (Exception exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Input is not correct");
            }
        }

        private void dgvDeptList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
