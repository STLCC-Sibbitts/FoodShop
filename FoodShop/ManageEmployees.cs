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
        // Create a DBServices instance
        DBServices db = new DBServices();

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
            MessageBox.Show(db.TestConnection());
            sqlGetTable();


            // Populate the combo boxes for position ID and shift ID
            // Comboboxes default values are assinged to ID=0 in the database table
            string posExecString = "Select PositionID, PositionTitle from Position";
            DataTable posDT = new DataTable();
            posDT = db.ExecuteSqlReturnTable(posExecString);
            cmb_position.ValueMember = "PositionID";
            cmb_position.DisplayMember = "PositionTitle";
            cmb_position.DataSource = posDT;

            string shiftExecString = "Select ShiftID, ShiftTitle from Shift";
            DataTable shiftDT = new DataTable();
            shiftDT = db.ExecuteSqlReturnTable(shiftExecString);
            cmb_shift.ValueMember = "ShiftID";
            cmb_shift.DisplayMember = "ShiftTitle";
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

            string lastName = stringValidator(txt_lastName.Text);
            string firstName = stringValidator(txt_firstName.Text);
            //string whenHired = HireDateCal.SelectionStart.ToShortDateString();
            DateTime whenHired = dtm_dateHired.Value;
            int postID = Convert.ToInt16(cmb_position.SelectedIndex);
            int shftID = Convert.ToInt16(cmb_shift.SelectedIndex);
            int empType = getShiftType();  // this is revised method
            int payType = getSalaryType();  // this is a revised method
            decimal rateOfPay = validateRateOfPay(txt_rateOfPay.Text);
            bool isActive = getIsActive();
            // employee.isActive = TODO
            // Create new employee object, and initialize it
            var newName = new Employee(empNumber, lastName, firstName, whenHired, postID, shftID, rateOfPay, empType, payType, isActive);
            // Decide whether to insert new data or update an old employee data, then show status
            if (newName.employeeID == 0)
            {
                MessageBox.Show(db.addNewData(newName)); //This is working
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

        // Retrieve values for the grid. Grid correctly populates data after merging with test branch
        public void sqlGetTable()
        {
            //string sqlSelect = "SELECT * FROM BreadProjectJr.is283_kmne68.Employees;";
            //string sqlSelect = "SELECT * FROM BreadProject.jarcelo_admin.Employee;";
            string sqlSelect = "SELECT * FROM Employee;";

            DataTable dataTable = new DataTable();

            //dataTable = dbs.ExecuteSqlReturnTable(sqlSelect);  // This can be deleted
            dataTable = db.ExecuteSqlReturnTable(sqlSelect);

            foreach (DataRow row in dataTable.Rows)
            {
                //int id = Convert.ToInt16(row["employeeID"]);
                int id = Convert.ToInt16(row["EmployeeID"]);
                //string lastName = row["employeeLast"].ToString();
                string lastName = row["EmployeeLast"].ToString();
                //string firstName = row["employeeFirst"].ToString();
                string firstName = row["EmployeeFirst"].ToString();
                //string hired = row["hireDate"].ToString();
                string hired = row["HireDate"].ToString();
                //int posID = isValidID((Convert.ToInt16(row["positionID"])));
                //int posID = SafeGetInt(row, "positionID");
                int posID = SafeGetInt(row, "PositionID");
                //MessageBox.Show("posID = " + posID);
                string title = "test title";
                int shift = Convert.ToInt16(row["ShiftID"]);
                //int shift = 1;
                //double compensation = Convert.ToDouble(row["salary"]);
                //double compensation = 10.1;  //TODO: Make this decimal for money data type
                decimal compensation = Convert.ToDecimal(row["Salary"]);
                int status = Convert.ToInt16(row["FullTime"]);
                int howPaid = Convert.ToInt16(row["Hourly"]);
                //bool active = true;
                bool active = Convert.ToBoolean(row["IsActive"]);

                //MessageBox.Show("employee name: " + lastName + firstName);

                grd_Employees.Rows.Add(id, lastName, firstName, hired, compensation, active, title, shift, posID, status, howPaid);
            }
        }

        public static int SafeGetInt(DataRow row, string colName)
        {
            if (!DBNull.Value.Equals(row[colName]))
                return Convert.ToInt16(row[colName]);
            else
                return -1;
        }


        // Populate the edit employee tab fields with the results of a sql query.
        // Make index a global variable so delete button can retrieve the index value 
        int index;
        private void btn_select_Click(object sender, EventArgs e)
        {
            isUpdate = true;
            int rowIndex;
            string sqlQuery;

            DataTable dataTable = new DataTable();

            // sqlGetTable();
            rowIndex = grd_Employees.CurrentCell.RowIndex;
            int columnIndex = 0;
            // Revised: This returns the value (ID) given column index and row index
            //int index = (int)grd_employees[columnIndex, rowIndex].Value;
            index = (int)grd_Employees[columnIndex, rowIndex].Value;
            //MessageBox.Show("rowIndex = " + rowIndex);

            //sqlQuery = "SELECT * FROM Employees WHERE employeeID = " + rowIndex + ";";
            sqlQuery = "SELECT * FROM Employee WHERE EmployeeID = " + index + ";";

            //dataTable = dbs.ExecuteSqlReturnTable(sqlQuery);
            dataTable = db.ExecuteSqlReturnTable(sqlQuery);

            foreach (DataRow row in dataTable.Rows)
            {
                //int id = Convert.ToInt16(row["employeeID"]);
                int id = Convert.ToInt16(row["EmployeeID"]);
                //string lastName = row["employeeLast"].ToString();
                string lastName = row["EmployeeLast"].ToString();
                //string firstName = row["employeeFirst"].ToString();
                string firstName = row["EmployeeFirst"].ToString();
                //DateTime hired = Convert.ToDateTime(row["hireDate"]);
                DateTime hired = Convert.ToDateTime(row["HireDate"]);

                //int posID = 1; // Convert.ToInt16(row["positionID"]);
                int posID = Convert.ToInt16(row["PositionID"]);
                //int shift = Convert.ToInt16(row["shiftID"]);
                int shift = Convert.ToInt16(row["ShiftID"]);
                //double compensation = Convert.ToDouble(row["salary"]);
                double compensation = Convert.ToDouble(row["Salary"]);
                int status = 1; // Convert.ToInt16(row["fullTime"]);
                int howPaid = 1; // Convert.ToInt16(row["hourly"]);
                //bool active = true;
                //bool active = Convert.ToBoolean(row["IsActive"]);
                int active = Convert.ToInt16(row["IsActive"]);
                txt_firstName.Text = firstName;
                txt_lastName.Text = lastName;
                //HireDateCal.BoldedDates.Equals(hired);
                cbx_isActive.Checked = (active > 0); // Checkbox is checked when value is 1
                dtm_dateHired.Value = hired;
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

        private void cmb_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = cmb_position.SelectedValue.ToString();
            btn_save.Enabled = true;
        }

        private void cmb_shift_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
        }

        // Returns position id after ensuring it is a valid value
        private int isValidID(int id)
        {
            int posID = 0;
            if (id != null)
            {
                posID = id;
            }
            else
                posID = -1;
            return posID;
        }


        private string stringValidator(string text)
        {
            string name;
            if (text.Length <= 20)
                //employee.employeeLast = txt_lastName.Text;
                name = text;
            else
                //employee.employeeLast = txt_lastName.Text.Substring(0, 20);
                name = text.Substring(0, 20);
            return name;
        }



        private void gbx_workerType_Enter(object sender, EventArgs e)
        {
        }


        // Return the employee's shift type (full or part-time).
        public int getShiftType(Employee emp)
        {
            foreach (RadioButton rb in this.gbx_shiftType.Controls)
            {
                if (rdo_fullTime.Checked)
                    emp.fullTime = 1;
                if (rdo_partTime.Checked)
                    emp.fullTime = 0;
            }
            return emp.fullTime;
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


        // Return the employee's shift type (full or part-time).
        public RadioButton getShiftType(int shiftID)
        {
            RadioButton rdo_selected = new RadioButton();

            if (shiftID == 0)
                rdo_selected = rdo_fullTime;
            if (shiftID == 1)
                rdo_selected = rdo_partTime;
            return rdo_selected;
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

        // Validate rate of pay
        private decimal validateRateOfPay(string pay)
        {
            /*   if (decimal.Parse(pay) < 0)
               {
                   MessageBox.Show("The pay rate cannot be less than zero. Please enter a valid rate of pay.");
               }
               else
                   rateOfPay = decimal.Parse(txt_rateOfPay.Text); */
            decimal num;
            bool isValid = decimal.TryParse(pay, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"), // cached
            out num);
            return num;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // This is working!
            string sql = "DELETE FROM Employee WHERE EmployeeID = " + index + ";";
            MessageBox.Show(db.deleteRecord(sql));
        }

        private void grd_employees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
