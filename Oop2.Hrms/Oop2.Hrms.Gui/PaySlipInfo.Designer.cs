namespace Oop2.Hrms.Gui
{
    partial class PaySlipInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanal4 = new MetroFramework.Controls.MetroPanel();
            this.txtBoxDeduction = new MetroFramework.Controls.MetroTextBox();
            this.lblDeduction = new MetroFramework.Controls.MetroLabel();
            this.txtBoxAdd = new MetroFramework.Controls.MetroTextBox();
            this.lblAdd = new MetroFramework.Controls.MetroLabel();
            this.txtBoxMedical = new MetroFramework.Controls.MetroTextBox();
            this.lblMedical = new MetroFramework.Controls.MetroLabel();
            this.txtBoxHouse = new MetroFramework.Controls.MetroTextBox();
            this.lblHouse = new MetroFramework.Controls.MetroLabel();
            this.txtBoxBasic = new MetroFramework.Controls.MetroTextBox();
            this.lblBasic = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtBoxID = new MetroFramework.Controls.MetroTextBox();
            this.lblID = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPan = new MetroFramework.Controls.MetroPanel();
            this.dgvPaySlipList = new MetroFramework.Controls.MetroGrid();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPayrollID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBasic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRemain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.mbtnSearch = new MetroFramework.Controls.MetroButton();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.btnDel = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.ddlEmpID = new MetroFramework.Controls.MetroComboBox();
            this.ddlPayRolID = new MetroFramework.Controls.MetroComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.metroPanal4.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.dgvPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaySlipList)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1371, 798);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.metroPanal4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.metroPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(974, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(394, 792);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // metroPanal4
            // 
            this.metroPanal4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanal4.Controls.Add(this.ddlPayRolID);
            this.metroPanal4.Controls.Add(this.ddlEmpID);
            this.metroPanal4.Controls.Add(this.txtBoxDeduction);
            this.metroPanal4.Controls.Add(this.lblDeduction);
            this.metroPanal4.Controls.Add(this.txtBoxAdd);
            this.metroPanal4.Controls.Add(this.lblAdd);
            this.metroPanal4.Controls.Add(this.txtBoxMedical);
            this.metroPanal4.Controls.Add(this.lblMedical);
            this.metroPanal4.Controls.Add(this.txtBoxHouse);
            this.metroPanal4.Controls.Add(this.lblHouse);
            this.metroPanal4.Controls.Add(this.txtBoxBasic);
            this.metroPanal4.Controls.Add(this.lblBasic);
            this.metroPanal4.Controls.Add(this.metroLabel1);
            this.metroPanal4.Controls.Add(this.txtBoxID);
            this.metroPanal4.Controls.Add(this.lblID);
            this.metroPanal4.Controls.Add(this.lblName);
            this.metroPanal4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanal4.HorizontalScrollbarBarColor = true;
            this.metroPanal4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanal4.HorizontalScrollbarSize = 10;
            this.metroPanal4.Location = new System.Drawing.Point(3, 53);
            this.metroPanal4.Name = "metroPanal4";
            this.metroPanal4.Size = new System.Drawing.Size(388, 736);
            this.metroPanal4.TabIndex = 0;
            this.metroPanal4.VerticalScrollbarBarColor = true;
            this.metroPanal4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanal4.VerticalScrollbarSize = 10;
            // 
            // txtBoxDeduction
            // 
            // 
            // 
            // 
            this.txtBoxDeduction.CustomButton.Image = null;
            this.txtBoxDeduction.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtBoxDeduction.CustomButton.Name = "";
            this.txtBoxDeduction.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtBoxDeduction.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxDeduction.CustomButton.TabIndex = 1;
            this.txtBoxDeduction.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxDeduction.CustomButton.UseSelectable = true;
            this.txtBoxDeduction.CustomButton.Visible = false;
            this.txtBoxDeduction.Lines = new string[0];
            this.txtBoxDeduction.Location = new System.Drawing.Point(149, 434);
            this.txtBoxDeduction.MaxLength = 32767;
            this.txtBoxDeduction.Multiline = true;
            this.txtBoxDeduction.Name = "txtBoxDeduction";
            this.txtBoxDeduction.PasswordChar = '\0';
            this.txtBoxDeduction.PromptText = "Deduction";
            this.txtBoxDeduction.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxDeduction.SelectedText = "";
            this.txtBoxDeduction.SelectionLength = 0;
            this.txtBoxDeduction.SelectionStart = 0;
            this.txtBoxDeduction.ShortcutsEnabled = true;
            this.txtBoxDeduction.Size = new System.Drawing.Size(231, 40);
            this.txtBoxDeduction.TabIndex = 24;
            this.txtBoxDeduction.UseSelectable = true;
            this.txtBoxDeduction.WaterMark = "Deduction";
            this.txtBoxDeduction.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxDeduction.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDeduction
            // 
            this.lblDeduction.AutoSize = true;
            this.lblDeduction.Location = new System.Drawing.Point(42, 434);
            this.lblDeduction.Name = "lblDeduction";
            this.lblDeduction.Size = new System.Drawing.Size(76, 20);
            this.lblDeduction.TabIndex = 23;
            this.lblDeduction.Text = "Deduction:";
            // 
            // txtBoxAdd
            // 
            // 
            // 
            // 
            this.txtBoxAdd.CustomButton.Image = null;
            this.txtBoxAdd.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtBoxAdd.CustomButton.Name = "";
            this.txtBoxAdd.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtBoxAdd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxAdd.CustomButton.TabIndex = 1;
            this.txtBoxAdd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxAdd.CustomButton.UseSelectable = true;
            this.txtBoxAdd.CustomButton.Visible = false;
            this.txtBoxAdd.Lines = new string[0];
            this.txtBoxAdd.Location = new System.Drawing.Point(149, 378);
            this.txtBoxAdd.MaxLength = 32767;
            this.txtBoxAdd.Multiline = true;
            this.txtBoxAdd.Name = "txtBoxAdd";
            this.txtBoxAdd.PasswordChar = '\0';
            this.txtBoxAdd.PromptText = "Addition";
            this.txtBoxAdd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxAdd.SelectedText = "";
            this.txtBoxAdd.SelectionLength = 0;
            this.txtBoxAdd.SelectionStart = 0;
            this.txtBoxAdd.ShortcutsEnabled = true;
            this.txtBoxAdd.Size = new System.Drawing.Size(231, 40);
            this.txtBoxAdd.TabIndex = 22;
            this.txtBoxAdd.UseSelectable = true;
            this.txtBoxAdd.WaterMark = "Addition";
            this.txtBoxAdd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxAdd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(55, 378);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(63, 20);
            this.lblAdd.TabIndex = 21;
            this.lblAdd.Text = "Addition:";
            // 
            // txtBoxMedical
            // 
            // 
            // 
            // 
            this.txtBoxMedical.CustomButton.Image = null;
            this.txtBoxMedical.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtBoxMedical.CustomButton.Name = "";
            this.txtBoxMedical.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtBoxMedical.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxMedical.CustomButton.TabIndex = 1;
            this.txtBoxMedical.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxMedical.CustomButton.UseSelectable = true;
            this.txtBoxMedical.CustomButton.Visible = false;
            this.txtBoxMedical.Lines = new string[0];
            this.txtBoxMedical.Location = new System.Drawing.Point(149, 322);
            this.txtBoxMedical.MaxLength = 32767;
            this.txtBoxMedical.Multiline = true;
            this.txtBoxMedical.Name = "txtBoxMedical";
            this.txtBoxMedical.PasswordChar = '\0';
            this.txtBoxMedical.PromptText = "Medical Facilities";
            this.txtBoxMedical.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxMedical.SelectedText = "";
            this.txtBoxMedical.SelectionLength = 0;
            this.txtBoxMedical.SelectionStart = 0;
            this.txtBoxMedical.ShortcutsEnabled = true;
            this.txtBoxMedical.Size = new System.Drawing.Size(231, 40);
            this.txtBoxMedical.TabIndex = 20;
            this.txtBoxMedical.UseSelectable = true;
            this.txtBoxMedical.WaterMark = "Medical Facilities";
            this.txtBoxMedical.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxMedical.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMedical
            // 
            this.lblMedical.AutoSize = true;
            this.lblMedical.Location = new System.Drawing.Point(4, 322);
            this.lblMedical.Name = "lblMedical";
            this.lblMedical.Size = new System.Drawing.Size(114, 20);
            this.lblMedical.TabIndex = 19;
            this.lblMedical.Text = "Medical Facilities:";
            // 
            // txtBoxHouse
            // 
            // 
            // 
            // 
            this.txtBoxHouse.CustomButton.Image = null;
            this.txtBoxHouse.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtBoxHouse.CustomButton.Name = "";
            this.txtBoxHouse.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtBoxHouse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxHouse.CustomButton.TabIndex = 1;
            this.txtBoxHouse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxHouse.CustomButton.UseSelectable = true;
            this.txtBoxHouse.CustomButton.Visible = false;
            this.txtBoxHouse.Lines = new string[0];
            this.txtBoxHouse.Location = new System.Drawing.Point(149, 263);
            this.txtBoxHouse.MaxLength = 32767;
            this.txtBoxHouse.Multiline = true;
            this.txtBoxHouse.Name = "txtBoxHouse";
            this.txtBoxHouse.PasswordChar = '\0';
            this.txtBoxHouse.PromptText = "House Allowance";
            this.txtBoxHouse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxHouse.SelectedText = "";
            this.txtBoxHouse.SelectionLength = 0;
            this.txtBoxHouse.SelectionStart = 0;
            this.txtBoxHouse.ShortcutsEnabled = true;
            this.txtBoxHouse.Size = new System.Drawing.Size(231, 40);
            this.txtBoxHouse.TabIndex = 18;
            this.txtBoxHouse.UseSelectable = true;
            this.txtBoxHouse.WaterMark = "House Allowance";
            this.txtBoxHouse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxHouse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.Location = new System.Drawing.Point(-1, 263);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(119, 20);
            this.lblHouse.TabIndex = 17;
            this.lblHouse.Text = "House Allowance:";
            // 
            // txtBoxBasic
            // 
            // 
            // 
            // 
            this.txtBoxBasic.CustomButton.Image = null;
            this.txtBoxBasic.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtBoxBasic.CustomButton.Name = "";
            this.txtBoxBasic.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtBoxBasic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxBasic.CustomButton.TabIndex = 1;
            this.txtBoxBasic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxBasic.CustomButton.UseSelectable = true;
            this.txtBoxBasic.CustomButton.Visible = false;
            this.txtBoxBasic.Lines = new string[0];
            this.txtBoxBasic.Location = new System.Drawing.Point(149, 200);
            this.txtBoxBasic.MaxLength = 32767;
            this.txtBoxBasic.Multiline = true;
            this.txtBoxBasic.Name = "txtBoxBasic";
            this.txtBoxBasic.PasswordChar = '\0';
            this.txtBoxBasic.PromptText = "Basic";
            this.txtBoxBasic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxBasic.SelectedText = "";
            this.txtBoxBasic.SelectionLength = 0;
            this.txtBoxBasic.SelectionStart = 0;
            this.txtBoxBasic.ShortcutsEnabled = true;
            this.txtBoxBasic.Size = new System.Drawing.Size(231, 40);
            this.txtBoxBasic.TabIndex = 16;
            this.txtBoxBasic.UseSelectable = true;
            this.txtBoxBasic.WaterMark = "Basic";
            this.txtBoxBasic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxBasic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Location = new System.Drawing.Point(75, 200);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(43, 20);
            this.lblBasic.TabIndex = 15;
            this.lblBasic.Text = "Basic:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(49, 138);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 20);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Payroll ID:";
            // 
            // txtBoxID
            // 
            // 
            // 
            // 
            this.txtBoxID.CustomButton.Image = null;
            this.txtBoxID.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtBoxID.CustomButton.Name = "";
            this.txtBoxID.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtBoxID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxID.CustomButton.TabIndex = 1;
            this.txtBoxID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxID.CustomButton.UseSelectable = true;
            this.txtBoxID.CustomButton.Visible = false;
            this.txtBoxID.Lines = new string[0];
            this.txtBoxID.Location = new System.Drawing.Point(149, 18);
            this.txtBoxID.MaxLength = 32767;
            this.txtBoxID.Multiline = true;
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.PasswordChar = '\0';
            this.txtBoxID.PromptText = "ID";
            this.txtBoxID.ReadOnly = true;
            this.txtBoxID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxID.SelectedText = "";
            this.txtBoxID.SelectionLength = 0;
            this.txtBoxID.SelectionStart = 0;
            this.txtBoxID.ShortcutsEnabled = true;
            this.txtBoxID.Size = new System.Drawing.Size(231, 40);
            this.txtBoxID.TabIndex = 11;
            this.txtBoxID.UseSelectable = true;
            this.txtBoxID.WaterMark = "ID";
            this.txtBoxID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(93, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 20);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Employee ID:";
            // 
            // metroPanel5
            // 
            this.metroPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel5.Controls.Add(this.btnSave);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(3, 3);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(388, 44);
            this.metroPanel5.TabIndex = 1;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgvPan, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(965, 792);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dgvPan
            // 
            this.dgvPan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvPan.Controls.Add(this.dgvPaySlipList);
            this.dgvPan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPan.HorizontalScrollbarBarColor = true;
            this.dgvPan.HorizontalScrollbarHighlightOnWheel = false;
            this.dgvPan.HorizontalScrollbarSize = 10;
            this.dgvPan.Location = new System.Drawing.Point(3, 53);
            this.dgvPan.Name = "dgvPan";
            this.dgvPan.Size = new System.Drawing.Size(959, 736);
            this.dgvPan.TabIndex = 0;
            this.dgvPan.VerticalScrollbarBarColor = true;
            this.dgvPan.VerticalScrollbarHighlightOnWheel = false;
            this.dgvPan.VerticalScrollbarSize = 10;
            // 
            // dgvPaySlipList
            // 
            this.dgvPaySlipList.AllowUserToAddRows = false;
            this.dgvPaySlipList.AllowUserToDeleteRows = false;
            this.dgvPaySlipList.AllowUserToResizeRows = false;
            this.dgvPaySlipList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPaySlipList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPaySlipList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPaySlipList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaySlipList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaySlipList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaySlipList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvEmpID,
            this.dgvPayrollID,
            this.dgvBasic,
            this.dgvTotal,
            this.dgvRemain});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaySlipList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPaySlipList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaySlipList.EnableHeadersVisualStyles = false;
            this.dgvPaySlipList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPaySlipList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPaySlipList.Location = new System.Drawing.Point(0, 0);
            this.dgvPaySlipList.MultiSelect = false;
            this.dgvPaySlipList.Name = "dgvPaySlipList";
            this.dgvPaySlipList.ReadOnly = true;
            this.dgvPaySlipList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaySlipList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPaySlipList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPaySlipList.RowTemplate.Height = 24;
            this.dgvPaySlipList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaySlipList.Size = new System.Drawing.Size(957, 734);
            this.dgvPaySlipList.TabIndex = 2;
            this.dgvPaySlipList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeptList_CellClick);
            this.dgvPaySlipList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeptList_CellContentClick);
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "ID";
            this.dgvID.HeaderText = "ID";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            // 
            // dgvEmpID
            // 
            this.dgvEmpID.DataPropertyName = "EmployeeID";
            this.dgvEmpID.HeaderText = "Employee ID";
            this.dgvEmpID.Name = "dgvEmpID";
            this.dgvEmpID.ReadOnly = true;
            // 
            // dgvPayrollID
            // 
            this.dgvPayrollID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvPayrollID.DataPropertyName = "PayrolID";
            this.dgvPayrollID.HeaderText = "Payroll ID";
            this.dgvPayrollID.Name = "dgvPayrollID";
            this.dgvPayrollID.ReadOnly = true;
            // 
            // dgvBasic
            // 
            this.dgvBasic.DataPropertyName = "Basic";
            this.dgvBasic.HeaderText = "Basic";
            this.dgvBasic.Name = "dgvBasic";
            this.dgvBasic.ReadOnly = true;
            // 
            // dgvTotal
            // 
            this.dgvTotal.DataPropertyName = "isTotal";
            this.dgvTotal.HeaderText = "Total";
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.ReadOnly = true;
            // 
            // dgvRemain
            // 
            this.dgvRemain.DataPropertyName = "isRemain";
            this.dgvRemain.HeaderText = "Remain";
            this.dgvRemain.Name = "dgvRemain";
            this.dgvRemain.ReadOnly = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.txtSearch);
            this.metroPanel3.Controls.Add(this.mbtnSearch);
            this.metroPanel3.Controls.Add(this.btnRefresh);
            this.metroPanel3.Controls.Add(this.btnDel);
            this.metroPanel3.Controls.Add(this.btnNew);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(3, 3);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(959, 44);
            this.metroPanel3.TabIndex = 1;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(394, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(352, 3);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(426, 34);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnSearch
            // 
            this.mbtnSearch.Location = new System.Drawing.Point(797, 3);
            this.mbtnSearch.Name = "mbtnSearch";
            this.mbtnSearch.Size = new System.Drawing.Size(90, 34);
            this.mbtnSearch.TabIndex = 5;
            this.mbtnSearch.Text = "Search";
            this.mbtnSearch.UseSelectable = true;
            this.mbtnSearch.Click += new System.EventHandler(this.mbtnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(218, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 34);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(111, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(90, 34);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete";
            this.btnDel.UseSelectable = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(90, 34);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ddlEmpID
            // 
            this.ddlEmpID.FormattingEnabled = true;
            this.ddlEmpID.ItemHeight = 24;
            this.ddlEmpID.Location = new System.Drawing.Point(149, 75);
            this.ddlEmpID.Name = "ddlEmpID";
            this.ddlEmpID.Size = new System.Drawing.Size(231, 30);
            this.ddlEmpID.TabIndex = 25;
            this.ddlEmpID.UseSelectable = true;
            // 
            // ddlPayRolID
            // 
            this.ddlPayRolID.FormattingEnabled = true;
            this.ddlPayRolID.ItemHeight = 24;
            this.ddlPayRolID.Location = new System.Drawing.Point(149, 138);
            this.ddlPayRolID.Name = "ddlPayRolID";
            this.ddlPayRolID.Size = new System.Drawing.Size(231, 30);
            this.ddlPayRolID.TabIndex = 26;
            this.ddlPayRolID.UseSelectable = true;
            // 
            // PaySlipInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 798);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PaySlipInfo";
            this.Text = "Pay Slip Info";
            this.Load += new System.EventHandler(this.PaySlip_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.metroPanal4.ResumeLayout(false);
            this.metroPanal4.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.dgvPan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaySlipList)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroPanel metroPanal4;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroPanel dgvPan;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblID;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton mbtnSearch;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroButton btnDel;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroTextBox txtBoxID;
        private MetroFramework.Controls.MetroGrid dgvPaySlipList;
        private MetroFramework.Controls.MetroTextBox txtBoxDeduction;
        private MetroFramework.Controls.MetroLabel lblDeduction;
        private MetroFramework.Controls.MetroTextBox txtBoxAdd;
        private MetroFramework.Controls.MetroLabel lblAdd;
        private MetroFramework.Controls.MetroTextBox txtBoxMedical;
        private MetroFramework.Controls.MetroLabel lblMedical;
        private MetroFramework.Controls.MetroTextBox txtBoxHouse;
        private MetroFramework.Controls.MetroLabel lblHouse;
        private MetroFramework.Controls.MetroTextBox txtBoxBasic;
        private MetroFramework.Controls.MetroLabel lblBasic;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPayrollID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBasic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRemain;
        private MetroFramework.Controls.MetroComboBox ddlPayRolID;
        private MetroFramework.Controls.MetroComboBox ddlEmpID;
    }
}