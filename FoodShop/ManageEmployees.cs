﻿using System;
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
        DatabaseServices dbs = new DatabaseServices();

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

            // tried this to regiser changes in combo box
            if (cmb_position.SelectedIndex != currentComboIndex)
            {
                //btn_save.Enabled = true;
            }
        }


        // tried this to regiser changes in combo box
        private void frm_ManageEmployees_MouseClick(object sender, KeyEventArgs e)
        {
            if (cmb_position.SelectedIndex != currentComboIndex)
            {
                // btn_save.Enabled = true;
            }
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
                conString = dbs.DbConnectionString;
                testString = dbs.TestConnection();
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
            posDT = dbs.ExecuteSqlReturnTable(posExecString);
            //      dt.Load(reader);

            cmb_position.ValueMember = "positionID";
            cmb_position.DisplayMember = "positionTitle";
            cmb_position.DataSource = posDT;
            //      conn.Close();

            string shiftExecString = "select shiftID, shiftTitle from Shifts";
            DataTable shiftDT = new DataTable();
            shiftDT = dbs.ExecuteSqlReturnTable(shiftExecString);
            cmb_shift.ValueMember = "shiftID";
            cmb_shift.DisplayMember = "shiftTitle";
            cmb_shift.DataSource = shiftDT;
        }


        // When the save button is clicked, create a new employee object with the data entered
        // by the user.
        private void btn_save_Click_1(object sender, EventArgs e)
        {
            string lastName = stringValidator(txt_lastName.Text);
            string firstName = stringValidator(txt_firstName.Text);
            string whenHired = HireDateCal.SelectionStart.ToShortDateString();
            int postID = Convert.ToInt16(cmb_position.SelectedIndex);
            int shftID = Convert.ToInt16(cmb_shift.SelectedIndex);
            int empType = getShiftType();  // this is revised method
            int payType = getSalaryType();  // this is a revised method
            decimal rateOfPay = validateRateOfPay(txt_rateOfPay.Text);

            // employee.isActive = TODO


            // Create an employee object using the custom constructor in the employee class
            var employee = new Employee
            {
                employeeLast = lastName,
                employeeFirst = firstName,
                hireDate = whenHired,
                positionID = postID,
                shiftID = shftID,
                salary = rateOfPay,
                fullTime = empType,
                hourly = payType,
                isActive = true
            };

            db.updateData(employee);
            // Save employee object to DB
     /*       if (isUpdate)
            {
                // TODO pass employee to UPDATE function
            }
            if (!isUpdate)
            { */
                MessageBox.Show("using new updateEmployee method: " + db.SaveData(employee));
   //         }
        }


        // Add employee record to the database
        public void insertEmployee(Employee emp)
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
            dbs.ExecuteNonQueryReturnRowCount(sqlInsert);
        }


        // Retrieve values for the grid.
        public void sqlGetTable()
        {
            string sqlSelect = "SELECT * FROM BreadProjectJr.is283_kmne68.Employees;";

            DataTable dataTable = new DataTable();

            dataTable = dbs.ExecuteSqlReturnTable(sqlSelect);

            foreach (DataRow row in dataTable.Rows)
            {
                int id = Convert.ToInt16(row["employeeID"]);
                string lastName = row["employeeLast"].ToString();
                string firstName = row["employeeFirst"].ToString();
                string hired = row["hireDate"].ToString();

                //int posID = isValidID((Convert.ToInt16(row["positionID"])));
                int posID = SafeGetInt(row, "positionID");
                MessageBox.Show("posID = " + posID);

                string title = "test title";
                int shift = Convert.ToInt16(row["shiftID"]);
                double compensation = Convert.ToDouble(row["salary"]);
                int status = 1; // Convert.ToInt16(row["fullTime"]);
                int howPaid = 1; // Convert.ToInt16(row["hourly"]);
                bool active = true;
                //       bool active = Convert.ToBoolean(row["isActive"]);

                MessageBox.Show("employee name: " + lastName + firstName);

                grd_employees.Rows.Add(id, lastName, firstName, posID, title, shift, hired, active, compensation, status, howPaid);
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
        private void btn_select_Click(object sender, EventArgs e)
        {
            isUpdate = true;
            int rowIndex;
            string sqlQuery;

            DataTable dataTable = new DataTable();

            // sqlGetTable();
            rowIndex = grd_employees.CurrentCell.RowIndex;
            MessageBox.Show("rowIndex = " + rowIndex);

            sqlQuery = "SELECT * FROM Employees WHERE employeeID = " + rowIndex + ";";

            dataTable = dbs.ExecuteSqlReturnTable(sqlQuery);

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
        }

        private void cmb_shift_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btn_save.Enabled = true;
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


        // Return the employee's salary type (paid hourly or salary).
        public int getSalaryType(Employee emp)
        {
            foreach (RadioButton rb in this.gbx_payType.Controls)
            {
                if (rdo_salary.Checked)
                    emp.hourly = 1;
                if (rdo_hourly.Checked)
                    emp.hourly = 0;
            }
            return emp.hourly;
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

        // Return the employee's salary type (paid hourly or salary).
        public RadioButton getSalaryType(int salaryID)
        {
            RadioButton rdo_selected = new RadioButton();

            if (salaryID == 0)
                rdo_selected = rdo_salary;
            if (salaryID == 1)
                rdo_selected = rdo_hourly;
            return rdo_selected;
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
