namespace MainOrderForm.UI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.MainTabControl = new System.Windows.Forms.TabControl();
			this.OrdersTab = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnOrder = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtTax = new System.Windows.Forms.TextBox();
			this.txtSubTotal = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.DataGridOrders = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.cboQuantity = new System.Windows.Forms.ComboBox();
			this.lblProducts = new System.Windows.Forms.Label();
			this.cboProducts = new System.Windows.Forms.ComboBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtDisplayName = new System.Windows.Forms.TextBox();
			this.txtCustomerNumber = new System.Windows.Forms.TextBox();
			this.txtEmpID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.StoresTab = new System.Windows.Forms.TabPage();
			this.MainTabControl.SuspendLayout();
			this.OrdersTab.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// MainTabControl
			// 
			this.MainTabControl.Controls.Add(this.OrdersTab);
			this.MainTabControl.Controls.Add(this.StoresTab);
			this.MainTabControl.Location = new System.Drawing.Point(12, 12);
			this.MainTabControl.Name = "MainTabControl";
			this.MainTabControl.SelectedIndex = 0;
			this.MainTabControl.Size = new System.Drawing.Size(582, 548);
			this.MainTabControl.TabIndex = 0;
			// 
			// OrdersTab
			// 
			this.OrdersTab.Controls.Add(this.groupBox1);
			this.OrdersTab.Controls.Add(this.btnExit);
			this.OrdersTab.Controls.Add(this.btnOrder);
			this.OrdersTab.Controls.Add(this.label8);
			this.OrdersTab.Controls.Add(this.label7);
			this.OrdersTab.Controls.Add(this.label6);
			this.OrdersTab.Controls.Add(this.txtTotal);
			this.OrdersTab.Controls.Add(this.txtTax);
			this.OrdersTab.Controls.Add(this.txtSubTotal);
			this.OrdersTab.Controls.Add(this.btnDelete);
			this.OrdersTab.Controls.Add(this.btnAdd);
			this.OrdersTab.Controls.Add(this.DataGridOrders);
			this.OrdersTab.Controls.Add(this.label5);
			this.OrdersTab.Controls.Add(this.cboQuantity);
			this.OrdersTab.Controls.Add(this.lblProducts);
			this.OrdersTab.Controls.Add(this.cboProducts);
			this.OrdersTab.Controls.Add(this.txtName);
			this.OrdersTab.Controls.Add(this.txtDisplayName);
			this.OrdersTab.Controls.Add(this.txtCustomerNumber);
			this.OrdersTab.Controls.Add(this.txtEmpID);
			this.OrdersTab.Controls.Add(this.label4);
			this.OrdersTab.Controls.Add(this.label3);
			this.OrdersTab.Controls.Add(this.label2);
			this.OrdersTab.Controls.Add(this.label1);
			this.OrdersTab.Location = new System.Drawing.Point(4, 22);
			this.OrdersTab.Name = "OrdersTab";
			this.OrdersTab.Padding = new System.Windows.Forms.Padding(3);
			this.OrdersTab.Size = new System.Drawing.Size(574, 522);
			this.OrdersTab.TabIndex = 0;
			this.OrdersTab.Text = "Orders";
			this.OrdersTab.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Location = new System.Drawing.Point(54, 381);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(206, 110);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Payment Method";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(10, 29);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(478, 468);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 23;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// btnOrder
			// 
			this.btnOrder.Location = new System.Drawing.Point(352, 468);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(75, 23);
			this.btnOrder.TabIndex = 22;
			this.btnOrder.Text = "Order";
			this.btnOrder.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(296, 436);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(31, 13);
			this.label8.TabIndex = 21;
			this.label8.Text = "Total";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(296, 410);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(25, 13);
			this.label7.TabIndex = 20;
			this.label7.Text = "Tax";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(296, 384);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "SubTotal";
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(352, 433);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(100, 20);
			this.txtTotal.TabIndex = 18;
			// 
			// txtTax
			// 
			this.txtTax.Location = new System.Drawing.Point(352, 407);
			this.txtTax.Name = "txtTax";
			this.txtTax.Size = new System.Drawing.Size(100, 20);
			this.txtTax.TabIndex = 17;
			// 
			// txtSubTotal
			// 
			this.txtSubTotal.Location = new System.Drawing.Point(352, 381);
			this.txtSubTotal.Name = "txtSubTotal";
			this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
			this.txtSubTotal.TabIndex = 16;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(478, 216);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 15;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(478, 166);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 14;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// DataGridOrders
			// 
			this.DataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridOrders.Location = new System.Drawing.Point(54, 216);
			this.DataGridOrders.Name = "DataGridOrders";
			this.DataGridOrders.Size = new System.Drawing.Size(398, 150);
			this.DataGridOrders.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(406, 150);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Quantity";
			// 
			// cboQuantity
			// 
			this.cboQuantity.FormattingEnabled = true;
			this.cboQuantity.Location = new System.Drawing.Point(409, 166);
			this.cboQuantity.Name = "cboQuantity";
			this.cboQuantity.Size = new System.Drawing.Size(43, 21);
			this.cboQuantity.TabIndex = 11;
			// 
			// lblProducts
			// 
			this.lblProducts.AutoSize = true;
			this.lblProducts.Location = new System.Drawing.Point(51, 150);
			this.lblProducts.Name = "lblProducts";
			this.lblProducts.Size = new System.Drawing.Size(49, 13);
			this.lblProducts.TabIndex = 10;
			this.lblProducts.Text = "Products";
			// 
			// cboProducts
			// 
			this.cboProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboProducts.FormattingEnabled = true;
			this.cboProducts.Location = new System.Drawing.Point(54, 166);
			this.cboProducts.Name = "cboProducts";
			this.cboProducts.Size = new System.Drawing.Size(340, 21);
			this.cboProducts.TabIndex = 9;
			this.cboProducts.SelectedIndexChanged += new System.EventHandler(this.cboProducts_SelectedIndexChanged);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(352, 109);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 20);
			this.txtName.TabIndex = 8;
			// 
			// txtDisplayName
			// 
			this.txtDisplayName.Location = new System.Drawing.Point(207, 109);
			this.txtDisplayName.Name = "txtDisplayName";
			this.txtDisplayName.Size = new System.Drawing.Size(100, 20);
			this.txtDisplayName.TabIndex = 7;
			// 
			// txtCustomerNumber
			// 
			this.txtCustomerNumber.Location = new System.Drawing.Point(54, 109);
			this.txtCustomerNumber.Name = "txtCustomerNumber";
			this.txtCustomerNumber.Size = new System.Drawing.Size(100, 20);
			this.txtCustomerNumber.TabIndex = 6;
			// 
			// txtEmpID
			// 
			this.txtEmpID.Location = new System.Drawing.Point(54, 55);
			this.txtEmpID.Name = "txtEmpID";
			this.txtEmpID.Size = new System.Drawing.Size(100, 20);
			this.txtEmpID.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(349, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(204, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Display Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(51, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Customer Number";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Employee ID";
			// 
			// StoresTab
			// 
			this.StoresTab.Location = new System.Drawing.Point(4, 22);
			this.StoresTab.Name = "StoresTab";
			this.StoresTab.Padding = new System.Windows.Forms.Padding(3);
			this.StoresTab.Size = new System.Drawing.Size(574, 522);
			this.StoresTab.TabIndex = 1;
			this.StoresTab.Text = "Stores";
			this.StoresTab.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(613, 572);
			this.Controls.Add(this.MainTabControl);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Order Form";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MainTabControl.ResumeLayout(false);
			this.OrdersTab.ResumeLayout(false);
			this.OrdersTab.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridOrders)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl MainTabControl;
		private System.Windows.Forms.TabPage OrdersTab;
		private System.Windows.Forms.TabPage StoresTab;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtDisplayName;
		private System.Windows.Forms.TextBox txtCustomerNumber;
		private System.Windows.Forms.TextBox txtEmpID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboProducts;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboQuantity;
		private System.Windows.Forms.Label lblProducts;
		private System.Windows.Forms.DataGridView DataGridOrders;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtTax;
		private System.Windows.Forms.TextBox txtSubTotal;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnOrder;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}

