namespace FoodShop
{
    partial class frm_ManageEmployees
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
            this.tab_Employee = new System.Windows.Forms.TabControl();
            this.tab_Employees = new System.Windows.Forms.TabPage();
            this.grd_employees = new System.Windows.Forms.DataGridView();
            this.lbl_productList = new System.Windows.Forms.Label();
            this.txt_searchBox = new System.Windows.Forms.TextBox();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_exitToMenu = new System.Windows.Forms.Button();
            this.btn_exitApplication = new System.Windows.Forms.Button();
            this.tab_manageEmployees = new System.Windows.Forms.TabPage();
            this.dtm_dateHired = new System.Windows.Forms.DateTimePicker();
            this.txt_employeeID = new System.Windows.Forms.TextBox();
            this.lbl_employeeID = new System.Windows.Forms.Label();
            this.HireDateCal = new System.Windows.Forms.MonthCalendar();
            this.btn_save = new System.Windows.Forms.Button();
            this.rdo_isActive = new System.Windows.Forms.RadioButton();
            this.lbl_hireDate = new System.Windows.Forms.Label();
            this.btn_tabExitToMenu = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.pnl_salary = new System.Windows.Forms.Panel();
            this.gbx_shiftType = new System.Windows.Forms.GroupBox();
            this.rdo_fullTime = new System.Windows.Forms.RadioButton();
            this.rdo_partTime = new System.Windows.Forms.RadioButton();
            this.gbx_payType = new System.Windows.Forms.GroupBox();
            this.rdo_hourly = new System.Windows.Forms.RadioButton();
            this.rdo_salary = new System.Windows.Forms.RadioButton();
            this.lbl_rateOfPay = new System.Windows.Forms.Label();
            this.txt_rateOfPay = new System.Windows.Forms.TextBox();
            this.cmb_shift = new System.Windows.Forms.ComboBox();
            this.lbl_shift = new System.Windows.Forms.Label();
            this.lbl_position = new System.Windows.Forms.Label();
            this.cmb_position = new System.Windows.Forms.ComboBox();
            this.lbl_Last = new System.Windows.Forms.Label();
            this.lbl_first = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.btn_tabExitApp = new System.Windows.Forms.Button();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Employee.SuspendLayout();
            this.tab_Employees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_employees)).BeginInit();
            this.tab_manageEmployees.SuspendLayout();
            this.pnl_salary.SuspendLayout();
            this.gbx_shiftType.SuspendLayout();
            this.gbx_payType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Employee
            // 
            this.tab_Employee.Controls.Add(this.tab_Employees);
            this.tab_Employee.Controls.Add(this.tab_manageEmployees);
            this.tab_Employee.Location = new System.Drawing.Point(-8, 0);
            this.tab_Employee.Name = "tab_Employee";
            this.tab_Employee.SelectedIndex = 0;
            this.tab_Employee.Size = new System.Drawing.Size(1136, 505);
            this.tab_Employee.TabIndex = 1;
            // 
            // tab_Employees
            // 
            this.tab_Employees.Controls.Add(this.grd_employees);
            this.tab_Employees.Controls.Add(this.lbl_productList);
            this.tab_Employees.Controls.Add(this.txt_searchBox);
            this.tab_Employees.Controls.Add(this.btn_addNew);
            this.tab_Employees.Controls.Add(this.btn_select);
            this.tab_Employees.Controls.Add(this.btn_exitToMenu);
            this.tab_Employees.Controls.Add(this.btn_exitApplication);
            this.tab_Employees.Location = new System.Drawing.Point(4, 22);
            this.tab_Employees.Name = "tab_Employees";
            this.tab_Employees.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Employees.Size = new System.Drawing.Size(1128, 479);
            this.tab_Employees.TabIndex = 1;
            this.tab_Employees.Text = "View Employees";
            this.tab_Employees.UseVisualStyleBackColor = true;
            // 
            // grd_employees
            // 
            this.grd_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeID,
            this.employeeLast,
            this.employeeFirst,
            this.hireDate,
            this.salary,
            this.isActive,
            this.positionTitle,
            this.shiftID});
            this.grd_employees.Location = new System.Drawing.Point(6, 89);
            this.grd_employees.Name = "grd_employees";
            this.grd_employees.Size = new System.Drawing.Size(1083, 297);
            this.grd_employees.TabIndex = 20;
            this.grd_employees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_employees_CellContentClick);
            // 
            // lbl_productList
            // 
            this.lbl_productList.AutoSize = true;
            this.lbl_productList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productList.Location = new System.Drawing.Point(62, 38);
            this.lbl_productList.Name = "lbl_productList";
            this.lbl_productList.Size = new System.Drawing.Size(148, 31);
            this.lbl_productList.TabIndex = 19;
            this.lbl_productList.Text = "Employees";
            // 
            // txt_searchBox
            // 
            this.txt_searchBox.Location = new System.Drawing.Point(647, 30);
            this.txt_searchBox.Name = "txt_searchBox";
            this.txt_searchBox.Size = new System.Drawing.Size(100, 20);
            this.txt_searchBox.TabIndex = 18;
            this.txt_searchBox.Text = "Search";
            // 
            // btn_addNew
            // 
            this.btn_addNew.Location = new System.Drawing.Point(730, 423);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(90, 25);
            this.btn_addNew.TabIndex = 17;
            this.btn_addNew.Text = "Add Employee";
            this.btn_addNew.UseVisualStyleBackColor = true;
            this.btn_addNew.Click += new System.EventHandler(this.btn_addNew_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(610, 423);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 25);
            this.btn_select.TabIndex = 16;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_exitToMenu
            // 
            this.btn_exitToMenu.Location = new System.Drawing.Point(1014, 423);
            this.btn_exitToMenu.Name = "btn_exitToMenu";
            this.btn_exitToMenu.Size = new System.Drawing.Size(75, 25);
            this.btn_exitToMenu.TabIndex = 15;
            this.btn_exitToMenu.Text = "Exit to Menu";
            this.btn_exitToMenu.UseVisualStyleBackColor = true;
            this.btn_exitToMenu.Click += new System.EventHandler(this.btn_exitToMenu_Click);
            // 
            // btn_exitApplication
            // 
            this.btn_exitApplication.Location = new System.Drawing.Point(879, 423);
            this.btn_exitApplication.Name = "btn_exitApplication";
            this.btn_exitApplication.Size = new System.Drawing.Size(90, 25);
            this.btn_exitApplication.TabIndex = 14;
            this.btn_exitApplication.Text = "Exit Application";
            this.btn_exitApplication.UseVisualStyleBackColor = true;
            this.btn_exitApplication.Click += new System.EventHandler(this.btn_exitApplication_Click);
            // 
            // tab_manageEmployees
            // 
            this.tab_manageEmployees.Controls.Add(this.dtm_dateHired);
            this.tab_manageEmployees.Controls.Add(this.txt_employeeID);
            this.tab_manageEmployees.Controls.Add(this.lbl_employeeID);
            this.tab_manageEmployees.Controls.Add(this.HireDateCal);
            this.tab_manageEmployees.Controls.Add(this.btn_save);
            this.tab_manageEmployees.Controls.Add(this.rdo_isActive);
            this.tab_manageEmployees.Controls.Add(this.lbl_hireDate);
            this.tab_manageEmployees.Controls.Add(this.btn_tabExitToMenu);
            this.tab_manageEmployees.Controls.Add(this.btn_delete);
            this.tab_manageEmployees.Controls.Add(this.pnl_salary);
            this.tab_manageEmployees.Controls.Add(this.cmb_shift);
            this.tab_manageEmployees.Controls.Add(this.lbl_shift);
            this.tab_manageEmployees.Controls.Add(this.lbl_position);
            this.tab_manageEmployees.Controls.Add(this.cmb_position);
            this.tab_manageEmployees.Controls.Add(this.lbl_Last);
            this.tab_manageEmployees.Controls.Add(this.lbl_first);
            this.tab_manageEmployees.Controls.Add(this.txt_lastName);
            this.tab_manageEmployees.Controls.Add(this.txt_firstName);
            this.tab_manageEmployees.Controls.Add(this.btn_tabExitApp);
            this.tab_manageEmployees.Location = new System.Drawing.Point(4, 22);
            this.tab_manageEmployees.Name = "tab_manageEmployees";
            this.tab_manageEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tab_manageEmployees.Size = new System.Drawing.Size(1128, 479);
            this.tab_manageEmployees.TabIndex = 2;
            this.tab_manageEmployees.Text = "Manage Employees";
            this.tab_manageEmployees.UseVisualStyleBackColor = true;
            // 
            // dtm_dateHired
            // 
            this.dtm_dateHired.Location = new System.Drawing.Point(641, 61);
            this.dtm_dateHired.Name = "dtm_dateHired";
            this.dtm_dateHired.Size = new System.Drawing.Size(196, 20);
            this.dtm_dateHired.TabIndex = 67;
            // 
            // txt_employeeID
            // 
            this.txt_employeeID.Location = new System.Drawing.Point(498, 61);
            this.txt_employeeID.Name = "txt_employeeID";
            this.txt_employeeID.ReadOnly = true;
            this.txt_employeeID.Size = new System.Drawing.Size(94, 20);
            this.txt_employeeID.TabIndex = 66;
            this.txt_employeeID.Visible = false;
            // 
            // lbl_employeeID
            // 
            this.lbl_employeeID.AutoSize = true;
            this.lbl_employeeID.Location = new System.Drawing.Point(495, 33);
            this.lbl_employeeID.Name = "lbl_employeeID";
            this.lbl_employeeID.Size = new System.Drawing.Size(67, 13);
            this.lbl_employeeID.TabIndex = 65;
            this.lbl_employeeID.Text = "Employee ID";
            this.lbl_employeeID.Visible = false;
            // 
            // HireDateCal
            // 
            this.HireDateCal.Location = new System.Drawing.Point(745, 187);
            this.HireDateCal.Name = "HireDateCal";
            this.HireDateCal.TabIndex = 64;
            this.HireDateCal.Visible = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(437, 423);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 63;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // rdo_isActive
            // 
            this.rdo_isActive.AutoSize = true;
            this.rdo_isActive.Location = new System.Drawing.Point(520, 148);
            this.rdo_isActive.Name = "rdo_isActive";
            this.rdo_isActive.Size = new System.Drawing.Size(72, 17);
            this.rdo_isActive.TabIndex = 62;
            this.rdo_isActive.TabStop = true;
            this.rdo_isActive.Text = "Is Active?";
            this.rdo_isActive.UseVisualStyleBackColor = true;
            // 
            // lbl_hireDate
            // 
            this.lbl_hireDate.AutoSize = true;
            this.lbl_hireDate.Location = new System.Drawing.Point(638, 33);
            this.lbl_hireDate.Name = "lbl_hireDate";
            this.lbl_hireDate.Size = new System.Drawing.Size(52, 13);
            this.lbl_hireDate.TabIndex = 60;
            this.lbl_hireDate.Text = "Hire Date";
            // 
            // btn_tabExitToMenu
            // 
            this.btn_tabExitToMenu.Location = new System.Drawing.Point(897, 421);
            this.btn_tabExitToMenu.Name = "btn_tabExitToMenu";
            this.btn_tabExitToMenu.Size = new System.Drawing.Size(75, 25);
            this.btn_tabExitToMenu.TabIndex = 57;
            this.btn_tabExitToMenu.Text = "Exit to Menu";
            this.btn_tabExitToMenu.UseVisualStyleBackColor = true;
            this.btn_tabExitToMenu.Click += new System.EventHandler(this.btn_tabExitToMenu_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(565, 421);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 25);
            this.btn_delete.TabIndex = 56;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // pnl_salary
            // 
            this.pnl_salary.AccessibleDescription = "Options to determine ";
            this.pnl_salary.AccessibleName = "Salary";
            this.pnl_salary.Controls.Add(this.gbx_shiftType);
            this.pnl_salary.Controls.Add(this.gbx_payType);
            this.pnl_salary.Controls.Add(this.lbl_rateOfPay);
            this.pnl_salary.Controls.Add(this.txt_rateOfPay);
            this.pnl_salary.Location = new System.Drawing.Point(159, 212);
            this.pnl_salary.Name = "pnl_salary";
            this.pnl_salary.Size = new System.Drawing.Size(480, 137);
            this.pnl_salary.TabIndex = 54;
            this.pnl_salary.Tag = "";
            // 
            // gbx_shiftType
            // 
            this.gbx_shiftType.Controls.Add(this.rdo_fullTime);
            this.gbx_shiftType.Controls.Add(this.rdo_partTime);
            this.gbx_shiftType.Location = new System.Drawing.Point(23, 14);
            this.gbx_shiftType.Name = "gbx_shiftType";
            this.gbx_shiftType.Size = new System.Drawing.Size(95, 100);
            this.gbx_shiftType.TabIndex = 17;
            this.gbx_shiftType.TabStop = false;
            this.gbx_shiftType.Text = "Shift Type";
            // 
            // rdo_fullTime
            // 
            this.rdo_fullTime.AutoSize = true;
            this.rdo_fullTime.Location = new System.Drawing.Point(10, 28);
            this.rdo_fullTime.Name = "rdo_fullTime";
            this.rdo_fullTime.Size = new System.Drawing.Size(67, 17);
            this.rdo_fullTime.TabIndex = 12;
            this.rdo_fullTime.TabStop = true;
            this.rdo_fullTime.Tag = "";
            this.rdo_fullTime.Text = "Full Time";
            this.rdo_fullTime.UseVisualStyleBackColor = true;
            // 
            // rdo_partTime
            // 
            this.rdo_partTime.AutoSize = true;
            this.rdo_partTime.Location = new System.Drawing.Point(10, 70);
            this.rdo_partTime.Name = "rdo_partTime";
            this.rdo_partTime.Size = new System.Drawing.Size(70, 17);
            this.rdo_partTime.TabIndex = 13;
            this.rdo_partTime.TabStop = true;
            this.rdo_partTime.Tag = "";
            this.rdo_partTime.Text = "Part Time";
            this.rdo_partTime.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdo_partTime.UseVisualStyleBackColor = true;
            // 
            // gbx_payType
            // 
            this.gbx_payType.Controls.Add(this.rdo_hourly);
            this.gbx_payType.Controls.Add(this.rdo_salary);
            this.gbx_payType.Location = new System.Drawing.Point(200, 14);
            this.gbx_payType.Name = "gbx_payType";
            this.gbx_payType.Size = new System.Drawing.Size(100, 100);
            this.gbx_payType.TabIndex = 16;
            this.gbx_payType.TabStop = false;
            this.gbx_payType.Text = "Pay Type";
            // 
            // rdo_hourly
            // 
            this.rdo_hourly.AutoSize = true;
            this.rdo_hourly.Location = new System.Drawing.Point(18, 70);
            this.rdo_hourly.Name = "rdo_hourly";
            this.rdo_hourly.Size = new System.Drawing.Size(55, 17);
            this.rdo_hourly.TabIndex = 11;
            this.rdo_hourly.TabStop = true;
            this.rdo_hourly.Tag = "hourly";
            this.rdo_hourly.Text = "Hourly";
            this.rdo_hourly.UseVisualStyleBackColor = true;
            // 
            // rdo_salary
            // 
            this.rdo_salary.AutoSize = true;
            this.rdo_salary.Location = new System.Drawing.Point(18, 28);
            this.rdo_salary.Name = "rdo_salary";
            this.rdo_salary.Size = new System.Drawing.Size(54, 17);
            this.rdo_salary.TabIndex = 10;
            this.rdo_salary.TabStop = true;
            this.rdo_salary.Tag = "salary";
            this.rdo_salary.Text = "Salary";
            this.rdo_salary.UseVisualStyleBackColor = true;
            // 
            // lbl_rateOfPay
            // 
            this.lbl_rateOfPay.AutoSize = true;
            this.lbl_rateOfPay.Location = new System.Drawing.Point(336, 23);
            this.lbl_rateOfPay.Name = "lbl_rateOfPay";
            this.lbl_rateOfPay.Size = new System.Drawing.Size(63, 13);
            this.lbl_rateOfPay.TabIndex = 14;
            this.lbl_rateOfPay.Text = "Rate of Pay";
            // 
            // txt_rateOfPay
            // 
            this.txt_rateOfPay.Location = new System.Drawing.Point(339, 62);
            this.txt_rateOfPay.Name = "txt_rateOfPay";
            this.txt_rateOfPay.Size = new System.Drawing.Size(100, 20);
            this.txt_rateOfPay.TabIndex = 9;
            // 
            // cmb_shift
            // 
            this.cmb_shift.FormattingEnabled = true;
            this.cmb_shift.Location = new System.Drawing.Point(338, 147);
            this.cmb_shift.Name = "cmb_shift";
            this.cmb_shift.Size = new System.Drawing.Size(121, 21);
            this.cmb_shift.TabIndex = 53;
            this.cmb_shift.SelectedIndexChanged += new System.EventHandler(this.cmb_shift_SelectedIndexChanged);
            // 
            // lbl_shift
            // 
            this.lbl_shift.AutoSize = true;
            this.lbl_shift.BackColor = System.Drawing.Color.Transparent;
            this.lbl_shift.Location = new System.Drawing.Point(335, 122);
            this.lbl_shift.Name = "lbl_shift";
            this.lbl_shift.Size = new System.Drawing.Size(28, 13);
            this.lbl_shift.TabIndex = 52;
            this.lbl_shift.Text = "Shift";
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.BackColor = System.Drawing.Color.Transparent;
            this.lbl_position.Location = new System.Drawing.Point(156, 122);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(44, 13);
            this.lbl_position.TabIndex = 51;
            this.lbl_position.Text = "Position";
            // 
            // cmb_position
            // 
            this.cmb_position.FormattingEnabled = true;
            this.cmb_position.Location = new System.Drawing.Point(159, 147);
            this.cmb_position.Name = "cmb_position";
            this.cmb_position.Size = new System.Drawing.Size(121, 21);
            this.cmb_position.TabIndex = 50;
            this.cmb_position.SelectedIndexChanged += new System.EventHandler(this.cmb_position_SelectedIndexChanged);
            // 
            // lbl_Last
            // 
            this.lbl_Last.AutoSize = true;
            this.lbl_Last.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Last.Location = new System.Drawing.Point(335, 33);
            this.lbl_Last.Name = "lbl_Last";
            this.lbl_Last.Size = new System.Drawing.Size(58, 13);
            this.lbl_Last.TabIndex = 49;
            this.lbl_Last.Text = "Last Name";
            // 
            // lbl_first
            // 
            this.lbl_first.AutoSize = true;
            this.lbl_first.BackColor = System.Drawing.Color.Transparent;
            this.lbl_first.Location = new System.Drawing.Point(156, 33);
            this.lbl_first.Name = "lbl_first";
            this.lbl_first.Size = new System.Drawing.Size(57, 13);
            this.lbl_first.TabIndex = 48;
            this.lbl_first.Text = "First Name";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(338, 61);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(100, 20);
            this.txt_lastName.TabIndex = 47;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(159, 61);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(100, 20);
            this.txt_firstName.TabIndex = 46;
            // 
            // btn_tabExitApp
            // 
            this.btn_tabExitApp.Location = new System.Drawing.Point(762, 421);
            this.btn_tabExitApp.Name = "btn_tabExitApp";
            this.btn_tabExitApp.Size = new System.Drawing.Size(90, 25);
            this.btn_tabExitApp.TabIndex = 45;
            this.btn_tabExitApp.Text = "Exit Application";
            this.btn_tabExitApp.UseVisualStyleBackColor = true;
            this.btn_tabExitApp.Click += new System.EventHandler(this.btn_tabExitApp_Click);
            // 
            // employeeID
            // 
            this.employeeID.HeaderText = "Employee ID";
            this.employeeID.Name = "employeeID";
            this.employeeID.ReadOnly = true;
            this.employeeID.Visible = false;
            // 
            // employeeLast
            // 
            this.employeeLast.HeaderText = "Last Name";
            this.employeeLast.Name = "employeeLast";
            // 
            // employeeFirst
            // 
            this.employeeFirst.HeaderText = "First Name";
            this.employeeFirst.Name = "employeeFirst";
            // 
            // hireDate
            // 
            this.hireDate.HeaderText = "Hire Date";
            this.hireDate.Name = "hireDate";
            // 
            // salary
            // 
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            // 
            // isActive
            // 
            this.isActive.HeaderText = "Is Active";
            this.isActive.Name = "isActive";
            // 
            // positionTitle
            // 
            this.positionTitle.HeaderText = "Title";
            this.positionTitle.Name = "positionTitle";
            // 
            // shiftID
            // 
            this.shiftID.HeaderText = "Shift";
            this.shiftID.Name = "shiftID";
            // 
            // frm_ManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 552);
            this.Controls.Add(this.tab_Employee);
            this.Name = "frm_ManageEmployees";
            this.Text = "Manage Employee";
            this.Load += new System.EventHandler(this.frm_ManageEmployees_Load);
            this.tab_Employee.ResumeLayout(false);
            this.tab_Employees.ResumeLayout(false);
            this.tab_Employees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_employees)).EndInit();
            this.tab_manageEmployees.ResumeLayout(false);
            this.tab_manageEmployees.PerformLayout();
            this.pnl_salary.ResumeLayout(false);
            this.pnl_salary.PerformLayout();
            this.gbx_shiftType.ResumeLayout(false);
            this.gbx_shiftType.PerformLayout();
            this.gbx_payType.ResumeLayout(false);
            this.gbx_payType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Employee;
        private System.Windows.Forms.TabPage tab_Employees;
        private System.Windows.Forms.TabPage tab_manageEmployees;
        private System.Windows.Forms.DataGridView grd_employees;
        private System.Windows.Forms.Label lbl_productList;
        private System.Windows.Forms.TextBox txt_searchBox;
        private System.Windows.Forms.Button btn_addNew;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_exitToMenu;
        private System.Windows.Forms.Button btn_exitApplication;
        private System.Windows.Forms.RadioButton rdo_isActive;
        private System.Windows.Forms.Label lbl_hireDate;
        private System.Windows.Forms.Button btn_tabExitToMenu;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel pnl_salary;
        private System.Windows.Forms.Label lbl_rateOfPay;
        private System.Windows.Forms.RadioButton rdo_fullTime;
        private System.Windows.Forms.TextBox txt_rateOfPay;
        private System.Windows.Forms.RadioButton rdo_hourly;
        private System.Windows.Forms.RadioButton rdo_partTime;
        private System.Windows.Forms.RadioButton rdo_salary;
        private System.Windows.Forms.ComboBox cmb_shift;
        private System.Windows.Forms.Label lbl_shift;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.ComboBox cmb_position;
        private System.Windows.Forms.Label lbl_Last;
        private System.Windows.Forms.Label lbl_first;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Button btn_tabExitApp;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox gbx_payType;
        private System.Windows.Forms.GroupBox gbx_shiftType;
        private System.Windows.Forms.MonthCalendar HireDateCal;
        private System.Windows.Forms.TextBox txt_employeeID;
        private System.Windows.Forms.Label lbl_employeeID;
        private System.Windows.Forms.DateTimePicker dtm_dateHired;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftID;

    }
}