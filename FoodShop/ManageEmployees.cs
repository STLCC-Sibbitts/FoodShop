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

        //        Employee employee = new Employee();

        public frm_ManageEmployees()
        {
            InitializeComponent();

            // Consider pulling these into an Initializer Class
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

        /*
                private void ManageEmployees_Load(object sender, EventArgs e)
                {

                } */

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
            Employee employee = new Employee();

            employee.employeeLast = txt_lastName.Text;
            employee.employeeFirst = txt_firstName.Text;
            employee.hireDate = txt_hireDate.Text;
            // employee.positionID = TODO
            // employee.shiftID = TODO
            employee.salary = float.Parse(txt_rateOfPay.Text);
            // employee.isActive = TODO
            // employee.fullTime = TODO
            // employee.hourly = TODO

            insertEmployee(employee);

            MessageBox.Show(employee.employeeLast + " " + employee.employeeFirst + " " + employee.hireDate);

            // string sqlInsert = "INSERT INTO Employees (employeeLast, employeeFirst, hireDate, positionID, shiftID, salary, fullTime, hourly, isActive) VALUES (" +
            // removed extra variables, hard-coded a shiftID to avoid true/false errors.

            /*          string sqlInsert = "INSERT INTO Employees (employeeLast, employeeFirst, shiftID, salary) VALUES (" +
                          "'" + employee.employeeLast + "'" + ", " +

                          "'" + employee.employeeFirst + "'" + ", " +

                          "'" + 2 + "'" + ", " +

                          "'" + employee.salary + "'" + ");";

                      dbs.ExecuteNonQueryReturnRowCount(sqlInsert); */

        }


        public void insertEmployee(Employee emp)
        {
            string sqlInsert = "INSERT INTO Employees (employeeLast, employeeFirst, shiftID, salary) VALUES (" +
                "'" + emp.employeeLast + "'" + ", " +

                "'" + emp.employeeFirst + "'" + ", " +

                "'" + 2 + "'" + ", " +

                "'" + emp.salary + "'" + ");";

            dbs.ExecuteNonQueryReturnRowCount(sqlInsert);
        }


        public void sqlGetTable()           // (Employee emp)
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
                //       int posID = Convert.ToInt32(row["positionID"]);
                //       int shift = Convert.ToInt32(row["shiftID"]);
                double compensation = Convert.ToDouble(row["salary"]);
                //       bool active = Convert.ToBoolean(row["isActive"]);
                //       bool status = Convert.ToBoolean(row["fullTime"]);
                //       bool paid = Convert.ToBoolean(row["hourly"]);
                MessageBox.Show("employee name: " + lastName + firstName);

                grd_employees.Rows.Add(id, lastName, firstName, compensation);

                //            this.dataGridView1.Rows.Add("1", "XX");
            }

        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            // sqlGetTable();
        }

        private void cmb_position_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Display the Value property
            Item positionItem = (Item)cmb_position.SelectedItem;
            Console.WriteLine("{0}, {1}", positionItem.Name, positionItem.Value);
        }

        private void cmb_shift_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the Value property
            Item positionItem = (Item)cmb_position.SelectedItem;
            Console.WriteLine("{0}, {1}", positionItem.Name, positionItem.Value);

        }




        /*            {/*
                      grd_employees.Rows.Add()
                      textBox.Text = DR1.GetValue(0).ToString();
                      this.dataGridView1.Rows.Add("1", "XX"); */

        /*               public static void Map<T>(this IEnumerable<T> source, Action<T> func)
       {
           foreach (T i in source)
               func(i);
       }

       X.Map(item => this.dataGridView1.Rows.Add(item.ID, item.Name)); 
                   }
               }*/


    }
    // Content item for the combo box
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
