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
    public partial class MainMenu : Form
    {
     /*   DatabaseServices dbs = new DatabaseServices();
        string conString;
        string testString = "";

        Employee employee = new Employee(); */


        public MainMenu()
        {
            InitializeComponent();
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }


  /*      private void MainMenu_Load(object sender, EventArgs e)
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
        } */


/*        private void btn_save_Click(object sender, EventArgs e)
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

        private void MainMenu_Load(object sender, EventArgs e)
        {
         /*   try
            {
                conString = dbs.DbConnectionString;
                testString = dbs.TestConnection();
                MessageBox.Show(conString + "/n/n" + testString);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            } */
        }

        private void btn_employees_Click_1(object sender, EventArgs e)
        {
            frm_ManageEmployees formManageEmployees = new frm_ManageEmployees();
            //formManageEmployees.Show();
            formManageEmployees.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            frm_ManageCustomers formManageCustomers = new frm_ManageCustomers();
            formManageCustomers.Show();

        }


    }
}
