namespace FoodShop
{
    partial class frm_ManageCustomers
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
            this.tab_Customer = new System.Windows.Forms.TabControl();
            this.tab_Customers = new System.Windows.Forms.TabPage();
            this.btn_addCustomer = new System.Windows.Forms.Button();
            this.btn_exitApplication = new System.Windows.Forms.Button();
            this.btn_exitToMenu = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.grd_Customers = new System.Windows.Forms.DataGridView();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthMonthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequentEnrollDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Customers = new System.Windows.Forms.Label();
            this.tab_manageCustomers = new System.Windows.Forms.TabPage();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_exitCustomers = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.gbx_gender = new System.Windows.Forms.GroupBox();
            this.rdo_private = new System.Windows.Forms.RadioButton();
            this.rdo_male = new System.Windows.Forms.RadioButton();
            this.rdo_female = new System.Windows.Forms.RadioButton();
            this.lbl_enrollmentDate = new System.Windows.Forms.Label();
            this.cmb_birthMonth = new System.Windows.Forms.ComboBox();
            this.lbl_birthMonth = new System.Windows.Forms.Label();
            this.dtm_enrollDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_customerID = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_last = new System.Windows.Forms.Label();
            this.lbl_first = new System.Windows.Forms.Label();
            this.tab_Customer.SuspendLayout();
            this.tab_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Customers)).BeginInit();
            this.tab_manageCustomers.SuspendLayout();
            this.gbx_gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Customer
            // 
            this.tab_Customer.Controls.Add(this.tab_Customers);
            this.tab_Customer.Controls.Add(this.tab_manageCustomers);
            this.tab_Customer.Location = new System.Drawing.Point(2, 0);
            this.tab_Customer.Name = "tab_Customer";
            this.tab_Customer.SelectedIndex = 0;
            this.tab_Customer.Size = new System.Drawing.Size(1136, 505);
            this.tab_Customer.TabIndex = 0;
            // 
            // tab_Customers
            // 
            this.tab_Customers.Controls.Add(this.btn_addCustomer);
            this.tab_Customers.Controls.Add(this.btn_exitApplication);
            this.tab_Customers.Controls.Add(this.btn_exitToMenu);
            this.tab_Customers.Controls.Add(this.btn_Select);
            this.tab_Customers.Controls.Add(this.grd_Customers);
            this.tab_Customers.Controls.Add(this.lbl_Customers);
            this.tab_Customers.Location = new System.Drawing.Point(4, 22);
            this.tab_Customers.Name = "tab_Customers";
            this.tab_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Customers.Size = new System.Drawing.Size(1128, 479);
            this.tab_Customers.TabIndex = 0;
            this.tab_Customers.Text = "View Customers";
            this.tab_Customers.UseVisualStyleBackColor = true;
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.Location = new System.Drawing.Point(730, 423);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(90, 25);
            this.btn_addCustomer.TabIndex = 5;
            this.btn_addCustomer.Text = "Add Customer";
            this.btn_addCustomer.UseVisualStyleBackColor = true;
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // btn_exitApplication
            // 
            this.btn_exitApplication.Location = new System.Drawing.Point(879, 423);
            this.btn_exitApplication.Name = "btn_exitApplication";
            this.btn_exitApplication.Size = new System.Drawing.Size(90, 25);
            this.btn_exitApplication.TabIndex = 4;
            this.btn_exitApplication.Text = "Exit Application";
            this.btn_exitApplication.UseVisualStyleBackColor = true;
            // 
            // btn_exitToMenu
            // 
            this.btn_exitToMenu.Location = new System.Drawing.Point(1014, 423);
            this.btn_exitToMenu.Name = "btn_exitToMenu";
            this.btn_exitToMenu.Size = new System.Drawing.Size(75, 25);
            this.btn_exitToMenu.TabIndex = 3;
            this.btn_exitToMenu.Text = "Exit to Menu";
            this.btn_exitToMenu.UseVisualStyleBackColor = true;
            this.btn_exitToMenu.Click += new System.EventHandler(this.btn_exitToMenu_Click_1);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(610, 423);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 25);
            this.btn_Select.TabIndex = 2;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click_1);
            // 
            // grd_Customers
            // 
            this.grd_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.customerLast,
            this.customerFirst,
            this.gender,
            this.eMail,
            this.telephone,
            this.birthMonthDay,
            this.frequentEnrollDate});
            this.grd_Customers.Location = new System.Drawing.Point(6, 89);
            this.grd_Customers.Name = "grd_Customers";
            this.grd_Customers.Size = new System.Drawing.Size(1083, 297);
            this.grd_Customers.TabIndex = 1;
            // 
            // customerID
            // 
            this.customerID.HeaderText = "Customer ID";
            this.customerID.Name = "customerID";
            // 
            // customerLast
            // 
            this.customerLast.HeaderText = "Last Name";
            this.customerLast.Name = "customerLast";
            // 
            // customerFirst
            // 
            this.customerFirst.HeaderText = "First Name";
            this.customerFirst.Name = "customerFirst";
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            // 
            // eMail
            // 
            this.eMail.HeaderText = "Email";
            this.eMail.Name = "eMail";
            // 
            // telephone
            // 
            this.telephone.HeaderText = "Phone Number";
            this.telephone.Name = "telephone";
            // 
            // birthMonthDay
            // 
            this.birthMonthDay.HeaderText = "Birth Month";
            this.birthMonthDay.Name = "birthMonthDay";
            // 
            // frequentEnrollDate
            // 
            this.frequentEnrollDate.HeaderText = "Enrollment Date";
            this.frequentEnrollDate.Name = "frequentEnrollDate";
            // 
            // lbl_Customers
            // 
            this.lbl_Customers.AutoSize = true;
            this.lbl_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customers.Location = new System.Drawing.Point(62, 38);
            this.lbl_Customers.Name = "lbl_Customers";
            this.lbl_Customers.Size = new System.Drawing.Size(146, 31);
            this.lbl_Customers.TabIndex = 0;
            this.lbl_Customers.Text = "Customers";
            // 
            // tab_manageCustomers
            // 
            this.tab_manageCustomers.Controls.Add(this.btn_exit);
            this.tab_manageCustomers.Controls.Add(this.btn_exitCustomers);
            this.tab_manageCustomers.Controls.Add(this.btn_delete);
            this.tab_manageCustomers.Controls.Add(this.btn_save);
            this.tab_manageCustomers.Controls.Add(this.gbx_gender);
            this.tab_manageCustomers.Controls.Add(this.lbl_enrollmentDate);
            this.tab_manageCustomers.Controls.Add(this.cmb_birthMonth);
            this.tab_manageCustomers.Controls.Add(this.lbl_birthMonth);
            this.tab_manageCustomers.Controls.Add(this.dtm_enrollDate);
            this.tab_manageCustomers.Controls.Add(this.lbl_phone);
            this.tab_manageCustomers.Controls.Add(this.lbl_email);
            this.tab_manageCustomers.Controls.Add(this.txt_phone);
            this.tab_manageCustomers.Controls.Add(this.txt_email);
            this.tab_manageCustomers.Controls.Add(this.txt_firstName);
            this.tab_manageCustomers.Controls.Add(this.txt_customerID);
            this.tab_manageCustomers.Controls.Add(this.txt_lastName);
            this.tab_manageCustomers.Controls.Add(this.lbl_id);
            this.tab_manageCustomers.Controls.Add(this.lbl_last);
            this.tab_manageCustomers.Controls.Add(this.lbl_first);
            this.tab_manageCustomers.Location = new System.Drawing.Point(4, 22);
            this.tab_manageCustomers.Name = "tab_manageCustomers";
            this.tab_manageCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_manageCustomers.Size = new System.Drawing.Size(1128, 479);
            this.tab_manageCustomers.TabIndex = 1;
            this.tab_manageCustomers.Text = "Manage Customers";
            this.tab_manageCustomers.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(897, 421);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 19;
            this.btn_exit.Text = "Exit to Menu";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_exitCustomers
            // 
            this.btn_exitCustomers.Location = new System.Drawing.Point(762, 421);
            this.btn_exitCustomers.Name = "btn_exitCustomers";
            this.btn_exitCustomers.Size = new System.Drawing.Size(75, 23);
            this.btn_exitCustomers.TabIndex = 18;
            this.btn_exitCustomers.Text = "Exit Application";
            this.btn_exitCustomers.UseVisualStyleBackColor = true;
            this.btn_exitCustomers.Click += new System.EventHandler(this.btn_exitCustomers_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(565, 421);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(437, 423);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // gbx_gender
            // 
            this.gbx_gender.Controls.Add(this.rdo_private);
            this.gbx_gender.Controls.Add(this.rdo_male);
            this.gbx_gender.Controls.Add(this.rdo_female);
            this.gbx_gender.Location = new System.Drawing.Point(498, 122);
            this.gbx_gender.Name = "gbx_gender";
            this.gbx_gender.Size = new System.Drawing.Size(158, 166);
            this.gbx_gender.TabIndex = 15;
            this.gbx_gender.TabStop = false;
            this.gbx_gender.Text = "Gender";
            // 
            // rdo_private
            // 
            this.rdo_private.AutoSize = true;
            this.rdo_private.Location = new System.Drawing.Point(25, 126);
            this.rdo_private.Name = "rdo_private";
            this.rdo_private.Size = new System.Drawing.Size(102, 17);
            this.rdo_private.TabIndex = 2;
            this.rdo_private.TabStop = true;
            this.rdo_private.Text = "Prefer not to say";
            this.rdo_private.UseVisualStyleBackColor = true;
            // 
            // rdo_male
            // 
            this.rdo_male.AutoSize = true;
            this.rdo_male.Location = new System.Drawing.Point(25, 80);
            this.rdo_male.Name = "rdo_male";
            this.rdo_male.Size = new System.Drawing.Size(48, 17);
            this.rdo_male.TabIndex = 1;
            this.rdo_male.TabStop = true;
            this.rdo_male.Text = "Male";
            this.rdo_male.UseVisualStyleBackColor = true;
            // 
            // rdo_female
            // 
            this.rdo_female.AutoSize = true;
            this.rdo_female.Location = new System.Drawing.Point(25, 38);
            this.rdo_female.Name = "rdo_female";
            this.rdo_female.Size = new System.Drawing.Size(59, 17);
            this.rdo_female.TabIndex = 0;
            this.rdo_female.TabStop = true;
            this.rdo_female.Text = "Female";
            this.rdo_female.UseVisualStyleBackColor = true;
            // 
            // lbl_enrollmentDate
            // 
            this.lbl_enrollmentDate.AutoSize = true;
            this.lbl_enrollmentDate.Location = new System.Drawing.Point(156, 285);
            this.lbl_enrollmentDate.Name = "lbl_enrollmentDate";
            this.lbl_enrollmentDate.Size = new System.Drawing.Size(82, 13);
            this.lbl_enrollmentDate.TabIndex = 14;
            this.lbl_enrollmentDate.Text = "Enrollment Date";
            // 
            // cmb_birthMonth
            // 
            this.cmb_birthMonth.FormattingEnabled = true;
            this.cmb_birthMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmb_birthMonth.Location = new System.Drawing.Point(643, 60);
            this.cmb_birthMonth.Name = "cmb_birthMonth";
            this.cmb_birthMonth.Size = new System.Drawing.Size(121, 21);
            this.cmb_birthMonth.TabIndex = 13;
            // 
            // lbl_birthMonth
            // 
            this.lbl_birthMonth.AutoSize = true;
            this.lbl_birthMonth.Location = new System.Drawing.Point(640, 30);
            this.lbl_birthMonth.Name = "lbl_birthMonth";
            this.lbl_birthMonth.Size = new System.Drawing.Size(61, 13);
            this.lbl_birthMonth.TabIndex = 12;
            this.lbl_birthMonth.Text = "Birth Month";
            // 
            // dtm_enrollDate
            // 
            this.dtm_enrollDate.Location = new System.Drawing.Point(156, 309);
            this.dtm_enrollDate.Name = "dtm_enrollDate";
            this.dtm_enrollDate.Size = new System.Drawing.Size(200, 20);
            this.dtm_enrollDate.TabIndex = 10;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(156, 206);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(78, 13);
            this.lbl_phone.TabIndex = 9;
            this.lbl_phone.Text = "Phone Number";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(156, 122);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(73, 13);
            this.lbl_email.TabIndex = 8;
            this.lbl_email.Text = "Email Address";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(159, 231);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(279, 20);
            this.txt_phone.TabIndex = 7;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(159, 147);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(279, 20);
            this.txt_email.TabIndex = 6;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(338, 61);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(100, 20);
            this.txt_firstName.TabIndex = 5;
            // 
            // txt_customerID
            // 
            this.txt_customerID.BackColor = System.Drawing.SystemColors.Control;
            this.txt_customerID.Location = new System.Drawing.Point(498, 61);
            this.txt_customerID.Name = "txt_customerID";
            this.txt_customerID.Size = new System.Drawing.Size(100, 20);
            this.txt_customerID.TabIndex = 4;
            this.txt_customerID.Visible = false;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(159, 61);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(100, 20);
            this.txt_lastName.TabIndex = 3;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(495, 33);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(65, 13);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "Customer ID";
            this.lbl_id.Visible = false;
            // 
            // lbl_last
            // 
            this.lbl_last.AutoSize = true;
            this.lbl_last.Location = new System.Drawing.Point(335, 33);
            this.lbl_last.Name = "lbl_last";
            this.lbl_last.Size = new System.Drawing.Size(58, 13);
            this.lbl_last.TabIndex = 1;
            this.lbl_last.Text = "Last Name";
            // 
            // lbl_first
            // 
            this.lbl_first.AutoSize = true;
            this.lbl_first.Location = new System.Drawing.Point(156, 33);
            this.lbl_first.Name = "lbl_first";
            this.lbl_first.Size = new System.Drawing.Size(57, 13);
            this.lbl_first.TabIndex = 0;
            this.lbl_first.Text = "First Name";
            // 
            // frm_ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 552);
            this.Controls.Add(this.tab_Customer);
            this.Name = "frm_ManageCustomers";
            this.Text = "Manage Customers";
            this.tab_Customer.ResumeLayout(false);
            this.tab_Customers.ResumeLayout(false);
            this.tab_Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Customers)).EndInit();
            this.tab_manageCustomers.ResumeLayout(false);
            this.tab_manageCustomers.PerformLayout();
            this.gbx_gender.ResumeLayout(false);
            this.gbx_gender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Customer;
        private System.Windows.Forms.TabPage tab_Customers;
        private System.Windows.Forms.TabPage tab_manageCustomers;
        private System.Windows.Forms.Label lbl_Customers;
        private System.Windows.Forms.DataGridView grd_Customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthMonthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequentEnrollDate;
        private System.Windows.Forms.Button btn_addCustomer;
        private System.Windows.Forms.Button btn_exitApplication;
        private System.Windows.Forms.Button btn_exitToMenu;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_last;
        private System.Windows.Forms.Label lbl_first;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_customerID;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.DateTimePicker dtm_enrollDate;
        private System.Windows.Forms.Label lbl_enrollmentDate;
        private System.Windows.Forms.ComboBox cmb_birthMonth;
        private System.Windows.Forms.Label lbl_birthMonth;
        private System.Windows.Forms.GroupBox gbx_gender;
        private System.Windows.Forms.RadioButton rdo_private;
        private System.Windows.Forms.RadioButton rdo_male;
        private System.Windows.Forms.RadioButton rdo_female;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_exitCustomers;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
    }
}