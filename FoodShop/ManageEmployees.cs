using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public frm_ManageEmployees()
        {
            InitializeComponent();

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

            Employee employee = new Employee();

            employee.employeeLast = txt_lastName.Text;
            employee.employeeFirst = txt_firstName.Text;
            employee.hireDate = txt_hireDate.Text;
            employee.positionID = Convert.ToInt16(cmb_position.SelectedIndex);
            employee.shiftID = Convert.ToInt16(cmb_shift.SelectedIndex);
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
                int shift = Convert.ToInt16(row["shiftID"]);
                double compensation = Convert.ToDouble(row["salary"]);
                int status = 1; // Convert.ToInt16(row["fullTime"]);
                int howPaid = 1; // Convert.ToInt16(row["hourly"]);
                bool active = true;
       //       bool active = Convert.ToBoolean(row["isActive"]);

                MessageBox.Show("employee name: " + lastName + firstName);

                grd_employees.Rows.Add(id, lastName, firstName, hired, posID, shift, compensation, status, howPaid);
            }
        }


        private void btn_select_Click(object sender, EventArgs e)
        {
            // sqlGetTable();
        }



        private void cmb_position_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmb_shift_SelectedIndexChanged(object sender, EventArgs e)
        {
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
