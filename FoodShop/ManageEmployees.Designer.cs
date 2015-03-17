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
            this.tab_manageEmployees = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_productList = new System.Windows.Forms.Label();
            this.txt_searchBox = new System.Windows.Forms.TextBox();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_exitToMenu = new System.Windows.Forms.Button();
            this.btn_exitApplication = new System.Windows.Forms.Button();
            this.rdo_isActive = new System.Windows.Forms.RadioButton();
            this.txt_hireDate = new System.Windows.Forms.TextBox();
            this.lbl_hireDate = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.pnl_salary = new System.Windows.Forms.Panel();
            this.lbl_rateOfPay = new System.Windows.Forms.Label();
            this.rdo_fullTime = new System.Windows.Forms.RadioButton();
            this.txt_rateOfPay = new System.Windows.Forms.TextBox();
            this.rdo_hourly = new System.Windows.Forms.RadioButton();
            this.rdo_partTime = new System.Windows.Forms.RadioButton();
            this.rdo_salaried = new System.Windows.Forms.RadioButton();
            this.lbl_id = new System.Windows.Forms.Label();
            this.cmb_shift = new System.Windows.Forms.ComboBox();
            this.lbl_shift = new System.Windows.Forms.Label();
            this.lbl_position = new System.Windows.Forms.Label();
            this.cmb_position = new System.Windows.Forms.ComboBox();
            this.lbl_Last = new System.Windows.Forms.Label();
            this.lbl_first = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tab_Employee.SuspendLayout();
            this.tab_Employees.SuspendLayout();
            this.tab_manageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_salary.SuspendLayout();
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
            this.tab_Employee.TabIndex = 8;
            // 
            // tab_Employees
            // 
            this.tab_Employees.Controls.Add(this.dataGridView1);
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
            // tab_manageEmployees
            // 
            this.tab_manageEmployees.Controls.Add(this.btn_save);
            this.tab_manageEmployees.Controls.Add(this.rdo_isActive);
            this.tab_manageEmployees.Controls.Add(this.txt_hireDate);
            this.tab_manageEmployees.Controls.Add(this.lbl_hireDate);
            this.tab_manageEmployees.Controls.Add(this.txt_id);
            this.tab_manageEmployees.Controls.Add(this.button1);
            this.tab_manageEmployees.Controls.Add(this.btn_delete);
            this.tab_manageEmployees.Controls.Add(this.pnl_salary);
            this.tab_manageEmployees.Controls.Add(this.lbl_id);
            this.tab_manageEmployees.Controls.Add(this.cmb_shift);
            this.tab_manageEmployees.Controls.Add(this.lbl_shift);
            this.tab_manageEmployees.Controls.Add(this.lbl_position);
            this.tab_manageEmployees.Controls.Add(this.cmb_position);
            this.tab_manageEmployees.Controls.Add(this.lbl_Last);
            this.tab_manageEmployees.Controls.Add(this.lbl_first);
            this.tab_manageEmployees.Controls.Add(this.txt_lastName);
            this.tab_manageEmployees.Controls.Add(this.txt_firstName);
            this.tab_manageEmployees.Controls.Add(this.button2);
            this.tab_manageEmployees.Location = new System.Drawing.Point(4, 22);
            this.tab_manageEmployees.Name = "tab_manageEmployees";
            this.tab_manageEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tab_manageEmployees.Size = new System.Drawing.Size(1128, 479);
            this.tab_manageEmployees.TabIndex = 2;
            this.tab_manageEmployees.Text = "Manage Employees";
            this.tab_manageEmployees.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeID,
            this.employeeLast,
            this.employeeFirst,
            this.positionID,
            this.positionTitle,
            this.shiftID,
            this.hireDate,
            this.isActive,
            this.salary,
            this.fullTime,
            this.salaryMode});
            this.dataGridView1.Location = new System.Drawing.Point(39, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1050, 297);
            this.dataGridView1.TabIndex = 20;
            // 
            // employeeID
            // 
            this.employeeID.HeaderText = "Employee ID";
            this.employeeID.Name = "employeeID";
            this.employeeID.ReadOnly = true;
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
            // positionID
            // 
            this.positionID.HeaderText = "Position";
            this.positionID.Name = "positionID";
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
            // hireDate
            // 
            this.hireDate.HeaderText = "Hire Date";
            this.hireDate.Name = "hireDate";
            // 
            // isActive
            // 
            this.isActive.HeaderText = "Is Active";
            this.isActive.Name = "isActive";
            // 
            // salary
            // 
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            // 
            // fullTime
            // 
            this.fullTime.HeaderText = "Full Time";
            this.fullTime.Name = "fullTime";
            // 
            // salaryMode
            // 
            this.salaryMode.HeaderText = "Hourly";
            this.salaryMode.Name = "salaryMode";
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
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(610, 423);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 25);
            this.btn_select.TabIndex = 16;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            // 
            // btn_exitToMenu
            // 
            this.btn_exitToMenu.Location = new System.Drawing.Point(1014, 423);
            this.btn_exitToMenu.Name = "btn_exitToMenu";
            this.btn_exitToMenu.Size = new System.Drawing.Size(75, 25);
            this.btn_exitToMenu.TabIndex = 15;
            this.btn_exitToMenu.Text = "Exit to Menu";
            this.btn_exitToMenu.UseVisualStyleBackColor = true;
            // 
            // btn_exitApplication
            // 
            this.btn_exitApplication.Location = new System.Drawing.Point(879, 423);
            this.btn_exitApplication.Name = "btn_exitApplication";
            this.btn_exitApplication.Size = new System.Drawing.Size(90, 25);
            this.btn_exitApplication.TabIndex = 14;
            this.btn_exitApplication.Text = "Exit Application";
            this.btn_exitApplication.UseVisualStyleBackColor = true;
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
            // txt_hireDate
            // 
            this.txt_hireDate.Location = new System.Drawing.Point(520, 61);
            this.txt_hireDate.Name = "txt_hireDate";
            this.txt_hireDate.Size = new System.Drawing.Size(100, 20);
            this.txt_hireDate.TabIndex = 61;
            // 
            // lbl_hireDate
            // 
            this.lbl_hireDate.AutoSize = true;
            this.lbl_hireDate.Location = new System.Drawing.Point(517, 33);
            this.lbl_hireDate.Name = "lbl_hireDate";
            this.lbl_hireDate.Size = new System.Drawing.Size(52, 13);
            this.lbl_hireDate.TabIndex = 60;
            this.lbl_hireDate.Text = "Hire Date";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(679, 61);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(897, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 57;
            this.button1.Text = "Exit to Menu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(565, 421);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 25);
            this.btn_delete.TabIndex = 56;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // pnl_salary
            // 
            this.pnl_salary.AccessibleDescription = "Options to determine ";
            this.pnl_salary.AccessibleName = "Salary";
            this.pnl_salary.Controls.Add(this.lbl_rateOfPay);
            this.pnl_salary.Controls.Add(this.rdo_fullTime);
            this.pnl_salary.Controls.Add(this.txt_rateOfPay);
            this.pnl_salary.Controls.Add(this.rdo_hourly);
            this.pnl_salary.Controls.Add(this.rdo_partTime);
            this.pnl_salary.Controls.Add(this.rdo_salaried);
            this.pnl_salary.Location = new System.Drawing.Point(159, 229);
            this.pnl_salary.Name = "pnl_salary";
            this.pnl_salary.Size = new System.Drawing.Size(480, 133);
            this.pnl_salary.TabIndex = 54;
            this.pnl_salary.Tag = "";
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
            // rdo_fullTime
            // 
            this.rdo_fullTime.AutoSize = true;
            this.rdo_fullTime.Location = new System.Drawing.Point(24, 23);
            this.rdo_fullTime.Name = "rdo_fullTime";
            this.rdo_fullTime.Size = new System.Drawing.Size(67, 17);
            this.rdo_fullTime.TabIndex = 12;
            this.rdo_fullTime.TabStop = true;
            this.rdo_fullTime.Text = "Full Time";
            this.rdo_fullTime.UseVisualStyleBackColor = true;
            // 
            // txt_rateOfPay
            // 
            this.txt_rateOfPay.Location = new System.Drawing.Point(339, 62);
            this.txt_rateOfPay.Name = "txt_rateOfPay";
            this.txt_rateOfPay.Size = new System.Drawing.Size(100, 20);
            this.txt_rateOfPay.TabIndex = 9;
            // 
            // rdo_hourly
            // 
            this.rdo_hourly.AutoSize = true;
            this.rdo_hourly.Location = new System.Drawing.Point(179, 65);
            this.rdo_hourly.Name = "rdo_hourly";
            this.rdo_hourly.Size = new System.Drawing.Size(55, 17);
            this.rdo_hourly.TabIndex = 11;
            this.rdo_hourly.TabStop = true;
            this.rdo_hourly.Text = "Hourly";
            this.rdo_hourly.UseVisualStyleBackColor = true;
            // 
            // rdo_partTime
            // 
            this.rdo_partTime.AutoSize = true;
            this.rdo_partTime.Location = new System.Drawing.Point(24, 65);
            this.rdo_partTime.Name = "rdo_partTime";
            this.rdo_partTime.Size = new System.Drawing.Size(70, 17);
            this.rdo_partTime.TabIndex = 13;
            this.rdo_partTime.TabStop = true;
            this.rdo_partTime.Text = "Part Time";
            this.rdo_partTime.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdo_partTime.UseVisualStyleBackColor = true;
            // 
            // rdo_salaried
            // 
            this.rdo_salaried.AutoSize = true;
            this.rdo_salaried.Location = new System.Drawing.Point(179, 23);
            this.rdo_salaried.Name = "rdo_salaried";
            this.rdo_salaried.Size = new System.Drawing.Size(63, 17);
            this.rdo_salaried.TabIndex = 10;
            this.rdo_salaried.TabStop = true;
            this.rdo_salaried.Text = "Salaried";
            this.rdo_salaried.UseVisualStyleBackColor = true;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(676, 33);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(67, 13);
            this.lbl_id.TabIndex = 58;
            this.lbl_id.Text = "Employee ID";
            // 
            // cmb_shift
            // 
            this.cmb_shift.FormattingEnabled = true;
            this.cmb_shift.Location = new System.Drawing.Point(338, 147);
            this.cmb_shift.Name = "cmb_shift";
            this.cmb_shift.Size = new System.Drawing.Size(121, 21);
            this.cmb_shift.TabIndex = 53;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(762, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 25);
            this.button2.TabIndex = 45;
            this.button2.Text = "Exit Application";
            this.button2.UseVisualStyleBackColor = true;
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
            // frm_ManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 552);
            this.Controls.Add(this.tab_Employee);
            this.Name = "frm_ManageEmployees";
            this.Text = "Manage Employee";
            this.tab_Employee.ResumeLayout(false);
            this.tab_Employees.ResumeLayout(false);
            this.tab_Employees.PerformLayout();
            this.tab_manageEmployees.ResumeLayout(false);
            this.tab_manageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_salary.ResumeLayout(false);
            this.pnl_salary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Employee;
        private System.Windows.Forms.TabPage tab_Employees;
        private System.Windows.Forms.TabPage tab_manageEmployees;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryMode;
        private System.Windows.Forms.Label lbl_productList;
        private System.Windows.Forms.TextBox txt_searchBox;
        private System.Windows.Forms.Button btn_addNew;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_exitToMenu;
        private System.Windows.Forms.Button btn_exitApplication;
        private System.Windows.Forms.RadioButton rdo_isActive;
        private System.Windows.Forms.TextBox txt_hireDate;
        private System.Windows.Forms.Label lbl_hireDate;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel pnl_salary;
        private System.Windows.Forms.Label lbl_rateOfPay;
        private System.Windows.Forms.RadioButton rdo_fullTime;
        private System.Windows.Forms.TextBox txt_rateOfPay;
        private System.Windows.Forms.RadioButton rdo_hourly;
        private System.Windows.Forms.RadioButton rdo_partTime;
        private System.Windows.Forms.RadioButton rdo_salaried;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.ComboBox cmb_shift;
        private System.Windows.Forms.Label lbl_shift;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.ComboBox cmb_position;
        private System.Windows.Forms.Label lbl_Last;
        private System.Windows.Forms.Label lbl_first;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_save;

    }
}