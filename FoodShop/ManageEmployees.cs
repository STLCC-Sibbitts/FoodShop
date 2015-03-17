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

        Employee employee = new Employee();

        public frm_ManageEmployees()
        {
            InitializeComponent();
        }


        private void ManageEmployees_Load(object sender, EventArgs e)
        {
            try
            {
                conString = dbs.DbConnectionString;
                testString = dbs.TestConnection();
                MessageBox.Show(conString + "/n/n" + testString);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

   /*     private void btn_save_Click(object sender, EventArgs e)
        {
            employee.employeeLast = txt_lastName.Text;
            employee.employeeFirst = txt_firstName.Text;
            employee.hireDate = txt_hireDate.Text;
            // employee.positionID = TODO
            // employee.shiftID = TODO
            employee.salary = float.Parse(txt_rateOfPay.Text);
            // employee.isActive = TODO
            // employee.fullTime = TODO
            // employee.hourly = TODO
            
            MessageBox.Show(employee.employeeLast + " " + employee.employeeFirst + " " + employee.hireDate);

            // string sqlInsert = "INSERT INTO Employees (employeeLast, employeeFirst, hireDate, positionID, shiftID, salary, fullTime, hourly, isActive) VALUES (" +
            // removed extra variables, hard-coded a shiftID to avoid true/false errors.

            string sqlInsert = "INSERT INTO Employees (employeeLast, employeeFirst, shiftID, salary) VALUES (" +
                "'" + employee.employeeLast + "'" + ", " +

                "'" + employee.employeeFirst + "'" + ", " +

                "'" + 2 + "'" + ", " +

                "'" + employee.salary + "'"  + ");";

            dbs.ExecuteNonQueryReturnRowCount(sqlInsert);
        } */

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            employee.employeeLast = txt_lastName.Text;
            employee.employeeFirst = txt_firstName.Text;
            employee.hireDate = txt_hireDate.Text;
            // employee.positionID = TODO
            // employee.shiftID = TODO
            employee.salary = float.Parse(txt_rateOfPay.Text);
            // employee.isActive = TODO
            // employee.fullTime = TODO
            // employee.hourly = TODO

            MessageBox.Show(employee.employeeLast + " " + employee.employeeFirst + " " + employee.hireDate);

            // string sqlInsert = "INSERT INTO Employees (employeeLast, employeeFirst, hireDate, positionID, shiftID, salary, fullTime, hourly, isActive) VALUES (" +
            // removed extra variables, hard-coded a shiftID to avoid true/false errors.

            string sqlInsert = "INSERT INTO Employees (employeeLast, employeeFirst, shiftID, salary) VALUES (" +
                "'" + employee.employeeLast + "'" + ", " +

                "'" + employee.employeeFirst + "'" + ", " +

                "'" + 2 + "'" + ", " +

                "'" + employee.salary + "'" + ");";

            dbs.ExecuteNonQueryReturnRowCount(sqlInsert);

        }
    } 
}
