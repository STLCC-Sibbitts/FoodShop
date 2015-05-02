using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FoodShop
{
    public partial class frm_ManageEmployees : Form
    {
        DBServices db = new DBServices();

        string conString;
        string testString = "";
        int currentComboIndex = 0;
        Boolean isUpdate = false;

        public frm_ManageEmployees()
        {
            InitializeComponent();

            // Set KeyPreview object to true to allow the form to process  
            // the key before the control with focus processes it. 
            this.KeyPreview = true;
            btn_save.Enabled = false;

            // Associate the event-handling method with the KeyDown event. 
            this.KeyDown += new KeyEventHandler(frm_ManageEmployees_KeyDown);

        }

        // The form will handle all key events before the control with   
        // focus handles them.  Show the keys pressed by adding the 
        // KeyCode object to ListBox1. Ensure the processing is passed 
        // to the control with focus by setting the KeyEventArg.Handled 
        // property to false. 
        private void frm_ManageEmployees_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            btn_save.Enabled = true;
        }



        /**
         * Initializes the ManageEmployees form and connects to the database
         * 
         * */
        private void frm_ManageEmployees_Load(object sender, EventArgs e)
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

            // Populate the combo boxes for position ID and shift ID
            string posExecString = "select positionID, positionTitle from Positions";
            DataTable posDT = new DataTable();
            posDT = db.ExecuteSqlReturnTable(posExecString);

            cmb_position.ValueMember = "positionID";
            cmb_position.DisplayMember = "positionTitle";
            cmb_position.DataSource = posDT;
            //      conn.Close();

            string shiftExecString = "select shiftID, shiftTitle from Shifts";
            DataTable shiftDT = new DataTable();
            shiftDT = db.ExecuteSqlReturnTable(shiftExecString);
            cmb_shift.ValueMember = "shiftID";
            cmb_shift.DisplayMember = "shiftTitle";
            cmb_shift.DataSource = shiftDT;
        }


        // When the save button is clicked, create a new employee object with the data entered
        // by the user.
        private void btn_save_Click_1(object sender, EventArgs e)
        {
            int empNumber = 0;
            // Check if there's an existing employeeID
            if (!string.IsNullOrWhiteSpace(txt_employeeID.Text))
            {
                empNumber = int.Parse(txt_employeeID.Text);
            }

            string lastName = ValidationUtility.stringValidator(txt_lastName.Text);
            string firstName = ValidationUtility.stringValidator(txt_firstName.Text);
            DateTime whenHired = ValidationUtility.getDateTime(dtm_dateHired);
            int postID = Convert.ToInt16(cmb_position.SelectedIndex);
            int shftID = Convert.ToInt16(cmb_shift.SelectedIndex);
            int empType = getShiftType();  // this is revised method
            int payType = getSalaryType();  // this is a revised method
            decimal rateOfPay = ValidationUtility.validateRateOfPay(txt_rateOfPay.Text);
            bool isActive = getIsActive();

            // Create new employee object, and initialize it
            var newName = new Employee(empNumber, lastName, firstName, whenHired, postID, shftID, rateOfPay, empType, payType, isActive);
            // Decide whether to insert new data or update an existing record, then show status
            if (newName.employeeID == 0)
            {
                MessageBox.Show(db.addNewData(newName));
            }
            else
            {
                MessageBox.Show(db.updateData(newName));
            }
        }

        // Returns result form isActive radio button
        private bool getIsActive()
        {
            bool active = false;
            if (cbx_isActive.Checked)
                active = true;
            return active;
            throw new NotImplementedException();
        }


        // Add employee record to the database
        public void insertEmployee(Employee emp)   // This can be deleted
        {
            // create an instance of the employee
            string sqlInsert = "INSERT INTO Employees (employeeLast, employeeFirst, hireDate, positionID, shiftID, salary, fullTime, hourly, isActive) VALUES (" +
                "'" + emp.employeeLast + "'" + ", " +
                "'" + emp.employeeFirst + "'" + ", " +
                "'" + emp.hireDate + "'" + ", " +
                "'" + emp.positionID + "'" + ", " +
                "'" + emp.shiftID + "'" + ", " +
                "'" + emp.salary + "'" + ", " +
                "'" + emp.fullTime + "'" + ", " +
                "'" + emp.hourly + "'" + ", " +
                "'" + 1 + "'" + ");";
            // send the employee instance to Joe's method
            //dbs.ExecuteNonQueryReturnRowCount(sqlInsert);
        }


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
                grd_employees.Rows.Add(id, lastName, firstName, hired, compensation, active, title, shift);
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
            rowIndex = grd_employees.CurrentCell.RowIndex;
            int columnIndex = 0;
            // Revised: This returns the value (ID) given column index and row index
            int index = (int)grd_employees[columnIndex, rowIndex].Value;
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
                HireDateCal.BoldedDates.Equals(hired);

                dtm_dateHired.Value = hired;
//                dateTimePicker1.Value = DateTime.Today.AddDays(-1);

                cmb_position.SelectedIndex = posID;
                cmb_shift.SelectedIndex = shift;
                txt_rateOfPay.Text = compensation.ToString();
                txt_employeeID.Text = id.ToString();


                currentComboIndex = cmb_position.SelectedIndex;

                if (status == 0)
                {
                    rdo_fullTime.Checked = true;
                    rdo_partTime.Checked = false;
                }
                else
                {
                    rdo_partTime.Checked = true;
                    rdo_fullTime.Checked = false;
                }

                if (howPaid == 0)
                {
                    rdo_salary.Checked = true;
                    rdo_hourly.Checked = false;
                }
                else
                {
                    rdo_hourly.Checked = true;
                    rdo_salary.Checked = false;
                }
                tab_Employee.SelectTab(tab_manageEmployees);
                // Test commit

            }
        }

        // Position drop down menu
        private void cmb_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = cmb_position.SelectedValue.ToString();
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
            foreach (RadioButton rb in this.gbx_shiftType.Controls)
            {
                if (rdo_fullTime.Checked)
                    type = 1;
                // is else statement necessary?
            }
            return type;
        }


        // REVISED: employee's salary type (paid hourly or salary).
        public int getSalaryType()
        {
            int type = 0;
            foreach (RadioButton rb in this.gbx_payType.Controls)
            {
                if (rdo_salary.Checked)
                    type = 1;
            }
            return type;
        }


        private void btn_addNew_Click(object sender, EventArgs e)
        {
            tab_Employee.SelectTab(tab_manageEmployees);
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
    public class Item
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
    }
}
