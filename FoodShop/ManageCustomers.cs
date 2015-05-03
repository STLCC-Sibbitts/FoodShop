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
        DBServices db = new DBServices();

        string conString;
        string testString = "";
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
         * Initializes the ManageEmployees form and connects to the database
         * 
         * */
        private void frm_ManageCustomers_Load(object sender, EventArgs e)
        {
            MessageBox.Show(conString + "/n/n" + testString);

            try
            {
                conString = db.DbConnString;
                testString = db.TestConnection();
                MessageBox.Show(conString + "/n/n" + testString);
                sqlGetTable();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            // Populate the combo boxes for birth month
  /*          string posExecString = "select positionID, positionTitle from Positions";
            DataTable posDT = new DataTable();
            posDT = db.ExecuteSqlReturnTable(posExecString);

            cmb_birthMonth.ValueMember = "positionID";
            cmb_birthMonth.DisplayMember = "positionTitle";
            cmb_birthMonth.DataSource = posDT; */
            //      conn.Close();                       
        }


        // When the save button is clicked, create a new customer object with the data entered
        // by the user.
        private void btn_save_Click_1(object sender, EventArgs e)
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
     //           MessageBox.Show(db.updateData(newName));
            }   
        }

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
            // string sqlSelect = "SELECT * FROM BreadProjectJr.is283_kmne68.Employees;";
            string sqlSelect = "SELECT e.employeeID, e.employeeLast, e.employeeFirst, e.hireDate, e.salary, e.isActive, e.positionID, Positions.positionTitle, Shifts.shiftTitle FROM Employees as e INNER JOIN Positions ON e.positionID = Positions.positionID INNER JOIN Shifts ON e.shiftID = Shifts.shiftID;";
            DataTable dataTable = new DataTable();
            //dataTable = dbs.ExecuteSqlReturnTable(sqlSelect);  // This can be deleted
            dataTable = db.ExecuteSqlReturnTable(sqlSelect);
            foreach (DataRow row in dataTable.Rows)
            {
                int id = Convert.ToInt16(row["employeeID"]);
                string lastName = row["employeeLast"].ToString();
                string firstName = row["employeeFirst"].ToString();
                string position = row["positionID"].ToString();
                string title = row["positionTitle"].ToString();
                string shift = row["shiftTitle"].ToString();
                string hired = row["hireDate"].ToString();
                string active = ValidationUtility.isNull(row["isActive"]);
                decimal compensation = Convert.ToDecimal(row["salary"]);
                int howPaid = 1; // Convert.ToInt16(row["hourly"]);
                grd_Customers.Rows.Add(id, lastName, firstName, hired, compensation, active, title, shift);
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


        // Populate the edit employee tab fields with the results of a sql query.
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
            sqlQuery = "SELECT * FROM Employees WHERE employeeID = " + index + ";";
            dataTable = db.ExecuteSqlReturnTable(sqlQuery);

            foreach (DataRow row in dataTable.Rows)
            {
                int id = Convert.ToInt16(row["employeeID"]);
                string lastName = row["employeeLast"].ToString();
                string firstName = row["employeeFirst"].ToString();
                DateTime hired = Convert.ToDateTime(row["hireDate"]);

                int posID = 1; // Convert.ToInt16(row["positionID"]);
                int shift = Convert.ToInt16(row["shiftID"]);
                double compensation = Convert.ToDouble(row["salary"]);
                int status = 1; // Convert.ToInt16(row["fullTime"]);
                int howPaid = 1; // Convert.ToInt16(row["hourly"]);
                bool active = true;
         //       bool active = Convert.ToBoolean(row["isActive"]);
                txt_firstName.Text = firstName;
                txt_lastName.Text = lastName;

                dtm_enrollDate.Value = hired;
//                dateTimePicker1.Value = DateTime.Today.AddDays(-1);

 /*               cmb_position.SelectedIndex = posID;
                cmb_shift.SelectedIndex = shift;
                txt_rateOfPay.Text = compensation.ToString();
                txt_employeeID.Text = id.ToString();                        */
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
