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
    public partial class PayRolInfo : Form
    {
        HRDBEntities _context = new HRDBEntities();
        PayRolBL _payRolBL = new PayRolBL();
        List<PayRol> _payRols = new List<PayRol>();
        PayRol _selectedPayRol = null;
        private int _selectIndex = 0;

        public PayRolInfo()
        {
            InitializeComponent();
        }

        private void PayRol_Load(object sender, EventArgs e)
        {
            this.Init();
        }


        private void Init()
        {
            try
            {
                txtSearch.Text = "";
                this.loadPayRol();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void loadPayRol()
        {
            _payRols = _payRolBL.GetAll(txtSearch.Text);

            if (_payRols.Count > 0)
            {
                _selectedPayRol = _payRols[0];
                _selectIndex = 0;

            }
            else
            {
                _selectedPayRol = new PayRol();
            }
            this.Populate();
            this.RefreshDgv();
        }


        private void Populate()
        {
            txtBoxID.Text = _selectedPayRol.ID.ToString();
            txtBoxName.Text = _selectedPayRol.Name;
            txtBoxMonth.Text = _selectedPayRol.Month.ToString();
            txtBoxYear.Text = _selectedPayRol.Year.ToString();
        }

        private void RefreshDgv()
        {
            dgvPayRolList.AutoGenerateColumns = false;
            dgvPayRolList.DataSource = _payRols.ToList();
            dgvPayRolList.Refresh();

            dgvPayRolList.ClearSelection();

            for (int i = 0; i < dgvPayRolList.Rows.Count; i++)
            {
                if (dgvPayRolList.Rows[i].Cells[0].Value.ToString() == _selectedPayRol.ID.ToString())
                {
                    dgvPayRolList.Rows[i].Selected = true;
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
            this.loadPayRol();
        }

        private void dgvDeptList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedPayRol = _payRols[e.RowIndex];
                _selectIndex = e.RowIndex;
                this.Populate();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _selectedPayRol = new PayRol();
            this.Populate();
            dgvPayRolList.ClearSelection();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (_selectedPayRol.ID == 0)
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
            if (_payRolBL.Delete(_selectedPayRol.ID, out error) == false)
            {
                MetroFramework.MetroMessageBox.Show(this, error);
                return;
            }

            _payRols.Remove(_selectedPayRol);
            this.RefreshDgv();
            MetroFramework.MetroMessageBox.Show(this, "Operation Completed.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedPayRol.Name = txtBoxName.Text;
                _selectedPayRol.Month = Int32.Parse(txtBoxMonth.Text);
                _selectedPayRol.Year = Int32.Parse(txtBoxYear.Text);

                bool isNew = _selectedPayRol.ID == 0;

                string error;
                _selectedPayRol = _payRolBL.Save(_selectedPayRol, out error);

                if (string.IsNullOrEmpty(error) == false)
                {
                    MetroFramework.MetroMessageBox.Show(this, error);
                    return;
                }

                this.Populate();

                if (isNew)
                    _payRols.Add(_selectedPayRol);
                else
                {
                    _payRols[_selectIndex] = _selectedPayRol;
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
