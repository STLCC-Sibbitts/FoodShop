using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainOrderForm.UI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		// This BindingSource binds the list to the DataGridView control. 
		private BindingSource ordersBindingSource = new BindingSource();

		private string connectionString =
			@"Data Source=grass.arvixe.com;Initial Catalog=BreadProjectJr;Persist Security Info=True;User ID=is283_jhight0322;Password=032276;";

		private string productsTable = "Products";
		private DataSet productsDataSet;
		private void MainForm_Load( object sender, EventArgs e )
		{
			var databaseServices = new DatabaseServices( connectionString );

			this.productsDataSet = new DataSet();

			this.productsDataSet = databaseServices.ExecuteSqlReturnDataSet(
				new SqlCommand
				{
					CommandText = "select * from BreadProjectJr.is283_ewendj.Products",
					CommandType = CommandType.Text
				},
			true, this.productsTable );

			this.DataGridOrders.DataSource = productsDataSet.Tables[productsTable];

			this.cboProducts.DataSource = productsDataSet.Tables[productsTable];
			this.cboProducts.ValueMember = "ProductId";
			this.cboProducts.DisplayMember = "ProductName";

			this.AddDataBindings();

			// Create and populate the list of Order objects which will supply data to the DataGridView.
			//BindingList<Order> orderList = new BindingList<Order>();

			//// This is an example of manually creating 3 new orders.
			//// This will be done dynamically from code.
			//orderList.Add( Order.CreateNewOrder() );
			//orderList.Add( Order.CreateNewOrder() );
			//orderList.Add( Order.CreateNewOrder() );

			//// Bind the list to the BindingSource. 
			//this.ordersBindingSource.DataSource = orderList;

			//// Attach the BindingSource to the DataGridView. 
			//this.DataGridOrders.DataSource = this.ordersBindingSource;
			//this.txtDisplayName.DataBindings.Add( new Binding( "Text", this.ordersBindingSource, "DisplayName" ) );
			//this.txtEmpID.DataBindings.Add( new Binding( "Text", this.ordersBindingSource, "EmployeeId" ) );
		}

		private void btnAdd_Click( object sender, EventArgs e )
		{
			// Get a reference to the list from the BindingSource.
			BindingList<Order> orderList = this.ordersBindingSource.DataSource as BindingList<Order>;

			// Note this is just and example using static information
			// Real data will be pulled from or updated to the database, etc...
			// Change the value of the CompanyName property for the first item in the list.
			orderList[0].DisplayName = "Jon Smith";
			orderList[0].EmployeeId = "314-971-5555";
		}

		private void cboProducts_SelectedIndexChanged( object sender, EventArgs e )
		{
			this.BindingContext[this.productsDataSet, this.productsTable].Position = this.cboProducts.SelectedIndex;

			//DataView dv = this.productsDataSet.Tables[this.productsTable].DefaultView;
			//dv.RowFilter = "'" + cboProducts.SelectedValue.ToString() + "'";

			//this.DataGridOrders.DataSource = dv;
			this.Update();
		}

		private void AddDataBindings()
		{
			//this.cboProducts.DataBindings.Add( new Binding( "Text", this.productsDataSet, this.productsTable + ".ProductName" ) );
		}
	}
}
