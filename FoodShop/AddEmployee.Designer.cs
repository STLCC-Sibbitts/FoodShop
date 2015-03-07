namespace FoodShop
{
    partial class AddEmployee
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
            this.btn_exitApplication = new System.Windows.Forms.Button();
            this.btn_exitToMenu = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.txt_searchBox = new System.Windows.Forms.TextBox();
            this.lbl_productList = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exitApplication
            // 
            this.btn_exitApplication.Location = new System.Drawing.Point(25, 425);
            this.btn_exitApplication.Name = "btn_exitApplication";
            this.btn_exitApplication.Size = new System.Drawing.Size(90, 25);
            this.btn_exitApplication.TabIndex = 0;
            this.btn_exitApplication.Text = "Exit Application";
            this.btn_exitApplication.UseVisualStyleBackColor = true;
            // 
            // btn_exitToMenu
            // 
            this.btn_exitToMenu.Location = new System.Drawing.Point(160, 425);
            this.btn_exitToMenu.Name = "btn_exitToMenu";
            this.btn_exitToMenu.Size = new System.Drawing.Size(75, 25);
            this.btn_exitToMenu.TabIndex = 1;
            this.btn_exitToMenu.Text = "Exit to Menu";
            this.btn_exitToMenu.UseVisualStyleBackColor = true;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(722, 425);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 25);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            // 
            // btn_addNew
            // 
            this.btn_addNew.Location = new System.Drawing.Point(842, 425);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(90, 25);
            this.btn_addNew.TabIndex = 3;
            this.btn_addNew.Text = "Add Employee";
            this.btn_addNew.UseVisualStyleBackColor = true;
            // 
            // txt_searchBox
            // 
            this.txt_searchBox.Location = new System.Drawing.Point(610, 32);
            this.txt_searchBox.Name = "txt_searchBox";
            this.txt_searchBox.Size = new System.Drawing.Size(100, 20);
            this.txt_searchBox.TabIndex = 4;
            this.txt_searchBox.Text = "Search";
            // 
            // lbl_productList
            // 
            this.lbl_productList.AutoSize = true;
            this.lbl_productList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productList.Location = new System.Drawing.Point(25, 40);
            this.lbl_productList.Name = "lbl_productList";
            this.lbl_productList.Size = new System.Drawing.Size(148, 31);
            this.lbl_productList.TabIndex = 5;
            this.lbl_productList.Text = "Employees";
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
            this.salary,
            this.fullTime,
            this.salaryMode});
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(934, 297);
            this.dataGridView1.TabIndex = 6;
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
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 486);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_productList);
            this.Controls.Add(this.txt_searchBox);
            this.Controls.Add(this.btn_addNew);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_exitToMenu);
            this.Controls.Add(this.btn_exitApplication);
            this.Name = "AddEmployee";
            this.Text = "Add Employee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exitApplication;
        private System.Windows.Forms.Button btn_exitToMenu;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_addNew;
        private System.Windows.Forms.TextBox txt_searchBox;
        private System.Windows.Forms.Label lbl_productList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftID;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryMode;
    }
}