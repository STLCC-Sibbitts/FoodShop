using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace FoodShop
{
    public partial class frm_ManageCustomers : Form
    {
        // Create a DBServices instance
        DBServices db = new DBServices();

        //    string conString;
        //    string testString = "";
        int currentComboIndex = 0;
        Boolean isUpdate = false;

        public frm_ManageCustomers()
        {
            InitializeComponent();
            // Set KeyPreview object to true to allow the form to process  
            // the key before the control with focus processes it. 
            this.KeyPreview = true;
            btn_save.Enabled = false;

            // Associate the event-handling method with the KeyDown event. 
            this.KeyDown += new KeyEventHandler(frm_ManageCustomers_KeyDown);
        }


        // The form will handle all key events before the control with   
        // focus handles them.  Show the keys pressed by adding the 
        // KeyCode object to ListBox1. Ensure the processing is passed 
        // to the control with focus by setting the KeyEventArg.Handled 
        // property to false. 
        private void frm_ManageCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            btn_save.Enabled = true;
        }



        /**
         * Initializes the ManageCustomers form and connects to the database
         * 
         * */
        private void frm_ManageCustomers_Load(object sender, EventArgs e)
        {
            MessageBox.Show(db.TestConnection());
            sqlGetTable();

            // Populate the combo boxes for birth month
            string monthExecString = "select MonthID, MonthName from Month";
            DataTable monthDT = new DataTable();
            monthDT = db.ExecuteSqlReturnTable(monthExecString);

            cmb_birthMonth.ValueMember = "MonthID";
            cmb_birthMonth.DisplayMember = "MonthName";
            cmb_birthMonth.DataSource = monthDT;
        }


        // When the save button is clicked, create a new customer object with the data entered
        // by the user.
        /*     private void btn_save_Click_1(object sender, EventArgs e)
             {
                 int customerNumber = 0;
                 // Check if there's an existing customerID
                 if (!string.IsNullOrWhiteSpace(txt_customerID.Text))
                 {
                     customerNumber = int.Parse(txt_customerID.Text);
                 }

                 string lastName = ValidationUtility.stringValidator(txt_lastName.Text);
                 string firstName = ValidationUtility.stringValidator(txt_firstName.Text);
                 string gender = "male";
                 string eMail = ValidationUtility.stringValidator(txt_email.Text);
                 string telephone = ValidationUtility.stringValidator(txt_phone.Text);
                 DateTime frequentEnrollDate = ValidationUtility.getDateTime(dtm_enrollDate);
                 DateTime birthMonthDay = ValidationUtility.getDateTime(dtm_enrollDate);

                 // Create new employee object, and initialize it
                 var newName = new Customer(customerNumber, lastName, firstName, gender, eMail, telephone, birthMonthDay, frequentEnrollDate);

                 // Decide whether to insert new data or update an existing record, then show status
                 if (newName.customerID == 0)
                 {
                     MessageBox.Show(db.addNewData(newName));
                 }
                 else
                 {
                     MessageBox.Show(db.updateData(newName));
                 }   
             }
     */
        // Add customer record to the database
        /*        public void insertCustomer(Customer cust)   // This can be deleted
                {
                    // create an instance of the employee
                    string sqlInsert = "INSERT INTO Employees (customerLast, employeeFirst, hireDate, positionID, shiftID, salary, fullTime, hourly, isActive) VALUES (" +
                        "'" + cust.customerLast + "'" + ", " +
                        "'" + cust.customerFirst + "'" + ", " +
                        "'" + cust.gender + "'" + ", " +
                        "'" + cust.eMail + "'" + ", " +
                        "'" + cust.telephone + "'" + ", " +
                        "'" + cust.birthMonthDay + "'" + ", " +
                        "'" + cust.frequentEnrollDate + "'" + ", " +
                        "'" + 1 + "'" + ");";
                } */


        // Retrieve values for the grid.
        public void sqlGetTable()
        {
            string sqlSelect = "SELECT * FROM Customer;";
            DataTable dataTable = new DataTable();
            //dataTable = dbs.ExecuteSqlReturnTable(sqlSelect);  // This can be deleted
            dataTable = db.ExecuteSqlReturnTable(sqlSelect);
            foreach (DataRow row in dataTable.Rows)
            {
                int id = Convert.ToInt16(row["CustomerID"]);
                string lastName = row["CustomerLast"].ToString();
                string firstName = row["CustomerFirst"].ToString();
                string gender = row["Gender"].ToString();
                string email = row["Email"].ToString();
                string phone = row["Telephone"].ToString();
                string birthday = row["BirthMonthDay"].ToString();
                string enrollDate = row["FrequentEnrollDate"].ToString();
                grd_Customers.Rows.Add(id, lastName, firstName, gender, email, phone, birthday, enrollDate);
            }
        }


        // Retrieves values for the data grid.
        public static int SafeGetInt(DataRow row, string colName)
        {
            if (!DBNull.Value.Equals(row[colName]))
                return Convert.ToInt16(row[colName]);
            else
                return -1;
        }


        // Populate the edit customer tab fields with the results of a sql query.
        private void btn_select_Click(object sender, EventArgs e)
        {
            isUpdate = true;
            int rowIndex;
            string sqlQuery;

            DataTable dataTable = new DataTable();

            // sqlGetTable();
            rowIndex = grd_Customers.CurrentCell.RowIndex;
            int columnIndex = 0;
            // Revised: This returns the value (ID) given column index and row index
            int index = (int)grd_Customers[columnIndex, rowIndex].Value;
            sqlQuery = "SELECT * FROM Customers WHERE CustomerID = " + index + ";";
            dataTable = db.ExecuteSqlReturnTable(sqlQuery);

            foreach (DataRow row in dataTable.Rows)
            {
                int id = Convert.ToInt16(row["CustomerID"]);
                string lastName = row["CustomerLast"].ToString();
                string firstName = row["CustomerFirst"].ToString();
                string gender = row["Gender"].ToString();
                string email = row["Email"].ToString();
                string phone = row["Telephone"].ToString();
                int birthday = Convert.ToInt16(row["BirthMoDay"]);
                DateTime enrollDate = Convert.ToDateTime(row["FrequentEnrollDate"]);

                txt_firstName.Text = firstName;
                txt_lastName.Text = lastName;
                txt_email.Text = email;
                txt_phone.Text = phone;
                cmb_birthMonth.SelectedIndex = birthday;
                dtm_enrollDate.Value = enrollDate;
            }
        }

        // Position drop down menu
        private void cmb_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    string ID = cmb_position.SelectedValue.ToString();
        }

        // Menu drop down menu
        private void cmb_shift_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btn_save.Enabled = true;
        }


        // REVISED: employee's shift type (full or part-time).
        public int getShiftType()
        {
            int type = 0;
            foreach (RadioButton rb in this.gbx_gender.Controls)
            {
                if (rdo_female.Checked)
                    type = 1;
                else if (rdo_female.Checked)
                    type = 2;
            }
            return type;
        }


        private void btn_addNew_Click(object sender, EventArgs e)
        {
            tab_Customer.SelectTab(tab_manageCustomers);
        }

        private void btn_exitApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_exitToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_tabExitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tabExitToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            tab_Customer.SelectTab(tab_manageCustomers);
        }

        // When the save button is clicked, create a new customer object with the data entered
        // by the user.
        private void btn_save_Click(object sender, EventArgs e)
        {
            int customerNumber = 0;
            // Check if there's an existing customerID
            if (!string.IsNullOrWhiteSpace(txt_customerID.Text))
            {
                customerNumber = int.Parse(txt_customerID.Text);
            }

            string lastName = ValidationUtility.stringValidator(txt_lastName.Text);
            string firstName = ValidationUtility.stringValidator(txt_firstName.Text);
            string gender = "male";
            string eMail = ValidationUtility.stringValidator(txt_email.Text);
            string telephone = ValidationUtility.stringValidator(txt_phone.Text);
            DateTime frequentEnrollDate = ValidationUtility.getDateTime(dtm_enrollDate);
            DateTime birthMonthDay = ValidationUtility.getDateTime(dtm_enrollDate);

            // Create new employee object, and initialize it
            var newName = new Customer(customerNumber, lastName, firstName, gender, eMail, telephone, birthMonthDay, frequentEnrollDate);

            // Decide whether to insert new data or update an existing record, then show status
            if (newName.customerID == 0)
            {
                MessageBox.Show(db.addNewData(newName));
            }
            else
            {
                MessageBox.Show(db.updateData(newName));
            }
        }

        private void btn_exitCustomers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

/*        private void btn_exitApplication_Click_1(object sender, EventArgs e)
        {
            MainMenu.ActiveForm.Disposed += new EventHandler(closeMenu);
        }

        private void closeMenu(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();

            if(menu != null)
                MainMenu.ActiveForm.Dispose();
        } 
*/
        private void btn_exitToMenu_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }


    }


    // Content items for the combo box
 /*   public class Item
    {
        public string Name;
        public int Value;
        public Item(string name, int value)
        {
            Name = name; Value = value;
        }
        public override string ToString()
        {
            // Generates the text shown in the combo box
            return Name;
        }
    } */
}
