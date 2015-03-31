using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        string conString;
        string testString = "";
        int currentComboIndex = 0;

        public frm_ManageEmployees()
        {
            InitializeComponent();

            // Set KeyPreview object to true to allow the form to process  
            // the key before the control with focus processes it. 
            this.KeyPreview = true;
            btn_save.Enabled = false;

            // Consider pulling these into an Initializer Class if possible
            // Initialize positionID combo box
            cmb_position.Items.Add(new Item("Store Manager", 1));
            cmb_position.Items.Add(new Item("Assistant Manager", 2));
            cmb_position.Items.Add(new Item("Kitchen Manager", 3));
            cmb_position.Items.Add(new Item("Floor Manager", 4));
            cmb_position.Items.Add(new Item("Head cook", 5));
            cmb_position.Items.Add(new Item("Cook", 6));
            cmb_position.Items.Add(new Item("Busser", 7));
            cmb_position.Items.Add(new Item("Cashier", 8));
            cmb_position.Items.Add(new Item("Counter Attendant", 9));

            // Initialize ShiftID
            cmb_shift.Items.Add(new Item("First Shift/First Half", 1));
            cmb_shift.Items.Add(new Item("First Shift/Second Half", 2));
            cmb_shift.Items.Add(new Item("First Shift", 3));
            cmb_shift.Items.Add(new Item("Second Shift/First Half", 4));
            cmb_shift.Items.Add(new Item("Second Shift/Second Half", 5));
            cmb_shift.Items.Add(new Item("Second Shift", 6));
            cmb_shift.Items.Add(new Item("Third Shift/First Half", 7));
            cmb_shift.Items.Add(new Item("Third Shift/Second Half", 8));
            cmb_shift.Items.Add(new Item("Third Shift", 9));

            // Associate the event-handling method with the 
            // KeyDown event. 
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
          //  ListBox1.Items.Add(e.KeyCode);
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
        }


        // On button click, initialize new employee
        private void btn_save_Click_1(object sender, EventArgs e)
        {
            CultureInfo enUS = new CultureInfo("en-US");
            DateTime dateValue;
            Employee employee = new Employee();

            if (txt_lastName.TextLength <= 20)
                employee.employeeLast = txt_lastName.Text;
            else
                employee.employeeLast = txt_lastName.Text.Substring(0, 20);

            if(txt_firstName.TextLength <= 20)
                employee.employeeFirst = txt_firstName.Text;
            else
                employee.employeeFirst = txt_firstName.Text.Substring(0, 20);


            if(DateTime.TryParseExact(txt_hireDate.Text, "g", enUS, DateTimeStyles.None, out dateValue))
                employee.hireDate = txt_hireDate.Text;

            employee.positionID = Convert.ToInt16(cmb_position.SelectedIndex);

            employee.shiftID = Convert.ToInt16(cmb_shift.SelectedIndex);

            if(float.Parse(txt_rateOfPay.Text) < 0)
            {
                MessageBox.Show("The pay rate cannot be less than zero. Please enter a valid rate of pay.");
            }
            else
                employee.salary = float.Parse(txt_rateOfPay.Text);

            employee.fullTime = getShiftType(employee);
            employee.hourly = getSalaryType(employee);
            // employee.isActive = TODO

            insertEmployee(employee);

            MessageBox.Show(employee.employeeLast + " " + employee.employeeFirst + " " + employee.hireDate);
        }


        // Add employee record to the database
        public void insertEmployee(Employee emp)
        {
            // create an instance of the employee
            string sqlInsert = "INSERT INTO Employees (employeeLast, employeeFirst, hireDate, positionID, shiftID, salary, fullTime, hourly, isActive) VALUES (" +
                "'" + emp.employeeLast + "'" + ", " +
                "'" + emp.employeeFirst + "'" + ", " +
                "'" + "2015-03-01" + "'" + ", " +
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
                string hired = "test"; // row["hireDate"].ToString();
                int posID = 1; // Convert.ToInt16(row["positionID"]);
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


        // Populate the edit employee tab with the results of a sql query.
        private void btn_select_Click(object sender, EventArgs e)
        {
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
                string hired = "test"; // row["hireDate"].ToString();
                int posID = 1; // Convert.ToInt16(row["positionID"]);
                int shift = Convert.ToInt16(row["shiftID"]);
                double compensation = Convert.ToDouble(row["salary"]);
                int status = 1; // Convert.ToInt16(row["fullTime"]);
                int howPaid = 1; // Convert.ToInt16(row["hourly"]);
                bool active = true;
                //       bool active = Convert.ToBoolean(row["isActive"]);
                txt_firstName.Text = firstName;
                txt_lastName.Text = lastName;
                txt_hireDate.Text = hired;
                cmb_position.SelectedIndex = posID;
                cmb_shift.SelectedIndex = shift;
                txt_rateOfPay.Text = compensation.ToString();


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
            //btn_save.Enabled = true;
        }

        private void cmb_shift_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btn_save.Enabled = true;
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

        // Return the employee's shift type (full or part-time).
        public RadioButton getShiftType(int shiftID)
        {
            RadioButton rdo_selected = new RadioButton();

            if(shiftID == 0)
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
