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
        DatabaseServices dbs = new DatabaseServices();
        string conString;
        string testString = "";

        Employee employee = new Employee();


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

        private void btn_employees_Click(object sender, EventArgs e)
        {
 //           frm_ManageEmployees formManageEmployees = new frm_ManageEmployees();
 //           formManageEmployees.Show();
        }



        private void btn_save_Click(object sender, EventArgs e)
        {
            string first = "";
            string last = "";
            employee.employeeLast = txt_lastName.Text;
            employee.employeeFirst = txt_firstName.Text;
            first = employee.employeeFirst;
            last = employee.employeeLast;
            //  employee.hireDate = txt_hireDate.ToString();
            tab_mainMenu.Show();

            MessageBox.Show(first + last);
        }

        private void MainMenu_Load(object sender, EventArgs e)
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
    }
}
